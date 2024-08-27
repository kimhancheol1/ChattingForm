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
    public partial class ChattingForm : Form
    {
        private string chattingPartner = null;
        private TcpClient client = null;
        private string chattingRoomID = "";
        private ObservableCollection<string> messageList = new ObservableCollection<string>();

        public ChattingForm(TcpClient client, string chattingPartner, string RoomID)
        {
            string[] SplitedSender = chattingPartner.Split('%');
            chattingRoomID = RoomID;
            string chattingPartnerName = SplitedSender[1];

            this.chattingPartner = chattingPartner;//채팅하는 상대방의 이름
            this.client = client;
            InitializeComponent();

            listBoxHistory.Items.Add(messageList.ToString());
            messageList.Add(string.Format("{0}님이 입장하였습니다.", chattingPartnerName));
            this.Text = chattingPartnerName + "님과의 채팅방";
        }

        private void ChattingForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSend.Text))
                return;
            string message = textBoxSend.Text;
            string parsedMessage = "";

            if (message.Contains('<') || message.Contains('>'))
            {
                MessageBox.Show("죄송합니다. >,< 기호는 사용하실수 없습니다.", "Information");
                return;
            }

            if (chattingPartner != null)
            {
                parsedMessage = string.Format("{0}<{1}#{2}>", chattingPartner, chattingRoomID, message);

                byte[] byteData = UTF8Encoding.UTF8.GetBytes(parsedMessage);
                client.GetStream().Write(byteData, 0, byteData.Length);
            }
            messageList.Add("나: " + message);
            textBoxSend.Clear();
            RefreshListBox();
        }

        

        private void ChattingForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBoxSend.Text))
                    return;
                string message = textBoxSend.Text;
                string parsedMessage = "";

                if (message.Contains('<') || message.Contains('>'))
                {
                    System.Windows.Forms.MessageBox.Show("죄송합니다. >,< 기호는 사용하실수 없습니다.", "Information");
                    return;
                }

                if (chattingPartner != null)
                {
                    parsedMessage = string.Format("{0}<{1}#{2}>", chattingPartner, chattingRoomID, message);
                    byte[] byteData = UTF8Encoding.UTF8.GetBytes(parsedMessage);
                    client.GetStream().Write(byteData, 0, byteData.Length);
                }


                messageList.Add("나: " + message);
                textBoxSend.Clear();
                RefreshListBox();
            }
        }
        public void ReceiveMessage(string sender, string message)
        {
            string[] SplitedSender = sender.Split('%');

            sender = SplitedSender[1];

            if (message == "ChattingStart")
            {
                return;
            }

            if (message == "상대방이 채팅방을 나갔습니다.")
            {
                string parsedMessage = string.Format("{0}님이 채팅방을 나갔습니다.", sender);
                messageList.Add(parsedMessage);


                return;
            }
            message = message.Split('#')[1];

            //리스트박스에 잘 띄워보자...
            if (this.listBoxHistory.InvokeRequired)
            {
                this.listBoxHistory.Invoke(new MethodInvoker(delegate {
                    messageList.Add(string.Format("{0}: {1}", sender, message)); RefreshListBox(); ;
                }));
            }

        }
        private void RefreshListBox()
        {
            listBoxHistory.DataSource = null;
            listBoxHistory.DataSource = messageList;
        }
        private void ChattingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] SplitedSender = chattingPartner.Split('%');
            string chattingPartnerName = SplitedSender[1];

            string message = string.Format("{0}님과의 채팅을 종료합니다.", chattingPartnerName);
            MessageBox.Show(message);
        }
    }
}
