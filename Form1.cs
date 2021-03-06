﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;
using AutocompleteMenuNS;


namespace GameLinesEditor
{
    public partial class MainWindow : Form
    {
        private String projectFilePath; // path of the file that is currently working on

        private String zoomConfig = Application.StartupPath + @"\" + "Zoom"; // file that save zoom number
        
        private const bool DEBUGMODE = true;// debug mode switch

        public String currentSettings = Application.StartupPath + "\\" + "Settings"; // file that save the mode

        

        public TreeView treeView1Pointer;
        private int maxLineNumberCharLength = 1;
        private const int TOOLBOXWIDTHCONST = 25;
        private int TOOLBOXWIDTH;
        private ProjectObj projectMan;

        private Dictionary<String, Scintilla> plotToTabDict = new Dictionary<string, Scintilla>();

        private int textBoxZoom = 1;


        public MainWindow()
        {
            InitializeComponent();
            // set toolbox width
            TOOLBOXWIDTH = this.Width / TOOLBOXWIDTHCONST;
            resizeToolBoxSpliter();
            this.treeView1Pointer = this.treeView1;
            // maximize mode bound
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            // debug mode
            if (DEBUGMODE)
            {
                toolStripSeparator3.Visible = true;
                debugToolStripMenuItem.Visible = true;
            }
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
            try
            {
                updateTreeView();
            }
            catch { }
            
        }
        #region workingAreaEnableDisableHelper
        private void setWorkingArea(bool sta)
        {
            this.toolBoxSpliter.Enabled = sta;
            this.ProjectStripMenuItem.Enabled = sta;
            this.saveToolStripMenuItem.Enabled = sta;
            this.saveAsToolStripMenuItem.Enabled = sta;
        }
        #endregion


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
            updateTreeView();
        }
        
