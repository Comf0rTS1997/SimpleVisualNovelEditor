using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace GameLinesEditor
{
    class jsonAnalizer
    {
        private RichTextBox rtb;
        private String jsonText;
        private JObject jobject;
        private SceneObj sceneObj;

        public jsonAnalizer(RichTextBox rtbI, String filePath)
        {
            this.rtb = rtbI; // get richTextBox
            jsonText = System.IO.File.ReadAllText(filePath);
        }
    }
}
