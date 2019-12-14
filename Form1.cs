using System;
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
        
        private const bool DEBUGMODE = true;// debug mode switch

        private SceneObj sceneMan;

        public MainWindow()
        {
            InitializeComponent();
            this.Sett_Man = new SettingsManager(Application.StartupPath);
            richTextBox1.Font = new Font("Tahoma", Sett_Man.settingRecorder.Size, FontStyle.Bold);
            // init scene obj
            this.sceneMan = new SceneObj();

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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Json Visual Novel Script(*.json) | *.json";
            openFileDialog1.FileName = String.Empty;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
                groupBox1.Text = this.filePath;
                this.richTextBox1.Text = "";
                jsonAnalizer ja = new jsonAnalizer(this.richTextBox1, this.filePath);
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String jsonOutput = textAnalizer.ConvertToJson(sceneMan);
            System.IO.File.Delete(this.filePath);
            System.IO.File.WriteAllText(this.filePath, jsonOutput);
        }
        
        // needs debug
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Json Visual Novel Script(*.json) | *.json";
            saveFileDialog1.FileName = String.Empty;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
                String jsonOutput = textAnalizer.ConvertToJson(sceneMan);
                try
                {
                    System.IO.File.Delete(this.filePath);
                }
                catch { }
                System.IO.File.WriteAllText(this.filePath, jsonOutput);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + "aaa");
        }

        // debug
        private void debugSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String jsonOutput = textAnalizer.ConvertToJson(sceneMan);
            MessageBox.Show(jsonOutput);
        }

        // debug
        private void debugOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            this.filePath = @"C:\Users\comfo\Desktop\debug.json";
            groupBox1.Text = this.filePath;
            this.richTextBox1.Text = "";
            this.sceneMan.SceneName = "DebugScene";

            // text
            String text = @"Char1@TestText";
            // add line to rtb
            richTextBox1.Text += text;

            //make dictionary
            Dictionary<String, String> testDic = new Dictionary<string, string>();
            testDic.Add("type","text");
            testDic.Add("Character", "Char1");
            testDic.Add("text", "TestText");
            testDic.Add("id","aaaBBBccc");

            // add it to scene obj
            sceneMan.content.AddLast(testDic);
            //sceneMan.lineToNodeDic.Add(0, "aaaBBBccc");
        }

        // richtextbox key event
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    processLine(getCurrentLineNumber());
                    break;
            }
        }


        private int getCurrentLineNumber() { 
            return richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
        }

        // process line with given line number and add it to sceneObj's list
        private void processLine(int lineNumber)
        {
            String line = richTextBox1.Lines[lineNumber];
            char identifier = line[0];
            switch (identifier)
            {
                // various function 
                case '#':

                    break;
                // normal text
                case '@':
                    char[] Sperator = { ':', '：' };
                    String[] nodeInfo = line.Split(Sperator);
                    Dictionary<String, String> newEventNode = new Dictionary<string, string>();
                    newEventNode.Add("type","text");
                    newEventNode.Add("Character", nodeInfo[0]);
                    newEventNode.Add("text", nodeInfo[1]);
                    this.sceneMan.content.AddLast(newEventNode);
                    break;
                default:
                    Dictionary<String, String> unknownNode = new Dictionary<string, string>();
                    unknownNode.Add("type", "null");
                    unknownNode.Add("text", line);
                    this.sceneMan.content.AddLast(unknownNode);
                    break;
            }
            

        }

        // syntax checker
        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentLineNumber = getCurrentLineNumber();
            int start = richTextBox1.GetFirstCharIndexFromLine(currentLineNumber);
            int length = richTextBox1.Lines[currentLineNumber].Length;
            richTextBox1.Select(start, length);
            richTextBox1.SelectionColor = Color.Red;
        }
    }
}
