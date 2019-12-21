namespace GameLinesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.WorkingAreaSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.workingAreaTabControl = new System.Windows.Forms.TabControl();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.explorerSwitch = new System.Windows.Forms.Button();
            this.toolBoxSpliter = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.titleBarLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.windowLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gameCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingAreaSplitContainer)).BeginInit();
            this.WorkingAreaSplitContainer.Panel1.SuspendLayout();
            this.WorkingAreaSplitContainer.Panel2.SuspendLayout();
            this.WorkingAreaSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxSpliter)).BeginInit();
            this.toolBoxSpliter.Panel1.SuspendLayout();
            this.toolBoxSpliter.Panel2.SuspendLayout();
            this.toolBoxSpliter.SuspendLayout();
            this.titleBarLayoutPanel.SuspendLayout();
            this.windowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ProjectStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.teamToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(204, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectMenuItem3,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 28);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newProjectMenuItem3
            // 
            this.newProjectMenuItem3.Name = "newProjectMenuItem3";
            this.newProjectMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProjectMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.newProjectMenuItem3.Text = "New Project";
            this.newProjectMenuItem3.Click += new System.EventHandler(this.newProjectMenuItem3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open Project";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save Project";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ProjectStripMenuItem
            // 
            this.ProjectStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importResourcesToolStripMenuItem,
            this.projectSettingsToolStripMenuItem,
            this.gameCharacterToolStripMenuItem,
            this.addNewPlotToolStripMenuItem,
            this.toolStripSeparator1,
            this.runToolStripMenuItem,
            this.exportProjectToolStripMenuItem,
            this.buildGameToolStripMenuItem});
            this.ProjectStripMenuItem.Enabled = false;
            this.ProjectStripMenuItem.Name = "ProjectStripMenuItem";
            this.ProjectStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.ProjectStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.ProjectStripMenuItem.Text = "&Project";
            // 
            // importResourcesToolStripMenuItem
            // 
            this.importResourcesToolStripMenuItem.Name = "importResourcesToolStripMenuItem";
            this.importResourcesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importResourcesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.importResourcesToolStripMenuItem.Text = "Import Resources";
            this.importResourcesToolStripMenuItem.Click += new System.EventHandler(this.importResourcesToolStripMenuItem_Click);
            // 
            // projectSettingsToolStripMenuItem
            // 
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.projectSettingsToolStripMenuItem.Text = "Set First Plot";
            this.projectSettingsToolStripMenuItem.Click += new System.EventHandler(this.projectSettingsToolStripMenuItem_Click);
            // 
            // addNewPlotToolStripMenuItem
            // 
            this.addNewPlotToolStripMenuItem.Name = "addNewPlotToolStripMenuItem";
            this.addNewPlotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.addNewPlotToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addNewPlotToolStripMenuItem.Text = "Add New Plot";
            this.addNewPlotToolStripMenuItem.Click += new System.EventHandler(this.addNewPlotToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.runToolStripMenuItem.Text = "Start Debugging";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // exportProjectToolStripMenuItem
            // 
            this.exportProjectToolStripMenuItem.Name = "exportProjectToolStripMenuItem";
            this.exportProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportProjectToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exportProjectToolStripMenuItem.Text = "Export";
            this.exportProjectToolStripMenuItem.Click += new System.EventHandler(this.exportProjectToolStripMenuItem_Click);
            // 
            // buildGameToolStripMenuItem
            // 
            this.buildGameToolStripMenuItem.Name = "buildGameToolStripMenuItem";
            this.buildGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buildGameToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buildGameToolStripMenuItem.Text = "Build Game";
            this.buildGameToolStripMenuItem.Visible = false;
            this.buildGameToolStripMenuItem.Click += new System.EventHandler(this.buildGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 28);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenceToolStripMenuItem});
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 28);
            this.toolStripMenuItem1.Text = "&Settings";
            this.toolStripMenuItem1.Visible = false;
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.preferenceToolStripMenuItem.Text = "Preference";
            this.preferenceToolStripMenuItem.Click += new System.EventHandler(this.preferenceToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(47, 28);
            this.teamToolStripMenuItem.Text = "&Team";
            this.teamToolStripMenuItem.Visible = false;
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.gitToolStripMenuItem.Text = "Git";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLable,
            this.MainFormProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLable
            // 
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(39, 17);
            this.statusLable.Text = "Ready";
            this.statusLable.ToolTipText = "Status";
            // 
            // MainFormProgressBar
            // 
            this.MainFormProgressBar.Name = "MainFormProgressBar";
            this.MainFormProgressBar.Size = new System.Drawing.Size(100, 16);
            this.MainFormProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.MainFormProgressBar.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Silver;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(100, 100);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.WorkingAreaSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.WorkingAreaSplitContainer.Size = new System.Drawing.Size(860, 464);
            this.WorkingAreaSplitContainer.SplitterDistance = 100;
            this.WorkingAreaSplitContainer.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.workingAreaTabControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 464);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // workingAreaTabControl
            // 
            this.workingAreaTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workingAreaTabControl.Location = new System.Drawing.Point(3, 3);
            this.workingAreaTabControl.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.workingAreaTabControl.Name = "workingAreaTabControl";
            this.workingAreaTabControl.SelectedIndex = 0;
            this.workingAreaTabControl.Size = new System.Drawing.Size(852, 458);
            this.workingAreaTabControl.TabIndex = 6;
            this.workingAreaTabControl.Visible = false;
            this.workingAreaTabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.workingAreaTabControl_ControlAdded);
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
            this.explorerSwitch.Size = new System.Drawing.Size(22, 37);
            this.explorerSwitch.TabIndex = 0;
            this.explorerSwitch.TabStop = false;
            this.toolTip1.SetToolTip(this.explorerSwitch, "Toogle Project Explorer (Ctrl + 1)");
            this.explorerSwitch.UseVisualStyleBackColor = true;
            this.explorerSwitch.Click += new System.EventHandler(this.explorerSwitch_Click);
            // 
            // toolBoxSpliter
            // 
            this.toolBoxSpliter.BackColor = System.Drawing.Color.DarkGray;
            this.toolBoxSpliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBoxSpliter.Enabled = false;
            this.toolBoxSpliter.IsSplitterFixed = true;
            this.toolBoxSpliter.Location = new System.Drawing.Point(3, 33);
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
            this.toolBoxSpliter.Size = new System.Drawing.Size(891, 464);
            this.toolBoxSpliter.SplitterDistance = 30;
            this.toolBoxSpliter.SplitterWidth = 1;
            this.toolBoxSpliter.TabIndex = 8;
            this.toolBoxSpliter.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(838, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleBarLayoutPanel
            // 
            this.titleBarLayoutPanel.ColumnCount = 5;
            this.titleBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.61394F));
            this.titleBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.38606F));
            this.titleBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.titleBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.titleBarLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.titleBarLayoutPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.titleBarLayoutPanel.Controls.Add(this.button1, 4, 0);
            this.titleBarLayoutPanel.Controls.Add(this.MaximizeButton, 3, 0);
            this.titleBarLayoutPanel.Controls.Add(this.MinimizeButton, 2, 0);
            this.titleBarLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.titleBarLayoutPanel.Name = "titleBarLayoutPanel";
            this.titleBarLayoutPanel.RowCount = 1;
            this.titleBarLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleBarLayoutPanel.Size = new System.Drawing.Size(897, 30);
            this.titleBarLayoutPanel.TabIndex = 8;
            this.titleBarLayoutPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.titleBarLayoutPanel_MouseDoubleClick);
            this.titleBarLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarLayoutPanel_MouseDown);
            this.titleBarLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBarLayoutPanel_MouseMove);
            this.titleBarLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBarLayoutPanel_MouseUp);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackColor = System.Drawing.Color.DarkGray;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Location = new System.Drawing.Point(788, 0);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(50, 30);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.Text = "M";
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Visible = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(738, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(50, 30);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Visible = false;
            this.MinimizeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // windowLayoutPanel2
            // 
            this.windowLayoutPanel2.ColumnCount = 1;
            this.windowLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.windowLayoutPanel2.Controls.Add(this.toolBoxSpliter, 0, 1);
            this.windowLayoutPanel2.Controls.Add(this.titleBarLayoutPanel, 0, 0);
            this.windowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.windowLayoutPanel2.Name = "windowLayoutPanel2";
            this.windowLayoutPanel2.RowCount = 2;
            this.windowLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.windowLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.windowLayoutPanel2.Size = new System.Drawing.Size(897, 500);
            this.windowLayoutPanel2.TabIndex = 9;
            // 
            // gameCharacterToolStripMenuItem
            // 
            this.gameCharacterToolStripMenuItem.Name = "gameCharacterToolStripMenuItem";
            this.gameCharacterToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.gameCharacterToolStripMenuItem.Text = "GameCharacter";
            this.gameCharacterToolStripMenuItem.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(897, 522);
            this.Controls.Add(this.windowLayoutPanel2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(398, 403);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleVisualNovelEditor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown_1);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.WorkingAreaSplitContainer.Panel1.ResumeLayout(false);
            this.WorkingAreaSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkingAreaSplitContainer)).EndInit();
            this.WorkingAreaSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolBoxSpliter.Panel1.ResumeLayout(false);
            this.toolBoxSpliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxSpliter)).EndInit();
            this.toolBoxSpliter.ResumeLayout(false);
            this.titleBarLayoutPanel.ResumeLayout(false);
            this.titleBarLayoutPanel.PerformLayout();
            this.windowLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newProjectMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLable;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer WorkingAreaSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.Timer autoSaveTimer;
        private System.Windows.Forms.Button explorerSwitch;
        private System.Windows.Forms.SplitContainer toolBoxSpliter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl workingAreaTabControl;
        private System.Windows.Forms.ToolStripMenuItem ProjectStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel titleBarLayoutPanel;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TableLayoutPanel windowLayoutPanel2;
        private System.Windows.Forms.ToolStripProgressBar MainFormProgressBar;
        private System.Windows.Forms.ToolStripMenuItem importResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameCharacterToolStripMenuItem;
    }
}

