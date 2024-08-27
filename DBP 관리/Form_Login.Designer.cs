namespace DBP_관리
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btn_Login = new System.Windows.Forms.Button();
			this.txt_Login = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.autoLoginCheck = new System.Windows.Forms.CheckBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.autoInputCheck = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label_AdminLogin = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Login
			// 
			this.btn_Login.BackColor = System.Drawing.Color.White;
			this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Login.FlatAppearance.BorderSize = 0;
			this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Login.Location = new System.Drawing.Point(97, 407);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(255, 49);
			this.btn_Login.TabIndex = 7;
			this.btn_Login.Text = "로그인";
			this.btn_Login.UseVisualStyleBackColor = false;
			this.btn_Login.Click += new System.EventHandler(this.Login_Click);
			// 
			// txt_Login
			// 
			this.txt_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Login.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_Login.Location = new System.Drawing.Point(96, 250);
			this.txt_Login.Name = "txt_Login";
			this.txt_Login.Size = new System.Drawing.Size(255, 34);
			this.txt_Login.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(36, 260);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "아이디";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(21, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "비밀번호";
			// 
			// autoLoginCheck
			// 
			this.autoLoginCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.autoLoginCheck.AutoSize = true;
			this.autoLoginCheck.ForeColor = System.Drawing.Color.White;
			this.autoLoginCheck.Location = new System.Drawing.Point(97, 366);
			this.autoLoginCheck.Name = "autoLoginCheck";
			this.autoLoginCheck.Size = new System.Drawing.Size(111, 24);
			this.autoLoginCheck.TabIndex = 5;
			this.autoLoginCheck.Text = "자동 로그인";
			this.autoLoginCheck.UseVisualStyleBackColor = true;
			// 
			// txt_Password
			// 
			this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Password.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_Password.Location = new System.Drawing.Point(96, 310);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.PasswordChar = '*';
			this.txt_Password.Size = new System.Drawing.Size(255, 34);
			this.txt_Password.TabIndex = 4;
			this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DBP_관리.Properties.Resources.Image;
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.Location = new System.Drawing.Point(129, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(180, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// autoInputCheck
			// 
			this.autoInputCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.autoInputCheck.AutoSize = true;
			this.autoInputCheck.ForeColor = System.Drawing.Color.White;
			this.autoInputCheck.Location = new System.Drawing.Point(214, 366);
			this.autoInputCheck.Name = "autoInputCheck";
			this.autoInputCheck.Size = new System.Drawing.Size(150, 24);
			this.autoInputCheck.TabIndex = 9;
			this.autoInputCheck.Text = "ID / PW 자동입력";
			this.autoInputCheck.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(115, 488);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "회원가입";
			this.label3.Click += new System.EventHandler(this.ResistIn_Click);
			// 
			// label_AdminLogin
			// 
			this.label_AdminLogin.AutoSize = true;
			this.label_AdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label_AdminLogin.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label_AdminLogin.ForeColor = System.Drawing.Color.White;
			this.label_AdminLogin.Location = new System.Drawing.Point(214, 488);
			this.label_AdminLogin.Name = "label_AdminLogin";
			this.label_AdminLogin.Size = new System.Drawing.Size(118, 23);
			this.label_AdminLogin.TabIndex = 11;
			this.label_AdminLogin.Text = "관리자 로그인";
			this.label_AdminLogin.Click += new System.EventHandler(this.GoAdminLogin);
			// 
			// Form_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(436, 553);
			this.Controls.Add(this.label_AdminLogin);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.autoInputCheck);
			this.Controls.Add(this.txt_Login);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.autoLoginCheck);
			this.Name = "Form_Login";
			this.Text = "Comtalk Messenger";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Login_FormClosed);
			this.Load += new System.EventHandler(this.Form_Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Button btn_Login;
        private TextBox txt_Login;
        private Label label1;
        private Label label2;
        private CheckBox autoLoginCheck;
        private TextBox txt_Password;
        private PictureBox pictureBox1;
        private CheckBox autoInputCheck;
        private Label label3;
        private Label label_AdminLogin;
    }
}
