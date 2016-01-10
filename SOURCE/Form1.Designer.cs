namespace ExtractTransform
{
	partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "{skip}",
            "1",
            "1"}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.goB = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.JSONTabPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.waitTimeSeconds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.postTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deltaLogicLV = new System.Windows.Forms.ListView();
            this.getOrPostKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangeInt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startInt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.runCountCB = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.HtmlURLTB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.JSONTabPage.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // goB
            // 
            this.goB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goB.Location = new System.Drawing.Point(5, 382);
            this.goB.Name = "goB";
            this.goB.Size = new System.Drawing.Size(432, 23);
            this.goB.TabIndex = 11;
            this.goB.Text = "Run";
            this.goB.UseVisualStyleBackColor = true;
            this.goB.Click += new System.EventHandler(this.goB_Click);
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(5, 437);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTB.Size = new System.Drawing.Size(432, 238);
            this.outputTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Output";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.JSONTabPage);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 349);
            this.tabControl1.TabIndex = 15;
            // 
            // JSONTabPage
            // 
            this.JSONTabPage.Controls.Add(this.label7);
            this.JSONTabPage.Controls.Add(this.waitTimeSeconds);
            this.JSONTabPage.Controls.Add(this.label1);
            this.JSONTabPage.Controls.Add(this.urlTB);
            this.JSONTabPage.Controls.Add(this.postTB);
            this.JSONTabPage.Controls.Add(this.label2);
            this.JSONTabPage.Controls.Add(this.label3);
            this.JSONTabPage.Controls.Add(this.deltaLogicLV);
            this.JSONTabPage.Controls.Add(this.label4);
            this.JSONTabPage.Controls.Add(this.runCountCB);
            this.JSONTabPage.Location = new System.Drawing.Point(4, 22);
            this.JSONTabPage.Name = "JSONTabPage";
            this.JSONTabPage.Size = new System.Drawing.Size(426, 323);
            this.JSONTabPage.TabIndex = 0;
            this.JSONTabPage.Text = "JSON";
            this.JSONTabPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Wait Time Seconds";
            // 
            // waitTimeSeconds
            // 
            this.waitTimeSeconds.FormattingEnabled = true;
            this.waitTimeSeconds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10"});
            this.waitTimeSeconds.Location = new System.Drawing.Point(178, 255);
            this.waitTimeSeconds.Name = "waitTimeSeconds";
            this.waitTimeSeconds.Size = new System.Drawing.Size(149, 21);
            this.waitTimeSeconds.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "URL";
            // 
            // urlTB
            // 
            this.urlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTB.Location = new System.Drawing.Point(7, 29);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(410, 20);
            this.urlTB.TabIndex = 13;
            this.urlTB.Text = "https://api.spotify.com/v1/users/{skip}";
            // 
            // postTB
            // 
            this.postTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postTB.Location = new System.Drawing.Point(7, 79);
            this.postTB.Multiline = true;
            this.postTB.Name = "postTB";
            this.postTB.Size = new System.Drawing.Size(410, 68);
            this.postTB.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Post Values";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Delta Logic";
            // 
            // deltaLogicLV
            // 
            this.deltaLogicLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deltaLogicLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.getOrPostKey,
            this.ChangeInt,
            this.startInt});
            this.deltaLogicLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.deltaLogicLV.Location = new System.Drawing.Point(7, 166);
            this.deltaLogicLV.Name = "deltaLogicLV";
            this.deltaLogicLV.Size = new System.Drawing.Size(410, 70);
            this.deltaLogicLV.TabIndex = 18;
            this.deltaLogicLV.UseCompatibleStateImageBehavior = false;
            this.deltaLogicLV.View = System.Windows.Forms.View.Details;
            // 
            // getOrPostKey
            // 
            this.getOrPostKey.Text = "Get or post key";
            this.getOrPostKey.Width = 203;
            // 
            // ChangeInt
            // 
            this.ChangeInt.Text = "ChangeInt";
            this.ChangeInt.Width = 106;
            // 
            // startInt
            // 
            this.startInt.Text = "Start Int";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Run Count";
            // 
            // runCountCB
            // 
            this.runCountCB.FormattingEnabled = true;
            this.runCountCB.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "Until Done"});
            this.runCountCB.Location = new System.Drawing.Point(7, 255);
            this.runCountCB.Name = "runCountCB";
            this.runCountCB.Size = new System.Drawing.Size(149, 21);
            this.runCountCB.TabIndex = 19;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.HtmlURLTB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(426, 323);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "HTML";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "URL";
            // 
            // HtmlURLTB
            // 
            this.HtmlURLTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HtmlURLTB.Location = new System.Drawing.Point(7, 27);
            this.HtmlURLTB.Name = "HtmlURLTB";
            this.HtmlURLTB.Size = new System.Drawing.Size(410, 20);
            this.HtmlURLTB.TabIndex = 15;
            this.HtmlURLTB.Text = "http://www.bunnings.com.au/our-range/bathroom-plumbing/bathroom/toilets/toilets?s" +
    "ort=NameAscending";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 685);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.goB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.JSONTabPage.ResumeLayout(false);
            this.JSONTabPage.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Button goB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox outputTB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage JSONTabPage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox waitTimeSeconds;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox urlTB;
        public System.Windows.Forms.TextBox postTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView deltaLogicLV;
        public System.Windows.Forms.ColumnHeader getOrPostKey;
        public System.Windows.Forms.ColumnHeader ChangeInt;
        public System.Windows.Forms.ColumnHeader startInt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox runCountCB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox HtmlURLTB;
    }
}

