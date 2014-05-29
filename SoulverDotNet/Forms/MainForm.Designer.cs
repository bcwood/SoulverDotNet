namespace SoulverDotNet.Forms
{
    partial class MainForm
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
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.splitContainerInner = new System.Windows.Forms.SplitContainer();
			this.txtLineNumbers = new System.Windows.Forms.TextBox();
			this.txtQuestions = new System.Windows.Forms.TextBox();
			this.txtAnswers = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).BeginInit();
			this.splitContainerInner.Panel1.SuspendLayout();
			this.splitContainerInner.Panel2.SuspendLayout();
			this.splitContainerInner.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 24);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.splitContainerInner);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.txtAnswers);
			this.splitContainer.Size = new System.Drawing.Size(519, 463);
			this.splitContainer.SplitterDistance = 287;
			this.splitContainer.TabIndex = 0;
			this.splitContainer.TabStop = false;
			// 
			// splitContainerInner
			// 
			this.splitContainerInner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerInner.Location = new System.Drawing.Point(0, 0);
			this.splitContainerInner.Name = "splitContainerInner";
			// 
			// splitContainerInner.Panel1
			// 
			this.splitContainerInner.Panel1.Controls.Add(this.txtLineNumbers);
			this.splitContainerInner.Panel1MinSize = 5;
			// 
			// splitContainerInner.Panel2
			// 
			this.splitContainerInner.Panel2.Controls.Add(this.txtQuestions);
			this.splitContainerInner.Size = new System.Drawing.Size(287, 463);
			this.splitContainerInner.SplitterDistance = 25;
			this.splitContainerInner.TabIndex = 2;
			this.splitContainerInner.TabStop = false;
			// 
			// txtLineNumbers
			// 
			this.txtLineNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLineNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLineNumbers.Enabled = false;
			this.txtLineNumbers.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLineNumbers.Location = new System.Drawing.Point(0, 0);
			this.txtLineNumbers.Multiline = true;
			this.txtLineNumbers.Name = "txtLineNumbers";
			this.txtLineNumbers.ReadOnly = true;
			this.txtLineNumbers.Size = new System.Drawing.Size(25, 463);
			this.txtLineNumbers.TabIndex = 0;
			this.txtLineNumbers.TabStop = false;
			// 
			// txtQuestions
			// 
			this.txtQuestions.AcceptsReturn = true;
			this.txtQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtQuestions.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuestions.Location = new System.Drawing.Point(0, 0);
			this.txtQuestions.Multiline = true;
			this.txtQuestions.Name = "txtQuestions";
			this.txtQuestions.Size = new System.Drawing.Size(258, 463);
			this.txtQuestions.TabIndex = 0;
			this.txtQuestions.TextChanged += new System.EventHandler(this.txtQuestions_TextChanged);
			// 
			// txtAnswers
			// 
			this.txtAnswers.AcceptsReturn = true;
			this.txtAnswers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAnswers.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswers.Location = new System.Drawing.Point(0, 0);
			this.txtAnswers.Multiline = true;
			this.txtAnswers.Name = "txtAnswers";
			this.txtAnswers.ReadOnly = true;
			this.txtAnswers.Size = new System.Drawing.Size(228, 463);
			this.txtAnswers.TabIndex = 2;
			this.txtAnswers.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(519, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "File";
			// 
			// newMenuItem
			// 
			this.newMenuItem.Name = "newMenuItem";
			this.newMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newMenuItem.Text = "New";
			this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitMenuItem.Text = "Exit";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(44, 20);
			this.helpMenu.Text = "Help";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutMenuItem.Text = "About...";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 487);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Soulver.NET";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.splitContainerInner.Panel1.ResumeLayout(false);
			this.splitContainerInner.Panel1.PerformLayout();
			this.splitContainerInner.Panel2.ResumeLayout(false);
			this.splitContainerInner.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).EndInit();
			this.splitContainerInner.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox txtQuestions;
        private System.Windows.Forms.TextBox txtAnswers;
        private System.Windows.Forms.SplitContainer splitContainerInner;
        private System.Windows.Forms.TextBox txtLineNumbers;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem newMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenu;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}