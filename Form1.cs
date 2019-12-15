﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GameLinesEditor
{
    public partial class MainWindow : Form
    {
        private SettingsManager Sett_Man;
        private String filePath; // path of the file that is currently working on

        private String zoomConfig = Application.StartupPath + @"\" + "Zoom"; // file that save zoom number
        
        private const bool DEBUGMODE = false;// debug mode switch

        private SceneObj sceneMan;

        private const String SOFTWARENAME = " -VisualNovelEditor";

        public MainWindow()
        {
            InitializeComponent();
            this.Sett_Man = new SettingsManager(Application.StartupPath);
            richTextBox1.Font = new Font("Tahoma", Sett_Man.settingRecorder.Size, FontStyle.Bold);
            // init scene obj
            this.sceneMan = new SceneObj();
            // init scintilla
            this.richTextBox1.Margins[0].Width = 30;
            int zoom = 1;
            try
            {
                String zoomNumberInString = System.IO.File.ReadAllText(zoomConfig);
                Int32.TryParse(zoomNumberInString, out zoom);
                richTextBox1.Zoom = zoom;
            }
            catch { }
            richTextBox1.ClearCmdKey(Keys.Control | Keys.S);
            // debug mode
            if (DEBUGMODE)
            {
                debugOpenToolStripMenuItem.Visible = true;
                debugSaveToolStripMenuItem.Visible = true;
                toolStripSeparator3.Visible = true;
                debugToolStripMenuItem.Visible = true;
            }
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Sett = new Settings(this,Sett_Man);
            Sett.Show();
            this.Enabled = false;
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        
        // needs debug
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsFile();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
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
            return richTextBox1.LineFromPosition(richTextBox1.CurrentPosition);
        }

        // process line with given line number and add it to sceneObj's list
        private void processLine(int lineNumber)
        {
           
            

        }

        // shortcut keys
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control )
            {
                switch (e.KeyCode)
                {
                    case Keys.O:
                        openFile();
                        break;
                    case Keys.S:
                        saveFile();
                        break;
                    case Keys.D0:
                        richTextBox1.Zoom = 1;
                        break;
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void saveFile()
        {
            if (this.filePath == null || this.filePath == "")
            {
                saveAsFile();
            }
            else
            {
                System.IO.File.WriteAllText(this.filePath, richTextBox1.Text);
            }
        }

        private void saveAsFile() 
        {
            saveFileDialog1.Filter = "Visual Novel Script(*.plot) | *.plot";
            saveFileDialog1.FileName = String.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(this.filePath, richTextBox1.Text);
            }
        }

        private void openFile()
        {
            openFileDialog1.Filter = "Visual Novel Script(*.plot) | *.plot";
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
                this.Text = this.filePath + SOFTWARENAME;
                this.richTextBox1.Text = System.IO.File.ReadAllText(this.filePath);
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            int zoomSize = richTextBox1.Zoom;
            try
            {
                System.IO.File.Delete(zoomConfig);
                System.IO.File.WriteAllText(zoomConfig, "" + zoomSize);
            }
            catch { }
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
           
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(this.filePath,textAnalizer.ConvertToJson(richTextBox1));
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 32)
            {
                e.Handled = true;
            }
        }
    }
}
