namespace DBP_관리
{
    partial class FormAdmin_User_Chat
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
			this.label_Chat_Title = new System.Windows.Forms.Label();
			this.tabControl_Chat_Time_Search = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dateTimePicker_Chat_Time_Search = new System.Windows.Forms.DateTimePicker();
			this.listBox_Chat_Time_Search = new System.Windows.Forms.ListBox();
			this.label_Chat_Time_Search = new System.Windows.Forms.Label();
			this.button_Chat_Time_Search = new System.Windows.Forms.Button();
			this.tabPage_Chat_Keyword_Search = new System.Windows.Forms.TabPage();
			this.listBox_Chat_Keyword_Search = new System.Windows.Forms.ListBox();
			this.label_Chat_Keyword_Search = new System.Windows.Forms.Label();
			this.button_Chat_Keyword_Search = new System.Windows.Forms.Button();
			this.textBox_Chat_Keyword_Search = new System.Windows.Forms.TextBox();
			this.tabPage_Chat_User_Search = new System.Windows.Forms.TabPage();
			this.label_Chat_User_Search = new System.Windows.Forms.Label();
			this.treeView_Chat_User_Search = new System.Windows.Forms.TreeView();
			this.groupBox_Chat_Search = new System.Windows.Forms.GroupBox();
			this.listBox_Chat_Search = new System.Windows.Forms.ListBox();
			this.label_Chat_Search = new System.Windows.Forms.Label();
			this.tabControl_Chat_Time_Search.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage_Chat_Keyword_Search.SuspendLayout();
			this.tabPage_Chat_User_Search.SuspendLayout();
			this.groupBox_Chat_Search.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Chat_Title
			// 
			this.label_Chat_Title.AutoSize = true;
			this.label_Chat_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Chat_Title.ForeColor = System.Drawing.Color.White;
			this.label_Chat_Title.Location = new System.Drawing.Point(37, 19);
			this.label_Chat_Title.Name = "label_Chat_Title";
			this.label_Chat_Title.Size = new System.Drawing.Size(306, 46);
			this.label_Chat_Title.TabIndex = 11;
			this.label_Chat_Title.Text = "[사용자] 대화 검색";
			// 
			// tabControl_Chat_Time_Search
			// 
			this.tabControl_Chat_Time_Search.Controls.Add(this.tabPage1);
			this.tabControl_Chat_Time_Search.Controls.Add(this.tabPage_Chat_Keyword_Search);
			this.tabControl_Chat_Time_Search.Controls.Add(this.tabPage_Chat_User_Search);
			this.tabControl_Chat_Time_Search.Location = new System.Drawing.Point(37, 91);
			this.tabControl_Chat_Time_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabControl_Chat_Time_Search.Name = "tabControl_Chat_Time_Search";
			this.tabControl_Chat_Time_Search.SelectedIndex = 0;
			this.tabControl_Chat_Time_Search.Size = new System.Drawing.Size(467, 580);
			this.tabControl_Chat_Time_Search.TabIndex = 12;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.tabPage1.Controls.Add(this.dateTimePicker_Chat_Time_Search);
			this.tabPage1.Controls.Add(this.listBox_Chat_Time_Search);
			this.tabPage1.Controls.Add(this.label_Chat_Time_Search);
			this.tabPage1.Controls.Add(this.button_Chat_Time_Search);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Size = new System.Drawing.Size(459, 547);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "시간별 검색";
			// 
			// dateTimePicker_Chat_Time_Search
			// 
			this.dateTimePicker_Chat_Time_Search.Location = new System.Drawing.Point(23, 25);
			this.dateTimePicker_Chat_Time_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker_Chat_Time_Search.Name = "dateTimePicker_Chat_Time_Search";
			this.dateTimePicker_Chat_Time_Search.Size = new System.Drawing.Size(307, 27);
			this.dateTimePicker_Chat_Time_Search.TabIndex = 21;
			// 
			// listBox_Chat_Time_Search
			// 
			this.listBox_Chat_Time_Search.FormattingEnabled = true;
			this.listBox_Chat_Time_Search.ItemHeight = 20;
			this.listBox_Chat_Time_Search.Location = new System.Drawing.Point(23, 91);
			this.listBox_Chat_Time_Search.Name = "listBox_Chat_Time_Search";
			this.listBox_Chat_Time_Search.Size = new System.Drawing.Size(408, 424);
			this.listBox_Chat_Time_Search.TabIndex = 20;
			this.listBox_Chat_Time_Search.SelectedIndexChanged += new System.EventHandler(this.listBox_Chat_Time_Search_SelectedIndexChanged);
			// 
			// label_Chat_Time_Search
			// 
			this.label_Chat_Time_Search.AutoSize = true;
			this.label_Chat_Time_Search.ForeColor = System.Drawing.Color.White;
			this.label_Chat_Time_Search.Location = new System.Drawing.Point(23, 68);
			this.label_Chat_Time_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Chat_Time_Search.Name = "label_Chat_Time_Search";
			this.label_Chat_Time_Search.Size = new System.Drawing.Size(89, 20);
			this.label_Chat_Time_Search.TabIndex = 19;
			this.label_Chat_Time_Search.Text = "대화창 목록";
			// 
			// button_Chat_Time_Search
			// 
			this.button_Chat_Time_Search.BackColor = System.Drawing.Color.White;
			this.button_Chat_Time_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Chat_Time_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Chat_Time_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Chat_Time_Search.Location = new System.Drawing.Point(338, 25);
			this.button_Chat_Time_Search.Name = "button_Chat_Time_Search";
			this.button_Chat_Time_Search.Size = new System.Drawing.Size(94, 32);
			this.button_Chat_Time_Search.TabIndex = 17;
			this.button_Chat_Time_Search.Text = "검색";
			this.button_Chat_Time_Search.UseVisualStyleBackColor = false;
			this.button_Chat_Time_Search.Click += new System.EventHandler(this.button_Chat_Time_Search_Click);
			// 
			// tabPage_Chat_Keyword_Search
			// 
			this.tabPage_Chat_Keyword_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.tabPage_Chat_Keyword_Search.Controls.Add(this.listBox_Chat_Keyword_Search);
			this.tabPage_Chat_Keyword_Search.Controls.Add(this.label_Chat_Keyword_Search);
			this.tabPage_Chat_Keyword_Search.Controls.Add(this.button_Chat_Keyword_Search);
			this.tabPage_Chat_Keyword_Search.Controls.Add(this.textBox_Chat_Keyword_Search);
			this.tabPage_Chat_Keyword_Search.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Chat_Keyword_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage_Chat_Keyword_Search.Name = "tabPage_Chat_Keyword_Search";
			this.tabPage_Chat_Keyword_Search.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage_Chat_Keyword_Search.Size = new System.Drawing.Size(459, 547);
			this.tabPage_Chat_Keyword_Search.TabIndex = 1;
			this.tabPage_Chat_Keyword_Search.Text = "키워드별 검색";
			// 
			// listBox_Chat_Keyword_Search
			// 
			this.listBox_Chat_Keyword_Search.FormattingEnabled = true;
			this.listBox_Chat_Keyword_Search.ItemHeight = 20;
			this.listBox_Chat_Keyword_Search.Location = new System.Drawing.Point(23, 91);
			this.listBox_Chat_Keyword_Search.Name = "listBox_Chat_Keyword_Search";
			this.listBox_Chat_Keyword_Search.Size = new System.Drawing.Size(408, 424);
			this.listBox_Chat_Keyword_Search.TabIndex = 16;
			this.listBox_Chat_Keyword_Search.SelectedIndexChanged += new System.EventHandler(this.listBox_Chat_Keyword_Search_SelectedIndexChanged);
			// 
			// label_Chat_Keyword_Search
			// 
			this.label_Chat_Keyword_Search.AutoSize = true;
			this.label_Chat_Keyword_Search.ForeColor = System.Drawing.Color.White;
			this.label_Chat_Keyword_Search.Location = new System.Drawing.Point(23, 68);
			this.label_Chat_Keyword_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Chat_Keyword_Search.Name = "label_Chat_Keyword_Search";
			this.label_Chat_Keyword_Search.Size = new System.Drawing.Size(89, 20);
			this.label_Chat_Keyword_Search.TabIndex = 15;
			this.label_Chat_Keyword_Search.Text = "대화창 목록";
			// 
			// button_Chat_Keyword_Search
			// 
			this.button_Chat_Keyword_Search.BackColor = System.Drawing.Color.White;
			this.button_Chat_Keyword_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Chat_Keyword_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Chat_Keyword_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Chat_Keyword_Search.Location = new System.Drawing.Point(338, 27);
			this.button_Chat_Keyword_Search.Name = "button_Chat_Keyword_Search";
			this.button_Chat_Keyword_Search.Size = new System.Drawing.Size(94, 31);
			this.button_Chat_Keyword_Search.TabIndex = 13;
			this.button_Chat_Keyword_Search.Text = "검색";
			this.button_Chat_Keyword_Search.UseVisualStyleBackColor = false;
			this.button_Chat_Keyword_Search.Click += new System.EventHandler(this.button_Chat_Keyword_Search_Click);
			// 
			// textBox_Chat_Keyword_Search
			// 
			this.textBox_Chat_Keyword_Search.Location = new System.Drawing.Point(23, 27);
			this.textBox_Chat_Keyword_Search.Name = "textBox_Chat_Keyword_Search";
			this.textBox_Chat_Keyword_Search.Size = new System.Drawing.Size(309, 27);
			this.textBox_Chat_Keyword_Search.TabIndex = 14;
			// 
			// tabPage_Chat_User_Search
			// 
			this.tabPage_Chat_User_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.tabPage_Chat_User_Search.Controls.Add(this.label_Chat_User_Search);
			this.tabPage_Chat_User_Search.Controls.Add(this.treeView_Chat_User_Search);
			this.tabPage_Chat_User_Search.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Chat_User_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage_Chat_User_Search.Name = "tabPage_Chat_User_Search";
			this.tabPage_Chat_User_Search.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage_Chat_User_Search.Size = new System.Drawing.Size(459, 547);
			this.tabPage_Chat_User_Search.TabIndex = 2;
			this.tabPage_Chat_User_Search.Text = "사용자별 검색";
			// 
			// label_Chat_User_Search
			// 
			this.label_Chat_User_Search.AutoSize = true;
			this.label_Chat_User_Search.ForeColor = System.Drawing.Color.White;
			this.label_Chat_User_Search.Location = new System.Drawing.Point(23, 27);
			this.label_Chat_User_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Chat_User_Search.Name = "label_Chat_User_Search";
			this.label_Chat_User_Search.Size = new System.Drawing.Size(124, 20);
			this.label_Chat_User_Search.TabIndex = 23;
			this.label_Chat_User_Search.Text = "다른 사용자 목록";
			// 
			// treeView_Chat_User_Search
			// 
			this.treeView_Chat_User_Search.Location = new System.Drawing.Point(23, 53);
			this.treeView_Chat_User_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.treeView_Chat_User_Search.Name = "treeView_Chat_User_Search";
			this.treeView_Chat_User_Search.Size = new System.Drawing.Size(408, 461);
			this.treeView_Chat_User_Search.TabIndex = 22;
			this.treeView_Chat_User_Search.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Chat_User_Search_AfterSelect);
			// 
			// groupBox_Chat_Search
			// 
			this.groupBox_Chat_Search.Controls.Add(this.listBox_Chat_Search);
			this.groupBox_Chat_Search.Controls.Add(this.label_Chat_Search);
			this.groupBox_Chat_Search.ForeColor = System.Drawing.Color.White;
			this.groupBox_Chat_Search.Location = new System.Drawing.Point(522, 91);
			this.groupBox_Chat_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox_Chat_Search.Name = "groupBox_Chat_Search";
			this.groupBox_Chat_Search.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox_Chat_Search.Size = new System.Drawing.Size(602, 580);
			this.groupBox_Chat_Search.TabIndex = 13;
			this.groupBox_Chat_Search.TabStop = false;
			this.groupBox_Chat_Search.Text = "검색 대화 내역";
			// 
			// listBox_Chat_Search
			// 
			this.listBox_Chat_Search.FormattingEnabled = true;
			this.listBox_Chat_Search.ItemHeight = 20;
			this.listBox_Chat_Search.Location = new System.Drawing.Point(22, 60);
			this.listBox_Chat_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.listBox_Chat_Search.Name = "listBox_Chat_Search";
			this.listBox_Chat_Search.Size = new System.Drawing.Size(550, 484);
			this.listBox_Chat_Search.TabIndex = 2;
			// 
			// label_Chat_Search
			// 
			this.label_Chat_Search.AutoSize = true;
			this.label_Chat_Search.Location = new System.Drawing.Point(22, 32);
			this.label_Chat_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Chat_Search.Name = "label_Chat_Search";
			this.label_Chat_Search.Size = new System.Drawing.Size(154, 20);
			this.label_Chat_Search.TabIndex = 1;
			this.label_Chat_Search.Text = "[선택 대화 목록 이름]";
			// 
			// FormAdmin_User_Chat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(1156, 729);
			this.Controls.Add(this.groupBox_Chat_Search);
			this.Controls.Add(this.tabControl_Chat_Time_Search);
			this.Controls.Add(this.label_Chat_Title);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormAdmin_User_Chat";
			this.Text = "사용자 대화 검색";
			this.tabControl_Chat_Time_Search.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage_Chat_Keyword_Search.ResumeLayout(false);
			this.tabPage_Chat_Keyword_Search.PerformLayout();
			this.tabPage_Chat_User_Search.ResumeLayout(false);
			this.tabPage_Chat_User_Search.PerformLayout();
			this.groupBox_Chat_Search.ResumeLayout(false);
			this.groupBox_Chat_Search.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label label_Chat_Title;
		private TabControl tabControl_Chat_Time_Search;
		private TabPage tabPage1;
		private TabPage tabPage_Chat_Keyword_Search;
		private TabPage tabPage_Chat_User_Search;
		private DateTimePicker dateTimePicker_Chat_Time_Search;
		private ListBox listBox_Chat_Time_Search;
		private Label label_Chat_Time_Search;
		private Button button_Chat_Time_Search;
		private ListBox listBox_Chat_Keyword_Search;
		private Label label_Chat_Keyword_Search;
		private Button button_Chat_Keyword_Search;
		private TextBox textBox_Chat_Keyword_Search;
		private GroupBox groupBox_Chat_Search;
		private Label label_Chat_Search;
		private Label label_Chat_User_Search;
		private TreeView treeView_Chat_User_Search;
		private ListBox listBox_Chat_Search;
	}
}