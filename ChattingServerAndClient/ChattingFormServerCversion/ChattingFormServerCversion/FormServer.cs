using System.Collections.ObjectModel;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;
using System.Diagnostics;

namespace ChattingFormServerCversion
{
    public partial class FormServer : Form
    {
        ClientManager clientManager = ClientManager.GetInstance();
        private object lockObj = new object();
        public static List<string> chattingLogList = new List<string>();
        public static List<string> userList = new List<string>();
        public static List<string> AccessLogList = new List<string>();

        Task? conntectCheckThread = null;//연결을 체크하는 스레드
        string roomID = null;

        DBManager dbmanager = DBManager.GetInstance();

        public FormServer()
        {
            
            InitializeComponent();
            string debugCheck = "디버깅용 테스트서버를 사용하시려면 예, 실제 채팅프로그램 사용하려면 아니오를 눌러주세요";
            DialogResult nameMessageBoxResult = MessageBox.Show(debugCheck, "Question", MessageBoxButtons.YesNo);
            if (nameMessageBoxResult == DialogResult.Yes)
            {
                ClientData.isdebug = true;
            }
            else
            {
                ClientData.isdebug = false;
            }
            MainServerStart();//다른 스렐드에서 메인 서버가 클라이언트 msg를 listen
            ClientManager.messageParsingAction += MessageParsing;//이벤트 추가
            ClientManager.ChangeListBoxAction += ChangeListBox;


            listBoxChattingLog.DataSource = chattingLogList;//리스트를 리스트 박스에 바인딩
            listBoxAccessLog.DataSource = AccessLogList;
            listBoxUser.DataSource = userList;



            conntectCheckThread = new Task(ConnectCheckLoop);//연결 체크 스레드 
            conntectCheckThread.Start(); //실행


        }
        public FormServer(string str)
        {

        }
        private void FormServer_Load(object sender, EventArgs e)
        {
            
        }
        private void ListBoxRefresh()
        {
            listBoxChattingLog.DataSource = null;//리스트를 리스트 박스에 바인딩
            listBoxAccessLog.DataSource = null;
            listBoxUser.DataSource = null;

            listBoxChattingLog.DataSource = chattingLogList;//리스트를 리스트 박스에 바인딩
            listBoxAccessLog.DataSource = AccessLogList;
            listBoxUser.DataSource = userList;
        }
        private void ListBoxRefresh(ListBox listbox, List<string> list, string DisplayName, string ValueName)
        {
            listbox.DataSource = null;
            listbox.DataSource = list;
            listbox.DisplayMember = DisplayName;
            listbox.ValueMember = ValueName;
        }
    

