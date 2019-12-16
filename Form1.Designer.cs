﻿namespace GameLinesEditor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("New Project");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new ScintillaNET.Scintilla();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.WorkingAreaSplitContainer = new System.Windows.Forms.SplitContainer();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.explorerSwitch = new System.Windows.Forms.Button();
            this.toolBoxSpliter = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TemplatePage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingAreaSplitContainer)).BeginInit();
            this.WorkingAreaSplitContainer.Panel1.SuspendLayout();
            this.WorkingAreaSplitContainer.Panel2.SuspendLayout();
            this.WorkingAreaSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxSpliter)).BeginInit();
            this.toolBoxSpliter.Panel1.SuspendLayout();
            this.toolBoxSpliter.Panel2.SuspendLayout();
            this.toolBoxSpliter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TemplatePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem4,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem3.Text = "New";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem4.Text = "Export  Current";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenceToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "&Settings";
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.preferenceToolStripMenuItem.Text = "Preference";
            this.preferenceToolStripMenuItem.Click += new System.EventHandler(this.preferenceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugOpenToolStripMenuItem,
            this.debugSaveToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // debugOpenToolStripMenuItem
            // 
            this.debugOpenToolStripMenuItem.Name = "debugOpenToolStripMenuItem";
            this.debugOpenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.debugOpenToolStripMenuItem.Text = "Debug Open";
            this.debugOpenToolStripMenuItem.Visible = false;
            // 
            // debugSaveToolStripMenuItem
            // 
            this.debugSaveToolStripMenuItem.Name = "debugSaveToolStripMenuItem";
            this.debugSaveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.debugSaveToolStripMenuItem.Text = "Debug Save";
            this.debugSaveToolStripMenuItem.Visible = false;
            this.debugSaveToolStripMenuItem.Click += new System.EventHandler(this.debugSaveToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.debugToolStripMenuItem.Text = "Random Debug button";
            this.debugToolStripMenuItem.Visible = false;
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Lexer = ScintillaNET.Lexer.Null;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollWidth = 1;
            this.richTextBox1.Size = new System.Drawing.Size(981, 507);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.ToolTipText = "Status";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Silver;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "New Project";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(153, 533);
            this.treeView1.TabIndex = 6;
            // 
            // WorkingAreaSplitContainer
            // 
            this.WorkingAreaSplitContainer.BackColor = System.Drawing.Color.Silver;
            this.WorkingAreaSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingAreaSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.WorkingAreaSplitContainer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.WorkingAreaSplitContainer.Name = "WorkingAreaSplitContainer";
            // 
            // WorkingAreaSplitContainer.Panel1
            // 
            this.WorkingAreaSplitContainer.Panel1.Controls.Add(this.treeView1);
            this.WorkingAreaSplitContainer.Panel1Collapsed = true;
            // 
            // WorkingAreaSplitContainer.Panel2
            // 
            this.WorkingAreaSplitContainer.Panel2.Controls.Add(this.tabControl1);
            this.WorkingAreaSplitContainer.Size = new System.Drawing.Size(989, 533);
            this.WorkingAreaSplitContainer.SplitterDistance = 153;
            this.WorkingAreaSplitContainer.TabIndex = 7;
            // 
            // explorerSwitch
            // 
            this.explorerSwitch.AccessibleDescription = "Project Explorer";
            this.explorerSwitch.BackColor = System.Drawing.Color.DarkGray;
            this.explorerSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("explorerSwitch.BackgroundImage")));
            this.explorerSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.explorerSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.explorerSwitch.FlatAppearance.BorderSize = 0;
            this.explorerSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explorerSwitch.Location = new System.Drawing.Point(4, 3);
            this.explorerSwitch.Name = "explorerSwitch";
            this.explorerSwitch.Padding = new System.Windows.Forms.Padding(5);
            this.explorerSwitch.Size = new System.Drawing.Size(22, 36);
            this.explorerSwitch.TabIndex = 0;
            this.toolTip1.SetToolTip(this.explorerSwitch, "Toogle Project Explorer");
            this.explorerSwitch.UseVisualStyleBackColor = false;
            this.explorerSwitch.Click += new System.EventHandler(this.explorerSwitch_Click);
            // 
            // toolBoxSpliter
            // 
            this.toolBoxSpliter.BackColor = System.Drawing.Color.DarkGray;
            this.toolBoxSpliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBoxSpliter.IsSplitterFixed = true;
            this.toolBoxSpliter.Location = new System.Drawing.Point(0, 24);
            this.toolBoxSpliter.Name = "toolBoxSpliter";
            // 
            // toolBoxSpliter.Panel1
            // 
            this.toolBoxSpliter.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.toolBoxSpliter.Panel1.Controls.Add(this.explorerSwitch);
            this.toolBoxSpliter.Panel1.Margin = new System.Windows.Forms.Padding(5);
            this.toolBoxSpliter.Panel1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolTip1.SetToolTip(this.toolBoxSpliter.Panel1, "ToolBox");
            // 
            // toolBoxSpliter.Panel2
            // 
            this.toolBoxSpliter.Panel2.Controls.Add(this.WorkingAreaSplitContainer);
            this.toolBoxSpliter.Size = new System.Drawing.Size(1020, 533);
            this.toolBoxSpliter.SplitterDistance = 30;
            this.toolBoxSpliter.SplitterWidth = 1;
            this.toolBoxSpliter.TabIndex = 8;
            this.toolBoxSpliter.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TemplatePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 533);
            this.tabControl1.TabIndex = 5;
            // 
            // TemplatePage
            // 
            this.TemplatePage.Controls.Add(this.richTextBox1);
            this.TemplatePage.Location = new System.Drawing.Point(4, 22);
            this.TemplatePage.Margin = new System.Windows.Forms.Padding(0);
            this.TemplatePage.Name = "TemplatePage";
            this.TemplatePage.Size = new System.Drawing.Size(981, 507);
            this.TemplatePage.TabIndex = 0;
            this.TemplatePage.Text = "New File";
            this.TemplatePage.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 579);
            this.Controls.Add(this.toolBoxSpliter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleVisualNovelEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.WorkingAreaSplitContainer.Panel1.ResumeLayout(false);
            this.WorkingAreaSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkingAreaSplitContainer)).EndInit();
            this.WorkingAreaSplitContainer.ResumeLayout(false);
            this.toolBoxSpliter.Panel1.ResumeLayout(false);
            this.toolBoxSpliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxSpliter)).EndInit();
            this.toolBoxSpliter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TemplatePage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem debugSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem debugOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private ScintillaNET.Scintilla richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer WorkingAreaSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.Timer autoSaveTimer;
        private System.Windows.Forms.Button explorerSwitch;
        private System.Windows.Forms.SplitContainer toolBoxSpliter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TemplatePage;
    }
}

