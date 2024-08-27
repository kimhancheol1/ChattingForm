namespace DBP_관리 {
	partial class FormAdmin_User_Pri {
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
			this.label_Pri_Title = new System.Windows.Forms.Label();
			this.groupBox_Pri_Visible = new System.Windows.Forms.GroupBox();
			this.treeView_Pri_Visible = new System.Windows.Forms.TreeView();
			this.button_Pri_Visible = new System.Windows.Forms.Button();
			this.groupBox_Pri_Chat = new System.Windows.Forms.GroupBox();
			this.checkedListBox_Pri_Chat = new System.Windows.Forms.CheckedListBox();
			this.button_Pri_Chat = new System.Windows.Forms.Button();
			this.groupBox_Pri_Visible.SuspendLayout();
			this.groupBox_Pri_Chat.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Pri_Title
			// 
			this.label_Pri_Title.AutoSize = true;
			this.label_Pri_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_Pri_Title.ForeColor = System.Drawing.Color.White;
			this.label_Pri_Title.Location = new System.Drawing.Point(37, 19);
			this.label_Pri_Title.Name = "label_Pri_Title";
			this.label_Pri_Title.Size = new System.Drawing.Size(306, 46);
			this.label_Pri_Title.TabIndex = 0;
			this.label_Pri_Title.Text = "[사용자] 권한 조정";
			// 
			// groupBox_Pri_Visible
			// 
			this.groupBox_Pri_Visible.Controls.Add(this.treeView_Pri_Visible);
			this.groupBox_Pri_Visible.Controls.Add(this.button_Pri_Visible);
			this.groupBox_Pri_Visible.ForeColor = System.Drawing.Color.White;
			this.groupBox_Pri_Visible.Location = new System.Drawing.Point(37, 91);
			this.groupBox_Pri_Visible.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox_Pri_Visible.Name = "groupBox_Pri_Visible";
			this.groupBox_Pri_Visible.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox_Pri_Visible.Size = new System.Drawing.Size(526, 580);
			this.groupBox_Pri_Visible.TabIndex = 9;
			this.groupBox_Pri_Visible.TabStop = false;
			this.groupBox_Pri_Visible.Text = "직원 보기 권한 조정";
			// 
			// treeView_Pri_Visible
			// 
			this.treeView_Pri_Visible.CheckBoxes = true;
			this.treeView_Pri_Visible.Location = new System.Drawing.Point(27, 29);
			this.treeView_Pri_Visible.Name = "treeView_Pri_Visible";
			this.treeView_Pri_Visible.Size = new System.Drawing.Size(463, 488);
			this.treeView_Pri_Visible.TabIndex = 9;
			this.treeView_Pri_Visible.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Pri_Visible_AfterCheck);
			this.treeView_Pri_Visible.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Pri_Visible_AfterSelect);
			// 
			// button_Pri_Visible
			// 
			this.button_Pri_Visible.BackColor = System.Drawing.Color.White;
			this.button_Pri_Visible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Pri_Visible.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Pri_Visible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Pri_Visible.Location = new System.Drawing.Point(27, 528);
			this.button_Pri_Visible.Name = "button_Pri_Visible";
			this.button_Pri_Visible.Size = new System.Drawing.Size(464, 31);
			this.button_Pri_Visible.TabIndex = 6;
			this.button_Pri_Visible.Text = "적용하기";
			this.button_Pri_Visible.UseVisualStyleBackColor = false;
			this.button_Pri_Visible.Click += new System.EventHandler(this.button_Pri_Visible_Click);
			// 
			// groupBox_Pri_Chat
			// 
			this.groupBox_Pri_Chat.Controls.Add(this.checkedListBox_Pri_Chat);
			this.groupBox_Pri_Chat.Controls.Add(this.button_Pri_Chat);
			this.groupBox_Pri_Chat.ForeColor = System.Drawing.Color.White;
			this.groupBox_Pri_Chat.Location = new System.Drawing.Point(586, 91);
			this.groupBox_Pri_Chat.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox_Pri_Chat.Name = "groupBox_Pri_Chat";
			this.groupBox_Pri_Chat.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox_Pri_Chat.Size = new System.Drawing.Size(526, 580);
			this.groupBox_Pri_Chat.TabIndex = 10;
			this.groupBox_Pri_Chat.TabStop = false;
			this.groupBox_Pri_Chat.Text = "직원 대화 권한 조정";
			// 
			// checkedListBox_Pri_Chat
			// 
			this.checkedListBox_Pri_Chat.FormattingEnabled = true;
			this.checkedListBox_Pri_Chat.Location = new System.Drawing.Point(27, 29);
			this.checkedListBox_Pri_Chat.Margin = new System.Windows.Forms.Padding(4);
			this.checkedListBox_Pri_Chat.Name = "checkedListBox_Pri_Chat";
			this.checkedListBox_Pri_Chat.Size = new System.Drawing.Size(463, 488);
			this.checkedListBox_Pri_Chat.TabIndex = 5;
			// 
			// button_Pri_Chat
			// 
			this.button_Pri_Chat.BackColor = System.Drawing.Color.White;
			this.button_Pri_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_Pri_Chat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_Pri_Chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_Pri_Chat.Location = new System.Drawing.Point(27, 528);
			this.button_Pri_Chat.Name = "button_Pri_Chat";
			this.button_Pri_Chat.Size = new System.Drawing.Size(464, 31);
			this.button_Pri_Chat.TabIndex = 4;
			this.button_Pri_Chat.Text = "적용하기";
			this.button_Pri_Chat.UseVisualStyleBackColor = false;
			this.button_Pri_Chat.Click += new System.EventHandler(this.button_Pri_Chat_Click);
			// 
			// FormAdmin_User_Pri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(1156, 729);
			this.Controls.Add(this.groupBox_Pri_Chat);
			this.Controls.Add(this.groupBox_Pri_Visible);
			this.Controls.Add(this.label_Pri_Title);
			this.Name = "FormAdmin_User_Pri";
			this.Text = "사용자 권한 조정";
			this.groupBox_Pri_Visible.ResumeLayout(false);
			this.groupBox_Pri_Chat.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label_Pri_Title;
		private GroupBox groupBox_Pri_Visible;
		private GroupBox groupBox_Pri_Chat;
		private Button button_Pri_Chat;
		private CheckedListBox checkedListBox_Pri_Chat;
		private TreeView treeView_Pri_Visible;
		private Button button_Pri_Visible;
	}
}