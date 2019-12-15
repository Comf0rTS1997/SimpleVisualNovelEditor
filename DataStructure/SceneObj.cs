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
        public LinkedList<Dictionary<String, String>> content;
        //public Dictionary<int, String> lineToNodeDic;

        public SceneObj(String nameIn, LinkedList<Dictionary<String, String>> eventListIn, Dictionary<int, String> lineToNodeDicIn)
        {
            this.SceneName = nameIn;
            this.content = eventListIn;
            //this.lineToNodeDic = lineToNodeDicIn;
        }

        public SceneObj()
        {
            this.SceneName = "";
            this.content = new LinkedList<Dictionary<string, string>>();
            //this.lineToNodeDic = new Dictionary<int, string>();
        }
    }
}

