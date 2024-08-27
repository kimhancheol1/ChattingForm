namespace TemporaryChattingForm
{
    partial class FormChattingList
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
            this.Info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMyID = new System.Windows.Forms.TextBox();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.listBoxMember = new System.Windows.Forms.ListBox();
            this.listBoxRoom = new System.Windows.Forms.ListBox();
            this.buttonChattingStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(35, 9);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(50, 20);
            this.Info.TabIndex = 0;
            this.Info.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "대화 상대";
            // 
            // textBoxMyID
            // 
            this.textBoxMyID.Location = new System.Drawing.Point(208, 22);
            this.textBoxMyID.Name = "textBoxMyID";
            this.textBoxMyID.Size = new System.Drawing.Size(125, 27);
            this.textBoxMyID.TabIndex = 2;
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(208, 51);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(125, 27);
            this.textBoxIPAddress.TabIndex = 3;
            // 
            // listBoxMember
            // 
            this.listBoxMember.FormattingEnabled = true;
            this.listBoxMember.ItemHeight = 20;
            this.listBoxMember.Location = new System.Drawing.Point(35, 91);
            this.listBoxMember.Name = "listBoxMember";
            this.listBoxMember.Size = new System.Drawing.Size(286, 164);
            this.listBoxMember.TabIndex = 4;
            this.listBoxMember.SelectedIndexChanged += new System.EventHandler(this.listBoxMember_SelectedIndexChanged);
            // 
            // listBoxRoom
            // 
            this.listBoxRoom.FormattingEnabled = true;
            this.listBoxRoom.ItemHeight = 20;
            this.listBoxRoom.Location = new System.Drawing.Point(35, 285);
            this.listBoxRoom.Name = "listBoxRoom";
            this.listBoxRoom.Size = new System.Drawing.Size(286, 164);
            this.listBoxRoom.TabIndex = 5;
            // 
            // buttonChattingStart
            // 
            this.buttonChattingStart.ForeColor = System.Drawing.Color.Black;
            this.buttonChattingStart.Location = new System.Drawing.Point(227, 471);
            this.buttonChattingStart.Name = "buttonChattingStart";
            this.buttonChattingStart.Size = new System.Drawing.Size(94, 29);
            this.buttonChattingStart.TabIndex = 6;
            this.buttonChattingStart.Text = "채팅 시작";
            this.buttonChattingStart.UseVisualStyleBackColor = true;
            this.buttonChattingStart.Click += new System.EventHandler(this.buttonChattingStart_Click);
            // 
            // FormChattingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(356, 512);
            this.Controls.Add(this.buttonChattingStart);
            this.Controls.Add(this.listBoxRoom);
            this.Controls.Add(this.listBoxMember);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.textBoxMyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Info);
            this.Name = "FormChattingList";
            this.Text = "FormChattingList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChattingList_FormClosing);
            this.Load += new System.EventHandler(this.FormChattingList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Info;
        private Label label1;
        private TextBox textBoxMyID;
        private TextBox textBoxIPAddress;
        private ListBox listBoxMember;
        private ListBox listBoxRoom;
        private Button buttonChattingStart;
    }
}