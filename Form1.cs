using System;
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


namespace GameLinesEditor
{
    public partial class MainWindow : Form
    {
        private String filePath; // path of the file that is currently working on

        private String zoomConfig = Application.StartupPath + @"\" + "Zoom"; // file that save zoom number
        
        private const bool DEBUGMODE = false;// debug mode switch

        public String currentSettings = Application.StartupPath + "\\" + "Settings"; // file that save the mode

        private const String SOFTWARENAME = " -VisualNovelEditor";
        public Scintilla richTextBox1Pointer;
        public TreeView treeView1Pointer;
        private int maxLineNumberCharLength;

        public MainWindow()
        {
            InitializeComponent();
            // init scintilla
            this.richTextBox1.Margins[0].Type = MarginType.Number;
            // Set line width
            this.richTextBox1.Margins[0].Width = 30;
            // Set the second margin as spliter between line number and actual text
            this.richTextBox1.Margins[1].Type = MarginType.ForeColor;
            this.richTextBox1.Styles[Style.Default].ForeColor = Color.Black;
            this.richTextBox1.Margins[1].Width = 1;
            
            int zoom = 1;
            try
            {
                String zoomNumberInString = System.IO.File.ReadAllText(zoomConfig);

                Int32.TryParse(zoomNumberInString, out zoom);
                richTextBox1.Zoom = zoom;
            }
            catch { }
            this.richTextBox1Pointer = richTextBox1;
            this.treeView1Pointer = this.treeView1;
            // debug mode
            if (DEBUGMODE)
            {
                debugOpenToolStripMenuItem.Visible = true;
                debugSaveToolStripMenuItem.Visible = true;
                toolStripSeparator3.Visible = true;
                debugToolStripMenuItem.Visible = true;
            }
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
            saveFileDialog1.Filter = "Visual Novel Script(*.plot) | *.plot" +
                "| Shitty FileExtension(*.shit) | *.shit" +
                "| Ahaaaaaaaa~~~~~~Aaaaaaaaaaa(*.hentai) | *.hentai";
            saveFileDialog1.FileName = String.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(this.filePath, richTextBox1.Text);
                this.Text = this.filePath + SOFTWARENAME;
            }
        }

        private void openFile()
        {
            openFileDialog1.Filter = "Visual Novel Script(*.plot) | *.plot" +
                "| Shitty FileExtension(*.shit) | *.shit" +
                "| Ahaaaaaaaa~~~~~~Aaaaaaaaaaa(*.hentai) | *.hentai";
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            String jsonOutput = textAnalizer.ConvertToJson(this.richTextBox1);
            System.IO.File.WriteAllText(@"C:\Users\comfo\Desktop\debug.txt",jsonOutput);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form preference = new Settings(this);
            this.Enabled = false;
            preference.Show();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {       

            var maxLineNumberCharLength = richTextBox1.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;
            richTextBox1.Margins[0].Width = richTextBox1.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + 3;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }
    }
}
