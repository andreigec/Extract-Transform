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
            this.urlTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.postTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deltaLogicLV = new System.Windows.Forms.ListView();
            this.getOrPostKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangeInt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startInt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.runCountCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label5 = new System.Windows.Forms.Label();
            this.goB = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.configbox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.waitTimeSeconds = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.configbox.SuspendLayout();
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
            // urlTB
            // 
            this.urlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTB.Location = new System.Drawing.Point(10, 49);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(422, 20);
            this.urlTB.TabIndex = 1;
            this.urlTB.Text = "https://api.spotify.com/v1/users/{skip}";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Post Values";
            // 
            // postTB
            // 
            this.postTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postTB.Location = new System.Drawing.Point(10, 99);
            this.postTB.Multiline = true;
            this.postTB.Name = "postTB";
            this.postTB.Size = new System.Drawing.Size(422, 68);
            this.postTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
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
            this.deltaLogicLV.Location = new System.Drawing.Point(10, 186);
            this.deltaLogicLV.Name = "deltaLogicLV";
            this.deltaLogicLV.Size = new System.Drawing.Size(422, 70);
            this.deltaLogicLV.TabIndex = 6;
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
            // runCountCB
            // 
            this.runCountCB.FormattingEnabled = true;
            this.runCountCB.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "Until Done"});
            this.runCountCB.Location = new System.Drawing.Point(10, 275);
            this.runCountCB.Name = "runCountCB";
            this.runCountCB.Size = new System.Drawing.Size(149, 21);
            this.runCountCB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Run Count";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Output name";
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
            // configbox
            // 
            this.configbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configbox.Controls.Add(this.label7);
            this.configbox.Controls.Add(this.waitTimeSeconds);
            this.configbox.Controls.Add(this.label1);
            this.configbox.Controls.Add(this.urlTB);
            this.configbox.Controls.Add(this.postTB);
            this.configbox.Controls.Add(this.label2);
            this.configbox.Controls.Add(this.label5);
            this.configbox.Controls.Add(this.label3);
            this.configbox.Controls.Add(this.deltaLogicLV);
            this.configbox.Controls.Add(this.label4);
            this.configbox.Controls.Add(this.runCountCB);
            this.configbox.Location = new System.Drawing.Point(5, 29);
            this.configbox.Name = "configbox";
            this.configbox.Size = new System.Drawing.Size(438, 348);
            this.configbox.TabIndex = 14;
            this.configbox.TabStop = false;
            this.configbox.Text = "Config";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
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
            this.waitTimeSeconds.Location = new System.Drawing.Point(181, 275);
            this.waitTimeSeconds.Name = "waitTimeSeconds";
            this.waitTimeSeconds.Size = new System.Drawing.Size(149, 21);
            this.waitTimeSeconds.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 685);
            this.Controls.Add(this.configbox);
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
            this.configbox.ResumeLayout(false);
            this.configbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TextBox urlTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox postTB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView deltaLogicLV;
		private System.Windows.Forms.ColumnHeader getOrPostKey;
		private System.Windows.Forms.ColumnHeader ChangeInt;
		private System.Windows.Forms.ColumnHeader startInt;
		private System.Windows.Forms.ComboBox runCountCB;
		private System.Windows.Forms.Label label4;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button goB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox outputTB;
		private System.Windows.Forms.GroupBox configbox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox waitTimeSeconds;
	}
}

