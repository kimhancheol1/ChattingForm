using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace DBP_관리
{
    public partial class Form_Resist : Form
    {
        // 아이디 중복체크
        private bool isID = false;
        // 비밀번호 체크
        private bool isPass = false;
        public string ReceivedData;
        private string txt_address;

        public Form_Resist()
        {
            InitializeComponent();
        }

        // 로그인을 되돌아가기
        private void BackLogin(object sender, EventArgs e)
        {
            Owner.Location = this.Location;
            Owner.Show();
            this.Close();
        }

        // 회원가입 버튼
        private void Btn_ResistON(object sender, EventArgs e)
        {
            if (!isID)
            {
                MessageBox.Show("아이디 중복 체크를 다시 해주세요");
                return;
            }

            if (!isPass)
            {
                MessageBox.Show("비밀번호를 다시 확인해주세요");
                return;
            }
            if (LoginManager._Regist.Resist(txt_Profile.Text, txt_Name.Text, txt_Nickname.Text, txt_Id.Text, txt_Password.Text, txt_zipCode.Text, txt_landlordAddress.Text, txt_roadAddress.Text, combo_Department.Text, combo_team.Text, dateTimePicker1.Text))
                BackLogin(sender, e);
            else
                return;
        }


        private void CheckID(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Id.Text))
            {
                MessageBox.Show("아이디를 입력하세요");
                return;
            }
            else
            {
                isID = LoginManager._Regist.CheckID(txt_Id.Text, "USER_id", isID);
            }
        }

        private void CheckPassword(object sender, CancelEventArgs e)
        {
            if (txt_Password.Text.Equals(txt_ConfirmPass.Text))
            {
                label_verify.ForeColor = Color.LightGreen;
                label_verify.Text = "비밀번호가\n일치합니다";
                isPass = true;
            }
            else
            {
                label_verify.ForeColor = Color.Red;
                label_verify.Text = "비밀번호가\n일치하지 않습니다";
                isPass = false;
            }
        }

        // 이미지 넣기 기능
        private void LoadImage(object sender, EventArgs e)
        {
            // 파일 열기 확장자 필터링 - 사진만 넣을 수 있게 함. All 추가 시 All Files(*.*)|*.*
            LoginManager.Instance.SetImage(this.openFileDialog, this.txt_Profile, this.profileBox);
        }

        private void combo_Department_Enter(object sender, EventArgs e)
        {
            LoginManager._Regist.LoadComboBoxColumnData(combo_Department, combo_team, "dpt_name", "department", OutputSort.Department);
        }

        private void Load_TeamData(object sender, EventArgs e)
        {
            LoginManager._Regist.LoadComboBoxColumnData(combo_Department, combo_team, "team_name", "team", OutputSort.Team);
        }

        private void btn_searchAddress_Click(object sender, EventArgs e)
        {
            Point tempPoint = this.Location;
            Form_Address address = new Form_Address();
            address.Location = tempPoint;
            address.sendEvent += new DataGetEventHandler(this.DataGet);

            address.ShowDialog();

        }

        private void DataGet(string data)
        {
            string datas = data;
            var ad = datas.Split('\n');

            txt_zipCode.Text = ad[0];
            txt_roadAddress.Text = ad[1];
            txt_landlordAddress.Text = ad[2];
        }
        private void Form_Exit_Control(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

    }
}
