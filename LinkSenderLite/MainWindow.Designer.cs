namespace Chat
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Friends = new System.Windows.Forms.ListBox();
            this.MessageField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageTab = new System.Windows.Forms.TabControl();
            this.tabLinkIn = new System.Windows.Forms.TabPage();
            this.MessageView = new System.Windows.Forms.ListBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.addFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFriendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MessageTab.SuspendLayout();
            this.tabLinkIn.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Friends
            // 
            this.Friends.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Friends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Friends.FormattingEnabled = true;
            this.Friends.ItemHeight = 16;
            this.Friends.Location = new System.Drawing.Point(12, 58);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(95, 404);
            this.Friends.TabIndex = 0;
            this.Friends.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Friends_DrawItem);
            this.Friends.SelectedIndexChanged += new System.EventHandler(this.Friends_SelectedIndexChanged);
            // 
            // MessageField
            // 
            this.MessageField.Location = new System.Drawing.Point(124, 410);
            this.MessageField.Name = "MessageField";
            this.MessageField.Size = new System.Drawing.Size(476, 22);
            this.MessageField.TabIndex = 3;
            this.MessageField.TextChanged += new System.EventHandler(this.LinkField_TextChanged);
            this.MessageField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageField_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Send message:";
            // 
            // MessageTab
            // 
            this.MessageTab.Controls.Add(this.tabLinkIn);
            this.MessageTab.Controls.Add(this.tabPage1);
            this.MessageTab.Location = new System.Drawing.Point(124, 31);
            this.MessageTab.Name = "MessageTab";
            this.MessageTab.SelectedIndex = 0;
            this.MessageTab.Size = new System.Drawing.Size(480, 356);
            this.MessageTab.TabIndex = 5;
            // 
            // tabLinkIn
            // 
            this.tabLinkIn.Controls.Add(this.MessageView);
            this.tabLinkIn.Location = new System.Drawing.Point(4, 25);
            this.tabLinkIn.Name = "tabLinkIn";
            this.tabLinkIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabLinkIn.Size = new System.Drawing.Size(472, 327);
            this.tabLinkIn.TabIndex = 0;
            this.tabLinkIn.Text = "Dialogs";
            this.tabLinkIn.UseVisualStyleBackColor = true;
            // 
            // MessageView
            // 
            this.MessageView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MessageView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageView.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MessageView.FormattingEnabled = true;
            this.MessageView.ItemHeight = 16;
            this.MessageView.Location = new System.Drawing.Point(0, 4);
            this.MessageView.Name = "MessageView";
            this.MessageView.Size = new System.Drawing.Size(466, 320);
            this.MessageView.TabIndex = 0;
            this.MessageView.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MessageView_DrawItem);
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendBtn.Location = new System.Drawing.Point(513, 438);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(87, 29);
            this.SendBtn.TabIndex = 6;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // addFriendToolStripMenuItem
            // 
            this.addFriendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFriendToolStripMenuItem1,
            this.manageToolStripMenuItem});
            this.addFriendToolStripMenuItem.Name = "addFriendToolStripMenuItem";
            this.addFriendToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.addFriendToolStripMenuItem.Text = "Settings";
            // 
            // addFriendToolStripMenuItem1
            // 
            this.addFriendToolStripMenuItem1.Name = "addFriendToolStripMenuItem1";
            this.addFriendToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.addFriendToolStripMenuItem1.Text = "Add friend";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFriendToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Friends:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 327);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(616, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MessageTab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageField);
            this.Controls.Add(this.Friends);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.MessageTab.ResumeLayout(false);
            this.tabLinkIn.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Friends;
        private System.Windows.Forms.TextBox MessageField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl MessageTab;
        private System.Windows.Forms.TabPage tabLinkIn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFriendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox MessageView;
        private System.Windows.Forms.TabPage tabPage1;
    }
}