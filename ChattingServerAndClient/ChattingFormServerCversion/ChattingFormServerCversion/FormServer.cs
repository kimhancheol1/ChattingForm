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

        Task? conntectCheckThread = null;//������ üũ�ϴ� ������
        string roomID = null;

        DBManager dbmanager = DBManager.GetInstance();

        public FormServer()
        {
            
            InitializeComponent();
            string debugCheck = "������ �׽�Ʈ������ ����Ͻ÷��� ��, ���� ä�����α׷� ����Ϸ��� �ƴϿ��� �����ּ���";
            DialogResult nameMessageBoxResult = MessageBox.Show(debugCheck, "Question", MessageBoxButtons.YesNo);
            if (nameMessageBoxResult == DialogResult.Yes)
            {
                ClientData.isdebug = true;
            }
            else
            {
                ClientData.isdebug = false;
            }
            MainServerStart();//�ٸ� �����忡�� ���� ������ Ŭ���̾�Ʈ msg�� listen
            ClientManager.messageParsingAction += MessageParsing;//�̺�Ʈ �߰�
            ClientManager.ChangeListBoxAction += ChangeListBox;


            listBoxChattingLog.DataSource = chattingLogList;//����Ʈ�� ����Ʈ �ڽ��� ���ε�
            listBoxAccessLog.DataSource = AccessLogList;
            listBoxUser.DataSource = userList;



            conntectCheckThread = new Task(ConnectCheckLoop);//���� üũ ������ 
            conntectCheckThread.Start(); //����


        }
        public FormServer(string str)
        {

        }
        private void FormServer_Load(object sender, EventArgs e)
        {
            
        }
        private void ListBoxRefresh()
        {
            listBoxChattingLog.DataSource = null;//����Ʈ�� ����Ʈ �ڽ��� ���ε�
            listBoxAccessLog.DataSource = null;
            listBoxUser.DataSource = null;

            listBoxChattingLog.DataSource = chattingLogList;//����Ʈ�� ����Ʈ �ڽ��� ���ε�
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
                        string sendStringData = "������<TEST>";
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
                    {//�����忡 ���� �۾� �׸� ť�� �����Ѵ�.

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

        private void SendMsgToClient(List<string> msgList, string senderID)//Ŭ���̾�Ʈ���� ���� �޼����� ���� ����
        {//sender�� id�� ����
            //receiver�� id�� msg�ȿ� ����
            string parsedMessage = "";
            string receiverID = "";
            string receiverNickName = "";
            string senderNickName = "";
            senderNickName = dbmanager.RunQuery("SELECT USER_nickname FROM s5469698.USER WHERE USER_id=\"" + senderID+"\"");//�α��� �� ������ �̸�, ID �����ص� �� ����

            int senderNumber = -1;
            int receiverNumber = -1;

            foreach (var item in msgList)
            {
                string[] splitedMsg = item.Split('<');//�պκ� �޴»��, �޺κ� �޼���

                receiverID = splitedMsg[0];
                parsedMessage = string.Format("{0}%{1}<{2}>", senderID, senderNickName, splitedMsg[1]);//sendMsg, RoomList�� nickname splited�ȵ�����


                    string[] splitSender = receiverID.Split("%");//�޴»�� ID�� �г��� ��������
                    receiverID = splitSender[0];
                receiverNickName = splitSender[1];
                
                senderNumber = GetClinetNumber(senderID);//ID�� ���� ��ȣ�� �Ͽ� ���� ���п� ����Ѵ�.
                receiverNumber = GetClinetNumber(receiverID);
                
                //0.ä�� ���Ḧ ��û�� �� Ŭ���̾�Ʈ ����Ʈ���� sender�� �����ش�.
                if (parsedMessage.Contains("<CloseClient>"))
                {
                    Debug.WriteLine("1");
                    ClientManager.clientDic.TryGetValue(senderNumber, out ClientData closingClientData);
                    clientManager.RemoveClient(closingClientData);
                    return;
                }

                if (parsedMessage.Contains("<ChangeProfile>"))
                {
                    Debug.WriteLine("����");
                    ClientManager.clientDic.TryGetValue(senderNumber, out ClientData closingClientData);
                    clientManager.ChangeProfile(closingClientData);
                    return;
                }

                //0.������ ���� ���� �ƴ϶�� table���� �����صд�.
                if (senderNumber == -1 || receiverNumber == -1)//���� ���� ���� ���� �ƴ� ����� �޼��� ������/�� ����
                {
                    if(splitedMsg[1]=="ChattingStart")
                    {
                        string isRoom = IsRoom(senderNickName, receiverNickName);
                        
                        parsedMessage = string.Format("{0}%{1}<{2}#ChattingStart>", receiverID, receiverNickName, isRoom);
                        byte[] ByteData = Encoding.Default.GetBytes(parsedMessage);
                        ClientManager.clientDic[senderNumber].tcpClient.GetStream().Write(ByteData, 0, ByteData.Length);
                        return;
                    }

                    dbmanager.RunQuery("insert into Chatting VALUES("+ splitedMsg[1].Split('#')[0]//���� ���� �ƴ϶�� chatting table�� ����
                        + ",\"" + receiverID + "\",\"" + senderID + "\",\"" + splitedMsg[1].Split('#')[1] + "\",\"n\",\"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\")");
                    return;
                }

                byte[] sendByteData = new byte[parsedMessage.Length];
                sendByteData = Encoding.Default.GetBytes(parsedMessage);

                //1.���� ���� ����Ʈ ������
                if (parsedMessage.Contains("<GiveMeUserList>"))
                {
                    string userListStringData = "������<";
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
                //2.���� ��ü ���� ����Ʈ ������->Ʈ���� ��� �ǳ�?
                if (parsedMessage.Contains("<GiveMeAllUserList>"))
                {
                    string userListStringData = "�������<";
                    
                    string[] AllNickName = dbmanager.RunQueryArray("SELECT USER_nickname FROM s5469698.USER ");// �г��� ��� �ҷ��� �ϴܺ���.
                    string[] AllID = dbmanager.RunQueryArray("SELECT USER_ID FROM s5469698.USER ");// �г��� ��� �ҷ��� �ϴܺ���.

                    for (int i = 0; i < AllID.Length; i++)
                    {
                        userListStringData += string.Format("${0}%{1}", AllID[i], AllNickName[i]);//���¸��缭
                    }

                    userListStringData += ">";
                    byte[] userListByteData = new byte[userListStringData.Length];
                    userListByteData = Encoding.Default.GetBytes(userListStringData);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(userListByteData, 0, userListByteData.Length);
                    return;
                }
                //3.���� ���� �� ����Ʈ ������
                if (parsedMessage.Contains("<GiveMeRoomList>"))
                {
                    string userListStringData = "ä�ù�<";
                    List<string> RoomList = new List<string>();

                    RoomList.AddRange(dbmanager.RunQueryArray("select user1 from Room where user2=\""+senderNickName+"\" GROUP BY idRoom;"));//ã�� ������ user2�� �ֵ� user1�� �ֵ� ã�� �� �ֵ���
                    RoomList.AddRange(dbmanager.RunQueryArray("select user2 from Room where user1=\""+ senderNickName + "\" GROUP BY idRoom;"));

                    foreach (var itemRoom in RoomList)
                    {
                        userListStringData += string.Format("${0}", itemRoom);//���¸��缭
                    }

                    userListStringData += ">";
                    byte[] userListByteData = new byte[userListStringData.Length];
                    userListByteData = Encoding.Default.GetBytes(userListStringData);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(userListByteData, 0, userListByteData.Length);
                    return;
                }

                //4.ä�� �����ϱ�->���� ä�ù� ���� Ȯ��
                if (parsedMessage.Contains("<ChattingStart>"))
                {//���� ä�ù��� �ִ���->sender, receiver userID�� query �˻�
                    string isRoom = IsRoom(senderNickName, receiverNickName);
                    
                    parsedMessage = string.Format("{0}%{1}<{2}#ChattingStart>", receiverID, receiverNickName, isRoom);//�ǽð� ä�� ���� �κ�
                    sendByteData = Encoding.Default.GetBytes(parsedMessage);
                    ClientManager.clientDic[senderNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);

                    parsedMessage = string.Format("{0}%{1}<{2}#ChattingStart>", senderID, senderNickName, isRoom);
                    sendByteData = Encoding.Default.GetBytes(parsedMessage);
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);
                    return;
                }
                

                //5.�޼��� ������
                if (parsedMessage.Contains(""))
                {
                    roomID = splitedMsg[1].Split('#')[0];
                    splitedMsg[1] = splitedMsg[1].Split('#')[1];
                    ClientManager.clientDic[receiverNumber].tcpClient.GetStream().Write(sendByteData, 0, sendByteData.Length);//ä�� ������ ���̺� �߰�. ���� room ����
                    //�ǽð� ä�� �����̹Ƿ� ���� ���� y
                    dbmanager.RunQuery("insert into Chatting VALUES("+ int.Parse(roomID) + ",\"" + receiverID + "\",\"" + senderID + "\",\"" + splitedMsg[1] + "\",\"y\",\""+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\")");
                }
            }
        }

        private int GetClinetNumber(string targetClientName)//�ùٸ� ClientData�� ���� ClientNumber�� ã�� ����
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
        private string IsRoom(string senderNickName,string receiverNickName)//ä�ù� �ִ��� Ȯ�����ְ� ������ ����̵� ��ȯ
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