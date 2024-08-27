namespace DBP_관리

{
    partial class Form_Address
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
			this.txt_Keyword = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.list_Address = new System.Windows.Forms.ListBox();
			this.btn_Search = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_Keyword
			// 
			this.txt_Keyword.Location = new System.Drawing.Point(105, 44);
			this.txt_Keyword.Name = "txt_Keyword";
			this.txt_Keyword.Size = new System.Drawing.Size(195, 27);
			this.txt_Keyword.TabIndex = 0;
			this.txt_Keyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEnter);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.list_Address);
			this.groupBox1.Controls.Add(this.btn_Search);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_Keyword);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(28, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(760, 711);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "주소 검색";
			// 
			// list_Address
			// 
			this.list_Address.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.list_Address.FormattingEnabled = true;
			this.list_Address.ItemHeight = 80;
			this.list_Address.Location = new System.Drawing.Point(6, 94);
			this.list_Address.Name = "list_Address";
			this.list_Address.Size = new System.Drawing.Size(748, 604);
			this.list_Address.Sorted = true;
			this.list_Address.TabIndex = 5;
			this.list_Address.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
			this.list_Address.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.list_Address.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.Color.White;
			this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Search.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.btn_Search.Location = new System.Drawing.Point(332, 44);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(94, 29);
			this.btn_Search.TabIndex = 2;
			this.btn_Search.Text = "검색";
			this.btn_Search.UseVisualStyleBackColor = false;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "키워드";
			// 
			// Form_Address
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(800, 748);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form_Address";
			this.Text = "우편검색";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Address_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_Keyword;
        private GroupBox groupBox1;
        private Button btn_Search;
        private Label label1;
        private ListBox list_Address;
    }
}