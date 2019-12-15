using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLinesEditor
{
    public partial class Settings : Form
    {
        private MainWindow mainWindowPointer;
        private string currentSettings;
        private Color defaultLineFieldColor;
        public Settings(MainWindow mainWindowPointer) {
            InitializeComponent();
            this.mainWindowPointer = mainWindowPointer;
            this.currentSettings = this.mainWindowPointer.currentSettings;
            defaultLineFieldColor = this.mainWindowPointer.richTextBox1Pointer.Styles[Style.LineNumber].BackColor;


        }
        private void Settings_Load(object sender, EventArgs e)
        {
            
        }


        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainWindowPointer.Enabled = true;
        }

        // Set the theme for chosen theme
        // First line: the background color of actual text
        // Second line: the color of treeView
        // Third line: the color of LineNum
        // Fourth line: the color of line number field
        // Fifth line: the color of spliter between line number field and actual text field
        private void button1_Click(object sender, EventArgs e)
        {
            switch (currentSettings)
            {
                case "DEFAULT":
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.Default].BackColor = Color.White;
                    mainWindowPointer.treeView1Pointer.BackColor = Color.White;
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.LineNumber].ForeColor = Color.Black;
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.LineNumber].BackColor = defaultLineFieldColor;
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.Default].ForeColor = Color.Black;
                    break;
                case "DARK MODE":
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.Default].BackColor = Color.Black;
                    mainWindowPointer.treeView1Pointer.BackColor = Color.Black;
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.LineNumber].ForeColor = Color.White;
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.LineNumber].BackColor = Color.Black;
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.Default].ForeColor = Color.White;
                    break;
                case "KIMOCHI MODE":
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.Default].BackColor = Color.FromArgb(0xb5, 0xdb, 0xff);
                    mainWindowPointer.treeView1Pointer.BackColor = Color.FromArgb(0xb5, 0xdb, 0xff);
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.LineNumber].ForeColor = Color.Black;
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.LineNumber].BackColor = Color.FromArgb(0xb5, 0xdb, 0xff);
                    mainWindowPointer.richTextBox1Pointer.Styles[Style.Default].ForeColor = Color.White;
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSettings = listBox1.Text;
        }
    }
}
