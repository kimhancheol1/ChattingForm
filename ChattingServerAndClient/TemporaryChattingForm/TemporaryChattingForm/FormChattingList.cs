using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemporaryChattingForm
{

    public partial class FormChattingList : Form
    {
        public static string myID = null;
        TcpClient client = null;
        Thread ReceiveThread = null;
        ChattingForm chattingWindow = null;
        Dictionary<string, ChattingThreadData> chattingThreadDic = new Dictionary<string, ChattingThreadData>();

        private static ObservableCollection<User> currentUserList = new ObservableCollection<User>();
        private static ObservableCollection<string> currentRoomList = new ObservableCollection<string>();
        public string RoomMemeber;

        private List<string> ChattingUserList = new List<string>();
        private string oneOnOneReceiverID { get; set; }
        public string OneOnOneReceiverID
        {
            get
            {
                return oneOnOneReceiverID;
            }
            private set
            {
                oneOnOneReceiverID = value;
            }

        }
        private string oneOnOneReceiverName { get; set; }
        public string OneOnOneReceiverName
        {
            get
            {
                return oneOnOneReceiverName;
            }
            private set
            {
                oneOnOneReceiverName = value;
            }

        }
        public FormChattingList()
        {
            InitializeComponent();
            textBoxMyID.Text = "1";//로그인할때 정보를 받아올 것
            //로그인할 때 쓰는 User_id 말고 int형인 ID여야 합니다.->추후 clientNumber로 사용
            textBoxIPAddress.Text = "127.0.0.1";
            listBoxMember.DataSource = currentUserList;
            listBoxRoom.DataSource = currentRoomList;

            Login();
        }
        private void FormChattingList_Load(object sender, EventArgs e)
        {
            string getUserProtocol = myID + "%" + myID + "<GiveMeUserList>";//서버에 보내기 위해 myID사용
            byte[] byteData = new byte[getUserProtocol.Length];
            byteData = Encoding.Default.GetBytes(getUserProtocol);

            client.GetStream().Write(byteData, 0, byteData.Length);


            string getRoomProtocol = myID + "%" + myID + "<GiveMeRoomList>";//서버에 보내기 위해 myID사용
            byteData = new byte[getRoomProtocol.Length];
            byteData = Encoding.Default.GetBytes(getRoomProtocol);

            client.GetStream().Write(byteData, 0, byteData.Length);
        }
        private void Login()
        {
            try
            {
                string ip = textBoxIPAddress.Text;
                string parsedID = "%^&";
                parsedID += textBoxMyID.Text;
                client = new TcpClient();
                client.Connect(ip, 9999);//직접 설정한 ip로 연결

                byte[] byteData = new byte[parsedID.Length];
                byteData = UTF8Encoding.UTF8.GetBytes(parsedID);//Name추가해서 보내기
                client.GetStream().Write(byteData, 0, byteData.Length);

                Info.Text = string.Format("{0} 님 반갑습니다 ", textBoxMyID.Text);
                myID = textBoxMyID.Text;

                ReceiveThread = new Thread(RecieveMessage);
                ReceiveThread.Start();
            }

            catch
            {
                MessageBox.Show("서버연결에 실패하였습니다.", "Server Error");
                client = null;
            }
        }
        private void RecieveMessage()
        {
            string receiveMessage = "";
            List<string> receiveMessageList = new List<string>();
            while (true)
            {
                try
                {
                    byte[] receiveByte = new byte[1024];
                    client.GetStream().Read(receiveByte, 0, receiveByte.Length);


                    receiveMessage = UTF8Encoding.UTF8.GetString(receiveByte);

                    string[] receiveMessageArray = receiveMessage.Split('>');
                    foreach (var item in receiveMessageArray)
                    {
                        if (!item.Contains('<'))
                            continue;
                        if (item.Contains("관리자<TEST"))
                            continue;

                        receiveMessageList.Add(item);
                    }

                    ParsingReceiveMessage(receiveMessageList);
                }
                catch (Exception e)
                {
                    MessageBox.Show("서버와의 연결이 끊어졌습니다.", "Server Error");
                    MessageBox.Show(e.Message);
                    MessageBox.Show(e.StackTrace);
                    Environment.Exit(1);
                }
                Thread.Sleep(500);
            }
        }

        private void ParsingReceiveMessage(List<string> messageList)
        {
            foreach (var item in messageList)
            {
                string chattingPartner = "";
                string message = "";

                if (item.Contains('<'))
                {
                    string[] splitedMsg = item.Split('<');

                    chattingPartner = splitedMsg[0];
                    message = splitedMsg[1];

                    // 하트비트 
                    if (chattingPartner == "관리자")
                    {
                        ObservableCollection<User> tempUserList = new ObservableCollection<User>();
                        string[] splitedUser = message.Split('$');
                        foreach (var el in splitedUser)
                        {
                            if (string.IsNullOrEmpty(el))
                                continue;
                            string[] IDSplitedUser = el.Split('%');
                            tempUserList.Add(new User(IDSplitedUser[1], IDSplitedUser[0]));//새로운 유저 들어오면 Add
                        }
                        currentUserList.Clear();

                        //유저 리스트에 받아온 유저 리스트 추가
                        if (this.listBoxMember.InvokeRequired)
                        {
                            this.listBoxMember.Invoke(new MethodInvoker(delegate
                            {
                                foreach (var item1 in tempUserList)
                                {
                                    currentUserList.Add(item1); RefreshListBoxMember();

                                }
                            }));
                        }
                        messageList.Clear();
                        return;
                    }
                    if (chattingPartner == "채팅방")
                    {
                        ObservableCollection<string> tempRoomList = new ObservableCollection<string>();
                        string[] splitedRoom = message.Split('$');
                        foreach (var el in splitedRoom)
                        {
                            if (string.IsNullOrEmpty(el))
                                continue;
                            tempRoomList.Add(el);//새로운 유저 들어오면 Add
                        }
                        currentRoomList.Clear();
                        if (this.listBoxMember.InvokeRequired)
                        {
                            this.listBoxRoom.Invoke(new MethodInvoker(delegate
                            {
                                foreach (var item1 in tempRoomList)
                                {
                                    currentRoomList.Add(item1); RefreshListBoxRoom();

                                }
                            }));
                        }
                        messageList.Clear();
                        return;
                    }

                    // 1:1채팅

                    if (!chattingThreadDic.ContainsKey(chattingPartner))
                    {
                        string RoomID = message.Split('#')[0];
                        if (message.Split('#')[1] == "ChattingStart")//채팅 시작 요청
                        {
                            Thread chattingThread = new Thread(() => ThreadStartingPoint(chattingPartner, RoomID));//chattingPartner. 서버에서 userID랑 Name 모두 보내줄 것 
                            chattingThread.SetApartmentState(ApartmentState.STA);
                            chattingThread.IsBackground = true;
                            chattingThread.Start();
                        }
                    }
                    else
                    {
                        if (chattingThreadDic[chattingPartner].chattingThread.IsAlive)
                        {
                            chattingThreadDic[chattingPartner].chattingWindow.ReceiveMessage(chattingPartner, message);
                        }
                    }
                    messageList.Clear();
                    return;

                }
            }
            messageList.Clear();
        }
        private void RefreshListBoxMember()
        {
            listBoxMember.DataSource = null;
            listBoxMember.DataSource = currentUserList;
            listBoxMember.DisplayMember = "userName";
        }
        private void RefreshListBoxRoom()
        {
            listBoxRoom.DataSource = null;
            listBoxRoom.DataSource = currentRoomList;
        }
        private void ThreadStartingPoint(string chattingPartner, string RoomID)
        {
            chattingWindow = new ChattingForm(client, chattingPartner, RoomID);
            chattingThreadDic.Add(chattingPartner, new ChattingThreadData(Thread.CurrentThread, chattingWindow));

            chattingWindow.ShowDialog();
            MessageBox.Show("채팅이 종료되었습니다.", "Information");
            chattingThreadDic.Remove(chattingPartner);

        }

        private void listBoxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<User> dummyChattingUser = listBoxMember.Items.Cast<User>().ToList();

            User selectedUser = (User)listBoxMember.SelectedItem;
            if (FormChattingList.myID == selectedUser.userName)
            {
                MessageBox.Show("자기 자신과는 채팅할 수 없습니다.", "Information");
                return;
            }

            this.OneOnOneReceiverID = selectedUser.userID;        //받는 사람 결정
            this.OneOnOneReceiverName = selectedUser.userName;
        }

        private void buttonChattingStart_Click(object sender, EventArgs e)
        {
            if (listBoxMember.SelectedItem == null)
            {
                MessageBox.Show("채팅상대를 선택해주세요.", "Information");
                return;
            }

            List<User> dummyChattingUser = listBoxMember.SelectedItems.Cast<User>().ToList();

            User selectedUser = (User)listBoxMember.SelectedItem;

            if (myID == selectedUser.userID)//내 아이디와 선택한 유저의 아이디 비교
            {
                MessageBox.Show("자기 자신과는 채팅할 수 없습니다.", "Information");
                return;
            }
           
            this.OneOnOneReceiverID = selectedUser.userID;//채팅 상대 결정됨 userName->userID로 바꿈
            this.OneOnOneReceiverName = selectedUser.userName;
            Chatting_Start();
        }
        private void Chatting_Start()
        {

            string chattingStartMessage = string.Format("{0}%{1}<ChattingStart>", OneOnOneReceiverID, OneOnOneReceiverName);//UserID, UserName으로 ChattingStart작성
            byte[] chattingStartByte = UTF8Encoding.UTF8.GetBytes(chattingStartMessage);
            client.GetStream().Write(chattingStartByte, 0, chattingStartByte.Length);//서버에 보내는 부분

        }

        private void FormChattingList_FormClosing(object sender, FormClosingEventArgs e)
        {
            string ClosingMsg = string.Format("{0}%{1}<CloseClient>", textBoxMyID.Text, textBoxMyID.Text);//UserID, UserName으로 ChattingStart작성
            byte[] ClosingMsgByte = UTF8Encoding.UTF8.GetBytes(ClosingMsg);
            client.GetStream().Write(ClosingMsgByte, 0, ClosingMsgByte.Length);//서버에 보내는 부분
        }
    }
}
