using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ScintillaNET;

namespace GameLinesEditor
{
    // used when saving file
    class textAnalizer
    {
        public static String ConvertToJson(Scintilla textBox)
        {
            SceneObj sceneMan = new SceneObj();
            String Result = "";
            // process all lines in textbox
            for(int i = 0; i < textBox.Lines.Count; i++)
            {
                String line = textBox.Lines[i].Text;
                char identifier = line[0];
                switch (identifier)
                {
                    // various function 
                    case '#':

                        break;
                    // normal text
                    case '@':
                        line = line.Remove(0, 1);
                        char[] Sperator = { ':', '：' };
                        String[] nodeInfo = line.Split(Sperator);
                        Dictionary<String, String> newEventNode = new Dictionary<string, string>();
                        newEventNode.Add("type", "text");
                        newEventNode.Add("Character", nodeInfo[0]);
                        newEventNode.Add("text", nodeInfo[1]);
                        sceneMan.content.AddLast(newEventNode);
                        break;
                }
            }
            Result = JsonConvert.SerializeObject(sceneMan,Formatting.Indented);
            return Result;
        }
    }
}