        private void ConnectCheckLoop()
        {
            while (true)
            {
                foreach (var item in ClientManager.clientDic)
                {
                    try
                    {
                        string sendStringData = "관리자<TEST>";
                        byte[] sendByteData = new byte[sendStringData.Length];
                        sendByteData = Encoding.Default.GetBytes(sendStringData);

                        item.Value.tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);
                    }
                    catch (Exception e)
                    {
                        clientManager.RemoveClient(item.Value);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        private void RemoveClient(ClientData targetClient)
        {
            ClientData result = null;
            ClientManager.clientDic.TryRemove(targetClient.clientNumber, out result);
            string leaveLog = string.Format("[{0}] {1} Leave Server", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), result.clientName);
            //ChangeListBoxAction.Invoke(leaveLog, StaticDefine.ADD_ACCESS_LIST);
            //ChangeListBoxAction.Invoke(result.clientName, StaticDefine.REMOVE_USER_LIST);
            if (this.listBoxAccessLog.InvokeRequired)
            {
                this.listBoxAccessLog.Invoke(new MethodInvoker(delegate {
                    AccessLogList.Add(leaveLog); ListBoxRefresh(); ;
                }));
            }
            if (this.listBoxUser.InvokeRequired)
            {
                this.listBoxUser.Invoke(new MethodInvoker(delegate {
                    userList.Remove(result.clientName); ListBoxRefresh(); ;
                }));
            }
        }

        private void ChangeListBox(string Message, int key)
        {
            ChangeListBox(Message, key, chattingLogList);
        }

        private void ChangeListBox(string Message, int key, List<string>? chattingLogList)
        {
            switch (key)
            {
                case StaticDefine.ADD_ACCESS_LIST:
                    {//스레드에 대한 작업 항목 큐를 관리한다.

                        if (this.listBoxAccessLog.InvokeRequired)
                        {
                            this.listBoxAccessLog.Invoke(new MethodInvoker(delegate { AccessLogList.Add(Message); ListBoxRefresh();;
                            }));
                        }
                        break;
                    }
                case StaticDefine.ADD_CHATTING_LIST:
                    {
                        if (this.listBoxChattingLog.InvokeRequired)
                        {
                            this.listBoxChattingLog.Invoke(new MethodInvoker(delegate {
                                chattingLogList.Add(Message); ListBoxRefresh(); ;
                            }));
                        }
                        break;
                    }
                case StaticDefine.ADD_USER_LIST:
                    {
                        if (this.listBoxUser.InvokeRequired)
                        {
                            this.listBoxUser.Invoke(new MethodInvoker(delegate {
                                userList.Add(Message); ListBoxRefresh(); ;
                            }));
                        }
                        break;
                    }
                case StaticDefine.REMOVE_USER_LIST:
                    {
                        if (this.listBoxUser.InvokeRequired)
                        {
                            this.listBoxUser.Invoke(new MethodInvoker(delegate {
                                userList.Remove(Message); ListBoxRefresh(); ;
                            }));
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        public void MessageParsing(string sender, string message)
        {
            lock (lockObj)
            {
                List<string> msgList = new List<string>();

                string[] msgArray = message.Split('>');
                foreach (var item in msgArray)
                {
                    if (string.IsNullOrEmpty(item))
                        continue;
                    msgList.Add(item);
                }
                SendMsgToClient(msgList, sender);
            }
        }

        private void SendMsgToClient(List<string> msgList, string senderID)//클라이언트에게 받은 메세지에 따라서 응답
        {//sender는 id가 따로
            //receiver는 id가 msg안에 포함
            string parsedMessage = "";
            string receiverID = "";
            string receiverNickName = "";
            string senderNickName = "";
            senderNickName = dbmanager.RunQuery("SELECT USER_nickname FROM s5469698.USER WHERE USER_id=\"" + senderID+"\"");//로그인 시 본인의 이름, ID 저장해둘 수 있음

            int senderNumber = -1;
            int receiverNumber = -1;

            foreach (var item in msgList)
            {
                string[] splitedMsg = item.Split('<');//앞부분 받는사람, 뒷부분 메세지

                receiverID = splitedMsg[0];
                parsedMessage = string.Format("{0}%{1}<{2}>", senderID, senderNickName, splitedMsg[1]);//sendMsg, RoomList용 nickname splited안됐음ㄴ


                    string[] splitSender = receiverID.Split("%");//받는사람 ID랑 닉네임 구분해줌
                    receiverID = splitSender[0];
                receiverNickName = splitSender[1];
                
                senderNumber = GetClinetNumber(senderID);//ID를 고유 번호로 하여 전송 구분에 사용한다.
                receiverNumber = GetClinetNumber(receiverID);
                
                //0.채팅 종료를 요청할 시 클라이언트 리스트에서 sender를 지워준다.
                if (parsedMessage.Contains("<CloseClient>"))
                {
                    Debug.WriteLine("1");
                    ClientManager.clientDic.TryGetValue(senderNumber, out ClientData closingClientData);
                    clientManager.RemoveClient(closingClientData);
                    return;
                }

                if (parsedMessage.Contains("<ChangeProfile>"))
                {
                    Debug.WriteLine("반응");
                    ClientManager.clientDic.TryGetValue(senderNumber, out ClientData closingClientData);
                    clientManager.ChangeProfile(closingClientData);
                    return;
                }

                //0.상대방이 접속 중이 아니라면 table에만 저장해둔다.
                if (senderNumber == -1 || receiverNumber == -1)//유저 현재 접속 중이 아닐 경우의 메세지 보내기/방 생성
                {
                    if(splitedMsg[1]=="ChattingStart")
                    {
                        string isRoom = IsRoom(senderNickName, receiverNickName);
                        
                        parsedMessage = string.Format("{0}%{1}<{2}#ChattingStart>", receiverID, receiverNickName, isRoom);
                        byte[] ByteData = Encoding.Default.GetBytes(parsedMessage);
                        ClientManager.clientDic[senderNumber].tcpClient.GetStream().Write(ByteData, 0, ByteData.Length);
                        return;
                    }

                    dbmanager.RunQuery("insert into Chatting VALUES("+ splitedMsg[1].Split('#')[0]//접속 중이 아니라면 chatting table에 저장
                        + ",\"" + receiverID + "\",\"" + senderID + "\",\"" + splitedMsg[1].Split('#')[1] + "\",\"n\",\"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\")");
                    return;
                }

                byte[] sendByteData = new byte[parsedMessage.Length];
                sendByteData = Encoding.Default.GetBytes(parsedMessage);

                //1.현재 유저 리스트 보내기
                if (parsedMessage.Contains("<GiveMeUserList>"))
                {
                    string userListStringData = "관리자<";
                    foreach (var el in userList)
                    {
                        string elName = dbmanager.RunQuery("SELECT USER_nickname FROM s5469698.USER WHERE ID=\"" + el+"\"");
                        userListStringData += string.Format("${0}%{1}", el, elName);
                    }
                    userListStringData += ">";
                    byte[] userListByteData = new byte[userListStringData.Length];
                    userListByteData = Encoding.Default.GetBytes(userListStringData);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(userListByteData, 0, userListByteData.Length);
                    return;
                }
                //2.존재 전체 유저 리스트 보내기->트리로 어떻게 되나?
                if (parsedMessage.Contains("<GiveMeAllUserList>"))
                {
                    string userListStringData = "모든유저<";
                    
                    string[] AllNickName = dbmanager.RunQueryArray("SELECT USER_nickname FROM s5469698.USER ");// 닉네임 모두 불러옴 일단베열.
                    string[] AllID = dbmanager.RunQueryArray("SELECT USER_ID FROM s5469698.USER ");// 닉네임 모두 불러옴 일단베열.

                    for (int i = 0; i < AllID.Length; i++)
                    {
                        userListStringData += string.Format("${0}%{1}", AllID[i], AllNickName[i]);//형태맞춰서
                    }

                    userListStringData += ">";
                    byte[] userListByteData = new byte[userListStringData.Length];
                    userListByteData = Encoding.Default.GetBytes(userListStringData);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(userListByteData, 0, userListByteData.Length);
                    return;
                }
                //3.내가 속한 방 리스트 보내기
                if (parsedMessage.Contains("<GiveMeRoomList>"))
                {
                    string userListStringData = "채팅방<";
                    List<string> RoomList = new List<string>();

                    RoomList.AddRange(dbmanager.RunQueryArray("select user1 from Room where user2=\""+senderNickName+"\" GROUP BY idRoom;"));//찾는 유저가 user2에 있든 user1에 있든 찾을 수 있도록
                    RoomList.AddRange(dbmanager.RunQueryArray("select user2 from Room where user1=\""+ senderNickName + "\" GROUP BY idRoom;"));

                    foreach (var itemRoom in RoomList)
                    {
                        userListStringData += string.Format("${0}", itemRoom);//형태맞춰서
                    }

                    userListStringData += ">";
                    byte[] userListByteData = new byte[userListStringData.Length];
                    userListByteData = Encoding.Default.GetBytes(userListStringData);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(userListByteData, 0, userListByteData.Length);
                    return;
                }

                //4.채팅 시작하기->기존 채팅방 유무 확인
                if (parsedMessage.Contains("<ChattingStart>"))
                {//기존 채팅방이 있는지->sender, receiver userID로 query 검색
                    string isRoom = IsRoom(senderNickName, receiverNickName);
                    
                    parsedMessage = string.Format("{0}%{1}<{2}#ChattingStart>", receiverID, receiverNickName, isRoom);//실시간 채팅 시작 부분
                    sendByteData = Encoding.Default.GetBytes(parsedMessage);
                    ClientManager.clientDic[senderNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);

                    parsedMessage = string.Format("{0}%{1}<{2}#ChattingStart>", senderID, senderNickName, isRoom);
                    sendByteData = Encoding.Default.GetBytes(parsedMessage);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);
                    return;
                }
                

                //5.메세지 보내기
                if (parsedMessage.Contains(""))
                {
                    roomID = splitedMsg[1].Split('#')[0];
                    splitedMsg[1] = splitedMsg[1].Split('#')[1];
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);//채팅 때마다 테이블에 추가. 아직 room 없음
                    //실시간 채팅 상태이므로 읽음 상태 y
                    dbmanager.RunQuery("insert into Chatting VALUES("+ int.Parse(roomID) + ",\"" + receiverID + "\",\"" + senderID + "\",\"" + splitedMsg[1] + "\",\"y\",\""+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\")");
                }
            }
        }

        private int GetClinetNumber(string targetClientName)//올바른 ClientData를 통해 ClientNumber를 찾는 과정
        {
            foreach (var item in ClientManager.clientDic)
            {
                if (item.Value.clientID == targetClientName)
                {
                    return item.Value.clientNumber;
                }
            }
            return -1;
        }
        private string IsRoom(string senderNickName,string receiverNickName)//채팅방 있는지 확인해주고 있으면 룸아이디 반환
        {
            string isRoom = dbmanager.RunQuery("SELECT distinct idRoom\r\nFROM Room\r\nWHERE " +
                        "(Room.USER1 = \"" + receiverNickName + "\" AND Room.USER2=\"" + senderNickName + "\") OR" +
                        " (Room.USER1 =\"" + senderNickName + "\" AND Room.USER2 = \"" + receiverNickName + "\");\r\n");
            return isRoom;
        } 

        private void MainServerStart()
        {
            MainServer a = new MainServer();
        }
    }
}