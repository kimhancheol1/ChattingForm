namespace DBP_관리 {
	partial class FormAdmin_Dpt {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.부서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button_Dpt_Search = new System.Windows.Forms.Button();
			this.button_Dpt_Plus = new System.Windows.Forms.Button();
			this.label_Dpt_Title = new System.Windows.Forms.Label();
			this.button_Dpt_Udt = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
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
			this.menuStrip1.TabIndex = 3;
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
			// button_Dpt_Search
			// 
			this.button_Dpt_Search.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Search.Location = new System.Drawing.Point(352, 28);
			this.button_Dpt_Search.Name = "button_Dpt_Search";
			this.button_Dpt_Search.Size = new System.Drawing.Size(65, 30);
			this.button_Dpt_Search.TabIndex = 6;
			this.button_Dpt_Search.Text = "검색";
			this.button_Dpt_Search.UseVisualStyleBackColor = false;
			this.button_Dpt_Search.Click += new System.EventHandler(this.button_Dpt_Search_Click);
			// 
			// button_Dpt_Plus
			// 
			this.button_Dpt_Plus.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Plus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Plus.Location = new System.Drawing.Point(408, 56);
			this.button_Dpt_Plus.Name = "button_Dpt_Plus";
			this.button_Dpt_Plus.Size = new System.Drawing.Size(96, 29);
			this.button_Dpt_Plus.TabIndex = 7;
			this.button_Dpt_Plus.Text = "부서 추가";
			this.button_Dpt_Plus.UseVisualStyleBackColor = false;
			this.button_Dpt_Plus.Click += new System.EventHandler(this.button_Dpt_Plus_Click);
			// 
			// label_Dpt_Title
			// 
			this.label_Dpt_Title.AutoSize = true;
			this.label_Dpt_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Dpt_Title.ForeColor = System.Drawing.Color.White;
			this.label_Dpt_Title.Location = new System.Drawing.Point(37, 19);
			this.label_Dpt_Title.Name = "label_Dpt_Title";
			this.label_Dpt_Title.Size = new System.Drawing.Size(168, 46);
			this.label_Dpt_Title.TabIndex = 9;
			this.label_Dpt_Title.Text = "부서 관리";
			// 
			// button_Dpt_Udt
			// 
			this.button_Dpt_Udt.BackColor = System.Drawing.Color.White;
			this.button_Dpt_Udt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Dpt_Udt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Dpt_Udt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Dpt_Udt.Location = new System.Drawing.Point(274, 59);
			this.button_Dpt_Udt.Name = "button_Dpt_Udt";
			this.button_Dpt_Udt.Size = new System.Drawing.Size(96, 29);
			this.button_Dpt_Udt.TabIndex = 10;
			this.button_Dpt_Udt.Text = "부서 수정";
			this.button_Dpt_Udt.UseVisualStyleBackColor = false;
			this.button_Dpt_Udt.Click += new System.EventHandler(this.button_Dpt_Udt_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.treeView1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button_Dpt_Search);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(37, 91);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(467, 438);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "조회";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button1.Location = new System.Drawing.Point(352, 71);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 28);
			this.button1.TabIndex = 16;
			this.button1.Text = "갱신";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(19, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "확장";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(18, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "부서명";
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(19, 111);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(369, 282);
			this.treeView1.TabIndex = 13;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(85, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(252, 30);
			this.textBox1.TabIndex = 12;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(530, 91);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(542, 519);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Information";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button6);
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.button4);
			this.groupBox4.Controls.Add(this.textBox3);
			this.groupBox4.Controls.Add(this.dataGridView1);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.button2);
			this.groupBox4.ForeColor = System.Drawing.Color.White;
			this.groupBox4.Location = new System.Drawing.Point(24, 193);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(474, 299);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Team";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.White;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button6.Location = new System.Drawing.Point(339, 242);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(96, 28);
			this.button6.TabIndex = 21;
			this.button6.Text = "수정 완료";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Visible = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.White;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button5.Location = new System.Drawing.Point(339, 242);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(96, 28);
			this.button5.TabIndex = 20;
			this.button5.Text = "등록";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Visible = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(17, 243);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "추가할 팀명";
			this.label4.Visible = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button4.Location = new System.Drawing.Point(339, 105);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(96, 28);
			this.button4.TabIndex = 18;
			this.button4.Text = "팀 수정";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(126, 243);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(188, 27);
			this.textBox3.TabIndex = 17;
			this.textBox3.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(17, 69);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(297, 152);
			this.dataGridView1.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(17, 39);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Team List";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button2.Location = new System.Drawing.Point(339, 69);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 28);
			this.button2.TabIndex = 10;
			this.button2.Text = "팀 추가";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.button_Dpt_Udt);
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(24, 41);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(474, 144);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Department";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button3.Location = new System.Drawing.Point(274, 95);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 28);
			this.button3.TabIndex = 17;
			this.button3.Text = "수정 완료";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(32, 61);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(219, 27);
			this.textBox2.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(32, 24);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "선택 부서";
			// 
			// FormAdmin_Dpt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(1156, 729);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label_Dpt_Title);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button_Dpt_Plus);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormAdmin_Dpt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "부서 관리";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 부서관리ToolStripMenuItem;
		private Button button_Dpt_Search;
		private Button button_Dpt_Plus;
		private ToolStripMenuItem 사용자관리ToolStripMenuItem;
		private ToolStripMenuItem 로그아웃ToolStripMenuItem;
		private Label label_Dpt_Title;
		private Button button_Dpt_Udt;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private TreeView treeView1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Button button1;
        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox4;
        private Label label6;
        private Button button2;
        private TextBox textBox2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Button button5;
        private Label label4;
        private Button button4;
        private Button button6;
    }
}