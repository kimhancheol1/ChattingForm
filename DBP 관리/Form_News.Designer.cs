namespace DBP_관리 {
	partial class Form_News {
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
			this.label_News_Title = new System.Windows.Forms.Label();
			this.groupBox_News_Search = new System.Windows.Forms.GroupBox();
			this.trackBar_News_Count = new System.Windows.Forms.TrackBar();
			this.label_News_Count = new System.Windows.Forms.Label();
			this.button_News_Search = new System.Windows.Forms.Button();
			this.textBox_News_Keyword = new System.Windows.Forms.TextBox();
			this.label_News_Keyword = new System.Windows.Forms.Label();
			this.groupBox_News_Result = new System.Windows.Forms.GroupBox();
			this.listView_News_Result = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox_News_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_News_Count)).BeginInit();
			this.groupBox_News_Result.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_News_Title
			// 
			this.label_News_Title.AutoSize = true;
			this.label_News_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_News_Title.Location = new System.Drawing.Point(239, 34);
			this.label_News_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_News_Title.Name = "label_News_Title";
			this.label_News_Title.Size = new System.Drawing.Size(134, 37);
			this.label_News_Title.TabIndex = 6;
			this.label_News_Title.Text = "뉴스 검색";
			// 
			// groupBox_News_Search
			// 
			this.groupBox_News_Search.Controls.Add(this.trackBar_News_Count);
			this.groupBox_News_Search.Controls.Add(this.label_News_Count);
			this.groupBox_News_Search.Controls.Add(this.button_News_Search);
			this.groupBox_News_Search.Controls.Add(this.textBox_News_Keyword);
			this.groupBox_News_Search.Controls.Add(this.label_News_Keyword);
			this.groupBox_News_Search.ForeColor = System.Drawing.Color.White;
			this.groupBox_News_Search.Location = new System.Drawing.Point(26, 86);
			this.groupBox_News_Search.Name = "groupBox_News_Search";
			this.groupBox_News_Search.Size = new System.Drawing.Size(560, 107);
			this.groupBox_News_Search.TabIndex = 7;
			this.groupBox_News_Search.TabStop = false;
			this.groupBox_News_Search.Text = "검색 키워드";
			// 
			// trackBar_News_Count
			// 
			this.trackBar_News_Count.Location = new System.Drawing.Point(130, 56);
			this.trackBar_News_Count.Maximum = 100;
			this.trackBar_News_Count.Minimum = 10;
			this.trackBar_News_Count.Name = "trackBar_News_Count";
			this.trackBar_News_Count.Size = new System.Drawing.Size(308, 45);
			this.trackBar_News_Count.TabIndex = 4;
			this.trackBar_News_Count.TickFrequency = 10;
			this.trackBar_News_Count.Value = 10;
			// 
			// label_News_Count
			// 
			this.label_News_Count.AutoSize = true;
			this.label_News_Count.Location = new System.Drawing.Point(24, 65);
			this.label_News_Count.Name = "label_News_Count";
			this.label_News_Count.Size = new System.Drawing.Size(87, 15);
			this.label_News_Count.TabIndex = 3;
			this.label_News_Count.Text = "결과 출력 개수";
			// 
			// button_News_Search
			// 
			this.button_News_Search.BackColor = System.Drawing.Color.White;
			this.button_News_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_News_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_News_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.button_News_Search.Location = new System.Drawing.Point(454, 23);
			this.button_News_Search.Name = "button_News_Search";
			this.button_News_Search.Size = new System.Drawing.Size(91, 63);
			this.button_News_Search.TabIndex = 2;
			this.button_News_Search.Text = "검색하기";
			this.button_News_Search.UseVisualStyleBackColor = false;
			this.button_News_Search.Click += new System.EventHandler(this.button_News_Search_Click);
			// 
			// textBox_News_Keyword
			// 
			this.textBox_News_Keyword.Location = new System.Drawing.Point(130, 23);
			this.textBox_News_Keyword.Name = "textBox_News_Keyword";
			this.textBox_News_Keyword.Size = new System.Drawing.Size(308, 23);
			this.textBox_News_Keyword.TabIndex = 1;
			// 
			// label_News_Keyword
			// 
			this.label_News_Keyword.AutoSize = true;
			this.label_News_Keyword.Location = new System.Drawing.Point(24, 26);
			this.label_News_Keyword.Name = "label_News_Keyword";
			this.label_News_Keyword.Size = new System.Drawing.Size(71, 15);
			this.label_News_Keyword.TabIndex = 0;
			this.label_News_Keyword.Text = "검색 키워드";
			// 
			// groupBox_News_Result
			// 
			this.groupBox_News_Result.Controls.Add(this.listView_News_Result);
			this.groupBox_News_Result.ForeColor = System.Drawing.Color.White;
			this.groupBox_News_Result.Location = new System.Drawing.Point(26, 211);
			this.groupBox_News_Result.Name = "groupBox_News_Result";
			this.groupBox_News_Result.Size = new System.Drawing.Size(560, 234);
			this.groupBox_News_Result.TabIndex = 8;
			this.groupBox_News_Result.TabStop = false;
			this.groupBox_News_Result.Text = "결과 결과";
			// 
			// listView_News_Result
			// 
			this.listView_News_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView_News_Result.FullRowSelect = true;
			this.listView_News_Result.Location = new System.Drawing.Point(14, 22);
			this.listView_News_Result.MultiSelect = false;
			this.listView_News_Result.Name = "listView_News_Result";
			this.listView_News_Result.Size = new System.Drawing.Size(531, 195);
			this.listView_News_Result.TabIndex = 0;
			this.listView_News_Result.UseCompatibleStateImageBehavior = false;
			this.listView_News_Result.View = System.Windows.Forms.View.Details;
			this.listView_News_Result.SelectedIndexChanged += new System.EventHandler(this.listView_News_Result_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "No.";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "제목";
			this.columnHeader2.Width = 280;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "링크";
			this.columnHeader3.Width = 188;
			// 
			// Form_News
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(612, 466);
			this.Controls.Add(this.groupBox_News_Result);
			this.Controls.Add(this.groupBox_News_Search);
			this.Controls.Add(this.label_News_Title);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form_News";
			this.Text = "뉴스";
			this.groupBox_News_Search.ResumeLayout(false);
			this.groupBox_News_Search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_News_Count)).EndInit();
			this.groupBox_News_Result.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label label_News_Title;
		private GroupBox groupBox_News_Search;
		private GroupBox groupBox_News_Result;
		private TrackBar trackBar_News_Count;
		private Label label_News_Count;
		private Button button_News_Search;
		private TextBox textBox_News_Keyword;
		private Label label_News_Keyword;
		private ListView listView_News_Result;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
	}
}