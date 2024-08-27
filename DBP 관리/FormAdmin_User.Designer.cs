namespace DBP_관리 {
	partial class FormAdmin_User {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.treeView_User = new System.Windows.Forms.TreeView();
			this.button_User_DptChange = new System.Windows.Forms.Button();
			this.label_User_Name = new System.Windows.Forms.Label();
			this.button_User_Pri = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.부서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label_User_Title = new System.Windows.Forms.Label();
			this.groupBox_User_Dpt = new System.Windows.Forms.GroupBox();
			this.label_User_Dpt = new System.Windows.Forms.Label();
			this.groupBox_User_DptChange = new System.Windows.Forms.GroupBox();
			this.label_User_DptChange_Name2 = new System.Windows.Forms.Label();
			this.label_User_DptChange_Name1 = new System.Windows.Forms.Label();
			this.treeView_User_DptChange = new System.Windows.Forms.TreeView();
			this.groupBox_User_Log = new System.Windows.Forms.GroupBox();
			this.label_User_Log_Date = new System.Windows.Forms.Label();
			this.dateTimePicker_User_Log2 = new System.Windows.Forms.DateTimePicker();
			this.button_User_Log = new System.Windows.Forms.Button();
			this.dateTimePicker_User_Log1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView_User_Log = new System.Windows.Forms.DataGridView();
			this.button_User_Chat = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBox_User_Dpt.SuspendLayout();
			this.groupBox_User_DptChange.SuspendLayout();
			this.groupBox_User_Log.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_User_Log)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView_User
			// 
			this.treeView_User.Location = new System.Drawing.Point(18, 48);
			this.treeView_User.Name = "treeView_User";
			this.treeView_User.Size = new System.Drawing.Size(427, 511);
			this.treeView_User.TabIndex = 0;
			this.treeView_User.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_User_AfterSelect);
			// 
			// button_User_DptChange
			// 
			this.button_User_DptChange.BackColor = System.Drawing.Color.White;
			this.button_User_DptChange.Enabled = false;
			this.button_User_DptChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_DptChange.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_DptChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_DptChange.Location = new System.Drawing.Point(306, 179);
			this.button_User_DptChange.Name = "button_User_DptChange";
			this.button_User_DptChange.Size = new System.Drawing.Size(287, 29);
			this.button_User_DptChange.TabIndex = 1;
			this.button_User_DptChange.Text = "부서 변경";
			this.button_User_DptChange.UseVisualStyleBackColor = false;
			this.button_User_DptChange.Click += new System.EventHandler(this.button_User_DptChange_Click);
			// 
			// label_User_Name
			// 
			this.label_User_Name.AutoSize = true;
			this.label_User_Name.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_User_Name.ForeColor = System.Drawing.Color.White;
			this.label_User_Name.Location = new System.Drawing.Point(522, 91);
			this.label_User_Name.Name = "label_User_Name";
			this.label_User_Name.Size = new System.Drawing.Size(197, 23);
			this.label_User_Name.TabIndex = 3;
			this.label_User_Name.Text = "관리할 사용자 : [사용자]";
			// 
			// button_User_Pri
			// 
			this.button_User_Pri.BackColor = System.Drawing.Color.White;
			this.button_User_Pri.Enabled = false;
			this.button_User_Pri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_Pri.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_Pri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_Pri.Location = new System.Drawing.Point(738, 87);
			this.button_User_Pri.Name = "button_User_Pri";
			this.button_User_Pri.Size = new System.Drawing.Size(94, 29);
			this.button_User_Pri.TabIndex = 4;
			this.button_User_Pri.Text = "권한 조정";
			this.button_User_Pri.UseVisualStyleBackColor = false;
			this.button_User_Pri.Click += new System.EventHandler(this.button_User_Pri_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.부서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 699);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(1156, 30);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 부서관리ToolStripMenuItem
			// 
			this.부서관리ToolStripMenuItem.Name = "부서관리ToolStripMenuItem";
			this.부서관리ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
			this.부서관리ToolStripMenuItem.Text = "부서 관리";
			this.부서관리ToolStripMenuItem.Click += new System.EventHandler(this.부서관리ToolStripMenuItem_Click);
			// 
			// 사용자관리ToolStripMenuItem
			// 
			this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
			this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
			this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
			this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
			// 
			// 로그아웃ToolStripMenuItem
			// 
			this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
			this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
			this.로그아웃ToolStripMenuItem.Text = "로그아웃";
			this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
			// 
			// label_User_Title
			// 
			this.label_User_Title.AutoSize = true;
			this.label_User_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_User_Title.ForeColor = System.Drawing.Color.White;
			this.label_User_Title.Location = new System.Drawing.Point(37, 19);
			this.label_User_Title.Name = "label_User_Title";
			this.label_User_Title.Size = new System.Drawing.Size(202, 46);
			this.label_User_Title.TabIndex = 6;
			this.label_User_Title.Text = "사용자 관리";
			// 
			// groupBox_User_Dpt
			// 
			this.groupBox_User_Dpt.Controls.Add(this.label_User_Dpt);
			this.groupBox_User_Dpt.Controls.Add(this.treeView_User);
			this.groupBox_User_Dpt.ForeColor = System.Drawing.Color.White;
			this.groupBox_User_Dpt.Location = new System.Drawing.Point(37, 91);
			this.groupBox_User_Dpt.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox_User_Dpt.Name = "groupBox_User_Dpt";
			this.groupBox_User_Dpt.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox_User_Dpt.Size = new System.Drawing.Size(467, 580);
			this.groupBox_User_Dpt.TabIndex = 7;
			this.groupBox_User_Dpt.TabStop = false;
			this.groupBox_User_Dpt.Text = "조회";
			// 
			// label_User_Dpt
			// 
			this.label_User_Dpt.AutoSize = true;
			this.label_User_Dpt.Location = new System.Drawing.Point(18, 25);
			this.label_User_Dpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_User_Dpt.Name = "label_User_Dpt";
			this.label_User_Dpt.Size = new System.Drawing.Size(139, 20);
			this.label_User_Dpt.TabIndex = 1;
			this.label_User_Dpt.Text = "부서별 사용자 목록";
			// 
			// groupBox_User_DptChange
			// 
			this.groupBox_User_DptChange.Controls.Add(this.label_User_DptChange_Name2);
			this.groupBox_User_DptChange.Controls.Add(this.label_User_DptChange_Name1);
			this.groupBox_User_DptChange.Controls.Add(this.treeView_User_DptChange);
			this.groupBox_User_DptChange.Controls.Add(this.button_User_DptChange);
			this.groupBox_User_DptChange.ForeColor = System.Drawing.Color.White;
			this.groupBox_User_DptChange.Location = new System.Drawing.Point(522, 121);
			this.groupBox_User_DptChange.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox_User_DptChange.Name = "groupBox_User_DptChange";
			this.groupBox_User_DptChange.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox_User_DptChange.Size = new System.Drawing.Size(606, 271);
			this.groupBox_User_DptChange.TabIndex = 8;
			this.groupBox_User_DptChange.TabStop = false;
			this.groupBox_User_DptChange.Text = "부서 변경";
			// 
			// label_User_DptChange_Name2
			// 
			this.label_User_DptChange_Name2.AutoSize = true;
			this.label_User_DptChange_Name2.Location = new System.Drawing.Point(306, 123);
			this.label_User_DptChange_Name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_User_DptChange_Name2.Name = "label_User_DptChange_Name2";
			this.label_User_DptChange_Name2.Size = new System.Drawing.Size(157, 20);
			this.label_User_DptChange_Name2.TabIndex = 2;
			this.label_User_DptChange_Name2.Text = "변경 소속 : [부서] [팀]";
			// 
			// label_User_DptChange_Name1
			// 
			this.label_User_DptChange_Name1.AutoSize = true;
			this.label_User_DptChange_Name1.Location = new System.Drawing.Point(306, 73);
			this.label_User_DptChange_Name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_User_DptChange_Name1.Name = "label_User_DptChange_Name1";
			this.label_User_DptChange_Name1.Size = new System.Drawing.Size(157, 20);
			this.label_User_DptChange_Name1.TabIndex = 1;
			this.label_User_DptChange_Name1.Text = "현재 소속 : [부서] [팀]";
			// 
			// treeView_User_DptChange
			// 
			this.treeView_User_DptChange.Location = new System.Drawing.Point(13, 32);
			this.treeView_User_DptChange.Margin = new System.Windows.Forms.Padding(4);
			this.treeView_User_DptChange.Name = "treeView_User_DptChange";
			this.treeView_User_DptChange.Size = new System.Drawing.Size(284, 215);
			this.treeView_User_DptChange.TabIndex = 0;
			this.treeView_User_DptChange.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_User_DptChange_AfterSelect);
			// 
			// groupBox_User_Log
			// 
			this.groupBox_User_Log.Controls.Add(this.label_User_Log_Date);
			this.groupBox_User_Log.Controls.Add(this.dateTimePicker_User_Log2);
			this.groupBox_User_Log.Controls.Add(this.button_User_Log);
			this.groupBox_User_Log.Controls.Add(this.dateTimePicker_User_Log1);
			this.groupBox_User_Log.Controls.Add(this.dataGridView_User_Log);
			this.groupBox_User_Log.ForeColor = System.Drawing.Color.White;
			this.groupBox_User_Log.Location = new System.Drawing.Point(522, 400);
			this.groupBox_User_Log.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox_User_Log.Name = "groupBox_User_Log";
			this.groupBox_User_Log.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox_User_Log.Size = new System.Drawing.Size(606, 271);
			this.groupBox_User_Log.TabIndex = 9;
			this.groupBox_User_Log.TabStop = false;
			this.groupBox_User_Log.Text = "로그 검색";
			// 
			// label_User_Log_Date
			// 
			this.label_User_Log_Date.AutoSize = true;
			this.label_User_Log_Date.Location = new System.Drawing.Point(238, 33);
			this.label_User_Log_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_User_Log_Date.Name = "label_User_Log_Date";
			this.label_User_Log_Date.Size = new System.Drawing.Size(20, 20);
			this.label_User_Log_Date.TabIndex = 13;
			this.label_User_Log_Date.Text = "~";
			// 
			// dateTimePicker_User_Log2
			// 
			this.dateTimePicker_User_Log2.Location = new System.Drawing.Point(265, 27);
			this.dateTimePicker_User_Log2.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker_User_Log2.Name = "dateTimePicker_User_Log2";
			this.dateTimePicker_User_Log2.Size = new System.Drawing.Size(217, 27);
			this.dateTimePicker_User_Log2.TabIndex = 12;
			// 
			// button_User_Log
			// 
			this.button_User_Log.BackColor = System.Drawing.Color.White;
			this.button_User_Log.Enabled = false;
			this.button_User_Log.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_Log.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_Log.Location = new System.Drawing.Point(499, 28);
			this.button_User_Log.Name = "button_User_Log";
			this.button_User_Log.Size = new System.Drawing.Size(94, 29);
			this.button_User_Log.TabIndex = 11;
			this.button_User_Log.Text = "검색하기";
			this.button_User_Log.UseVisualStyleBackColor = false;
			this.button_User_Log.Click += new System.EventHandler(this.button_User_Log_Click);
			// 
			// dateTimePicker_User_Log1
			// 
			this.dateTimePicker_User_Log1.Location = new System.Drawing.Point(13, 27);
			this.dateTimePicker_User_Log1.Name = "dateTimePicker_User_Log1";
			this.dateTimePicker_User_Log1.Size = new System.Drawing.Size(217, 27);
			this.dateTimePicker_User_Log1.TabIndex = 3;
			// 
			// dataGridView_User_Log
			// 
			this.dataGridView_User_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_User_Log.Location = new System.Drawing.Point(13, 68);
			this.dataGridView_User_Log.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_User_Log.Name = "dataGridView_User_Log";
			this.dataGridView_User_Log.RowHeadersWidth = 51;
			this.dataGridView_User_Log.RowTemplate.Height = 25;
			this.dataGridView_User_Log.Size = new System.Drawing.Size(580, 183);
			this.dataGridView_User_Log.TabIndex = 0;
			// 
			// button_User_Chat
			// 
			this.button_User_Chat.BackColor = System.Drawing.Color.White;
			this.button_User_Chat.Enabled = false;
			this.button_User_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_User_Chat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_User_Chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_User_Chat.Location = new System.Drawing.Point(837, 87);
			this.button_User_Chat.Name = "button_User_Chat";
			this.button_User_Chat.Size = new System.Drawing.Size(94, 29);
			this.button_User_Chat.TabIndex = 10;
			this.button_User_Chat.Text = "대화 검색";
			this.button_User_Chat.UseVisualStyleBackColor = false;
			this.button_User_Chat.Click += new System.EventHandler(this.button_User_Chat_Click);
			// 
			// FormAdmin_User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(1156, 729);
			this.ControlBox = false;
			this.Controls.Add(this.button_User_Chat);
			this.Controls.Add(this.groupBox_User_Log);
			this.Controls.Add(this.groupBox_User_DptChange);
			this.Controls.Add(this.groupBox_User_Dpt);
			this.Controls.Add(this.label_User_Title);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button_User_Pri);
			this.Controls.Add(this.label_User_Name);
			this.Name = "FormAdmin_User";
			this.Text = "사용자 관리";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox_User_Dpt.ResumeLayout(false);
			this.groupBox_User_Dpt.PerformLayout();
			this.groupBox_User_DptChange.ResumeLayout(false);
			this.groupBox_User_DptChange.PerformLayout();
			this.groupBox_User_Log.ResumeLayout(false);
			this.groupBox_User_Log.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_User_Log)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TreeView treeView_User;
		private Button button_User_DptChange;
		private Label label_User_Name;
		private Button button_User_Pri;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 부서관리ToolStripMenuItem;
		private ToolStripMenuItem 사용자관리ToolStripMenuItem;
		private ToolStripMenuItem 로그아웃ToolStripMenuItem;
		private Label label_User_Title;
		private GroupBox groupBox_User_Dpt;
		private GroupBox groupBox_User_DptChange;
		private TreeView treeView_User_DptChange;
		private Label label_User_DptChange_Name1;
		private GroupBox groupBox_User_Log;
		private Label label_User_Dpt;
		private DataGridView dataGridView_User_Log;
		private Label label_User_DptChange_Name2;
		private Button button_User_Chat;
		private DateTimePicker dateTimePicker_User_Log1;
		private Button button_User_Log;
		private DateTimePicker dateTimePicker_User_Log2;
		private Label label_User_Log_Date;
	}
}