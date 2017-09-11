namespace ManaBot
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.scChat = new System.Windows.Forms.SplitContainer();
            this.scChatting = new System.Windows.Forms.SplitContainer();
            this.lbViewerList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChat)).BeginInit();
            this.scChat.Panel2.SuspendLayout();
            this.scChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChatting)).BeginInit();
            this.scChatting.Panel1.SuspendLayout();
            this.scChatting.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 561);
            this.splitContainer1.SplitterDistance = 520;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.scChatting);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat Window";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // scChat
            // 
            this.scChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scChat.Location = new System.Drawing.Point(0, 0);
            this.scChat.Name = "scChat";
            // 
            // scChat.Panel2
            // 
            this.scChat.Panel2.Controls.Add(this.lbViewerList);
            this.scChat.Size = new System.Drawing.Size(970, 449);
            this.scChat.SplitterDistance = 750;
            this.scChat.TabIndex = 0;
            // 
            // scChatting
            // 
            this.scChatting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scChatting.Location = new System.Drawing.Point(3, 3);
            this.scChatting.Name = "scChatting";
            this.scChatting.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scChatting.Panel1
            // 
            this.scChatting.Panel1.Controls.Add(this.scChat);
            this.scChatting.Size = new System.Drawing.Size(970, 488);
            this.scChatting.SplitterDistance = 449;
            this.scChatting.TabIndex = 1;
            // 
            // lbViewerList
            // 
            this.lbViewerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbViewerList.FormattingEnabled = true;
            this.lbViewerList.Location = new System.Drawing.Point(0, 0);
            this.lbViewerList.Name = "lbViewerList";
            this.lbViewerList.Size = new System.Drawing.Size(216, 449);
            this.lbViewerList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.scChat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChat)).EndInit();
            this.scChat.ResumeLayout(false);
            this.scChatting.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChatting)).EndInit();
            this.scChatting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer scChat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer scChatting;
        private System.Windows.Forms.ListBox lbViewerList;
    }
}

