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
    public partial class DebugPlayer : Form
    {
        private String releasePath;
        public DebugPlayer(String releasePathIn)
        {
            InitializeComponent();
            this.releasePath = releasePathIn;
        }
    }
}
