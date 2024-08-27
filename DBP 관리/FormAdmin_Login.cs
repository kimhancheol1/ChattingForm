using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_관리
{
    public partial class FormAdmin_Login : Form
    {
        public FormAdmin_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form_Login frm = new Form_Login();
            frm.Show();
            this.Close();
        }

        public void LOGIN(string str1, string str2)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginManager._Login.OnLogin(textBox1.Text, textBox2.Text, this);
        }

        private void FormAdmin_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
