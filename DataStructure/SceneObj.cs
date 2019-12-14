using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLinesEditor
{
    class SceneObj
    {
        public String SceneName;
        public String GOTO;
        public LinkedList<Dictionary<String, String>> content;
        //public Dictionary<int, String> lineToNodeDic;

        public SceneObj(String nameIn, LinkedList<Dictionary<String, String>> eventListIn, String GOTOIn, Dictionary<int, String> lineToNodeDicIn)
        {
            this.SceneName = nameIn;
            this.content = eventListIn;
            this.GOTO = GOTOIn;
            //this.lineToNodeDic = lineToNodeDicIn;
        }

        public SceneObj()
        {
            this.SceneName = "";
            this.GOTO = "";
            this.content = new LinkedList<Dictionary<string, string>>();
            //this.lineToNodeDic = new Dictionary<int, string>();
        }
    }
}