        // needs debug
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsDialog = new SaveFileDialog();
            saveAsDialog.Filter = "Visual Novel Project(*.vnp) | *.vnp";
            saveAsDialog.FileName = String.Empty;
            saveAsDialog.Title = "";
            if (saveAsDialog.ShowDialog() == DialogResult.OK)
            {
                this.projectFilePath = saveAsDialog.FileName;
                saveFile();
                updateTreeView();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // debug
        private void debugSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private int getCurrentLineNumber() {
            //return richTextBox1.LineFromPosition(richTextBox1.CurrentPosition);
            int result = 0;
            return result;
        }

        // shortcut keys
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control )
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                       // richTextBox1.Zoom = 1;
                        break;
                }
                
            }
        }


        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 32)
            {
                e.Handled = true;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.statusLable.Text = "Procesing"; // change status bar text
            //exportFile(this.richTextBox1);            
            this.statusLable.Text = "Ready"; // Change back status bar text
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form preference = new Settings(this);
            this.Enabled = false;
            preference.Show();
        }

        private void explorerSwitch_Click(object sender, EventArgs e)
        {
            this.WorkingAreaSplitContainer.Panel1Collapsed = !this.WorkingAreaSplitContainer.Panel1Collapsed;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            resizeToolBoxSpliter();
        }

        private void resizeToolBoxSpliter()
        {
            this.toolBoxSpliter.SplitterDistance = TOOLBOXWIDTH;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            // String openPath = e.Data();
        }





        // Update the width of line number indicatior
        private void textBoxLineNumberWidthAdapt(Object sender, EventArgs e)
        {
            Scintilla textBox = (Scintilla)sender;
            var maxLineNumberCharLength = textBox.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;
            textBox.Margins[0].Width = textBox.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + 3;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void exportProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.projectMan != null)
            {
                this.statusLable.Text = "Processing";
                this.MainFormProgressBar.Value = 0;
                this.MainFormProgressBar.Visible = true;
                this.MainFormProgressBar.Value = 20;
                if (projectMan.firstPlot == String.Empty || !projectMan.plotList.Contains(projectMan.firstPlot))
                {
                    Form projectProperty = new FirstPlot(this.projectMan.plotList, this.projectMan.firstPlot);
                    if (projectProperty.ShowDialog() == DialogResult.OK)
                    {
                        saveFile();
                        export();
                    }
                    else
                    {
                        MessageBox.Show("You didn't set which Plot should be played first.", "What are you doing????", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    export();
                    MessageBox.Show("ExportSuccess","Export Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                this.MainFormProgressBar.Value = 100;
                this.statusLable.Text = "Ready";
                this.MainFormProgressBar.Visible = false;
            }
        }

        private void export()
        {
            saveFile();
            String exportPath = Path.GetDirectoryName(this.projectFilePath) + @"\" + @"Release\";
            System.IO.Directory.CreateDirectory(exportPath);
            // export property File
            System.IO.File.WriteAllText(exportPath + "index.info", this.projectMan.firstPlot);
            // export all plot
            foreach (String plot in this.projectMan.plotList)
            {
                Scintilla textBox;
                this.plotToTabDict.TryGetValue(plot, out textBox);
                String jsonOutPut = textAnalizer.ConvertToJson(textBox);
                System.IO.File.WriteAllText(exportPath + plot + @".json", jsonOutPut);
            }
        }

        private void addNewPlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.projectMan != null)
            {
                newPlot newPlotNameForm = new newPlot(this);
                newPlotNameForm.ShowDialog();
                if (newPlotNameForm.DialogResult == DialogResult.OK)
                {
                    String plotName = newPlotNameForm.plotName;
                    if (this.projectMan.firstPlot == null || 
                        this.projectMan.firstPlot == String.Empty ||
                        !this.projectMan.plotList.Contains(this.projectMan.firstPlot))
                    {
                        this.projectMan.firstPlot = plotName;
                    }
                    Scintilla plotPage = newTab(plotName);
                    projectMan.plotList.Add(plotName);
                    this.plotToTabDict.Add(plotName, plotPage);
                    updateTreeView();
                    saveFile();
                }
            }
        }



        #region FileControlHelper
        private void createNewProjectFile(String filePath)
        {
            String projectName = Path.GetFileNameWithoutExtension(filePath);
            this.projectMan = new ProjectObj(projectName,new List<String>(), new Dictionary<String, Dictionary<String, String>>());
            this.projectMan.characterList.Add("Game", new Dictionary<string, string>());
            System.IO.File.WriteAllText(filePath, projectMan.returnJson());
        }

        private void saveFile()
        {
            System.IO.File.WriteAllText(this.projectFilePath, this.projectMan.returnJson());
            foreach (String plot in projectMan.plotList)
            {
                Scintilla textBox;
                plotToTabDict.TryGetValue(plot,out textBox);
                String PlotPath = Path.GetDirectoryName(this.projectFilePath);
                PlotPath = PlotPath + @"\" + plot + ".plot";
                System.IO.File.WriteAllText(PlotPath,textBox.Text);
            }
        }

        private void saveAs()
        {
            
        }


        private void openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Visual Novel Project(*.vnp) | *.vnp";
            openFileDialog1.FileName = String.Empty;
            workingAreaTabControl.TabPages.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
        }

        private void openFile(String filePath)
        {
            String projectFilePathTemp = filePath;
            this.projectFilePath = projectFilePathTemp;
            this.projectMan = projectReader.readProjectObjFromJson(System.IO.File.ReadAllText(projectFilePathTemp));
            plotToTabDict = new Dictionary<string, Scintilla>();
            foreach (String plot in projectMan.plotList)
            {
                Scintilla textBox = newTab(plot);
                plotToTabDict.Add(plot, textBox);
                String PlotPath = Path.GetDirectoryName(this.projectFilePath);
                PlotPath = PlotPath + @"\" + plot + ".plot";
                textBox.Text = System.IO.File.ReadAllText(PlotPath);
            }
            setWorkingArea(true);
        }
        #endregion

        private void updateTreeView()
        {
            try
            {
                this.treeView1.Nodes.RemoveAt(0);
            }catch { }
            TreeNode projectParentNode = new TreeNode(this.projectMan.projName);
            this.Text = this.projectMan.projName + "-SimpleVisualNovelEditor";
            foreach (String plot in projectMan.plotList)
            {
                projectParentNode.Nodes.Add(plot);
            }
            this.treeView1.Nodes.Add(projectParentNode);
        }
        #region TabControlHelper
        // Create a new tab in tabcontrol with givien title
        private Scintilla newTab(String tabName)
        {
            TabPage tb = new TabPage(tabName);
            Scintilla textBox = new Scintilla();
            // init textBox
            textBox.Margins[0].Type = MarginType.Number;
            textBox.Margins[0].Width = 30;
            textBox.Margins[1].Type = MarginType.ForeColor;
            textBox.Styles[Style.Default].ForeColor = Color.White;
            textBox.Margins[1].Width = 1;
            textBox.Dock = DockStyle.Fill;
            textBox.BorderStyle = BorderStyle.None;
            textBox.ScrollWidth = 1;
            textBox.TextChanged += new System.EventHandler(this.textBoxLineNumberWidthAdapt);
            textBox.Zoom = this.textBoxZoom;
            // add auto complete

            // init page
            tb.BackColor = Color.Silver;
            tb.UseVisualStyleBackColor = true;
            // Add to page 
            tb.Controls.Add(textBox);
            // Add page to tabcontrol
            this.workingAreaTabControl.TabPages.Add(tb);
            return textBox;
        }

        // toogle visibility of tabcontrol when there's no page or there is page
        private void workingAreaTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            if (this.workingAreaTabControl.TabPages.Count > 0)
            {
                workingAreaTabControl.Visible = true;
            }
            else
            {
                workingAreaTabControl.Visible = false;
            }
        }
        #endregion

        private void newProjectMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog newProjectDialog = new SaveFileDialog();
            newProjectDialog.Filter = "Visual Novel Project(*.vnp) | *.vnp";
            newProjectDialog.FileName = "";
            newProjectDialog.AddExtension = true;
            newProjectDialog.Title = "New Project";
            if (newProjectDialog.ShowDialog() == DialogResult.OK)
            {
                createNewProjectFile(newProjectDialog.FileName);
                setWorkingArea(true);
                this.projectFilePath = newProjectDialog.FileName;
                updateTreeView();
                openFile(newProjectDialog.FileName);
                String resourcePath = Path.GetDirectoryName(this.projectFilePath) + @"\" + @"Resources\";
                System.IO.Directory.CreateDirectory(resourcePath);
            }
        }

        private void MainWindow_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.D1:
                        explorerSwitch_Click(sender, e);
                        break;
                    case Keys.Tab:
                        //this.workingAreaTabControl.SelectNextControl();
                        break;
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #region borderless window add resize and move function
        private void titleBarLayoutPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        // source : https://stackoverflow.com/questions/1241812/how-to-move-a-windows-form-when-its-formborderstyle-property-is-set-to-none

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void titleBarLayoutPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void titleBarLayoutPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void titleBarLayoutPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }



        #endregion

        private void projectSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPlot projectPropertySettingWindow = new FirstPlot(this.projectMan.plotList, this.projectMan.firstPlot);
            if(projectPropertySettingWindow.ShowDialog() == DialogResult.OK)
            {
                this.projectMan.firstPlot = projectPropertySettingWindow.firstPlotNameInPropertyWindow;
                saveFile();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);
        }

        private void importResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog importRes = new OpenFileDialog();
            importRes.InitialDirectory = this.projectFilePath;
            if(importRes.ShowDialog() == DialogResult.OK)
            {
                String FilePath = importRes.FileName; // absolute path of the imported file
                String FileName = Path.GetFileName(FilePath); // file name of the imported file(with extension)
                String resPath = Path.GetDirectoryName(this.projectFilePath) + @"\" + @"Resources\"; // get absolute path of the resources folder
                ImportResources importDialog = new ImportResources(FileName, this.projectMan.characterList.Keys.ToArray<String>());
                if (importDialog.ShowDialog() == DialogResult.OK)
                {
                    Dictionary<String, String> CharacterFileList;
                    this.projectMan.characterList.TryGetValue(importDialog.CharacterName,out CharacterFileList);
                    CharacterFileList.Add(importDialog.nickName, importDialog.fileName);
                    System.IO.File.Copy(FilePath, resPath + FileName);
                }
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.projectMan != null)
            {
                exportProjectToolStripMenuItem_Click(sender, e);
                // debug from release data
                Form debugPlayer = new DebugPlayer(Path.GetDirectoryName(this.projectFilePath) + @"\" + @"Release\");
                debugPlayer.ShowDialog();
            }
        }

        private void buildGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gameCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterManagement cm = new CharacterManagement();
            cm.ShowDialog();
        }

        private void resouresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourcesSettings rs = new ResourcesSettings(this.projectMan.characterList);
            rs.ShowDialog();
        }
    }
}
