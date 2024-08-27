namespace DBP_관리
{
    partial class Form_ChangeProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.txt_password = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_nickname = new System.Windows.Forms.TextBox();
			this.txt_zipCode = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txt_landlordAddress = new System.Windows.Forms.TextBox();
			this.txt_roadAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_OK = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(86, 142);
			this.txt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_password.Name = "txt_password";
			this.txt_password.PasswordChar = '*';
			this.txt_password.Size = new System.Drawing.Size(117, 23);
			this.txt_password.TabIndex = 0;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(86, 193);
			this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(117, 23);
			this.txt_name.TabIndex = 1;
			// 
			// txt_nickname
			// 
			this.txt_nickname.Location = new System.Drawing.Point(86, 238);
			this.txt_nickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_nickname.Multiline = true;
			this.txt_nickname.Name = "txt_nickname";
			this.txt_nickname.Size = new System.Drawing.Size(117, 21);
			this.txt_nickname.TabIndex = 2;
			this.txt_nickname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// txt_zipCode
			// 
			this.txt_zipCode.Enabled = false;
			this.txt_zipCode.Location = new System.Drawing.Point(86, 285);
			this.txt_zipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_zipCode.Name = "txt_zipCode";
			this.txt_zipCode.Size = new System.Drawing.Size(117, 23);
			this.txt_zipCode.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(86, 11);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(116, 100);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(220, 87);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(69, 25);
			this.button1.TabIndex = 5;
			this.button1.Text = "파일 열기";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(220, 283);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 25);
			this.button2.TabIndex = 6;
			this.button2.Text = "우편 검색";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btn_address_click);
			// 
			// txt_landlordAddress
			// 
			this.txt_landlordAddress.Enabled = false;
			this.txt_landlordAddress.Location = new System.Drawing.Point(86, 334);
			this.txt_landlordAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_landlordAddress.Name = "txt_landlordAddress";
			this.txt_landlordAddress.Size = new System.Drawing.Size(117, 23);
			this.txt_landlordAddress.TabIndex = 7;
			// 
			// txt_roadAddress
			// 
			this.txt_roadAddress.Enabled = false;
			this.txt_roadAddress.Location = new System.Drawing.Point(86, 310);
			this.txt_roadAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt_roadAddress.Name = "txt_roadAddress";
			this.txt_roadAddress.Size = new System.Drawing.Size(117, 23);
			this.txt_roadAddress.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(27, 144);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 15);
			this.label7.TabIndex = 9;
			this.label7.Text = "비밀번호";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(27, 195);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "이름";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(27, 240);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 15);
			this.label2.TabIndex = 11;
			this.label2.Text = "닉네임";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(27, 287);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "주소";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(27, 92);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "프로필";
			// 
			// btn_OK
			// 
			this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_OK.Location = new System.Drawing.Point(86, 382);
			this.btn_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(116, 28);
			this.btn_OK.TabIndex = 14;
			this.btn_OK.Text = "변경";
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form_ChangeProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(306, 420);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_roadAddress);
			this.Controls.Add(this.txt_landlordAddress);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_zipCode);
			this.Controls.Add(this.txt_nickname);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.txt_password);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form_ChangeProfile";
			this.Text = "Form_ChangeProfile";
			this.Load += new System.EventHandler(this.Form_ChangeProfile_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TextBox txt_password;
        private TextBox txt_name;
        private TextBox txt_nickname;
        private TextBox txt_zipCode;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox txt_landlordAddress;
        private TextBox txt_roadAddress;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_OK;
        private OpenFileDialog openFileDialog1;
    }
}