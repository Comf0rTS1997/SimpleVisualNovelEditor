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
        public LinkedList<Dictionary<String, Object>> content;
        //public Dictionary<int, String> lineToNodeDic;

        public SceneObj()
        {
            this.SceneName = "";
            this.content = new LinkedList<Dictionary<string, Object>>();
            //this.lineToNodeDic = new Dictionary<int, string>();
        }

        public void addNode(Dictionary<String, Object> node)
        {
            content.AddLast(node);
        }
    }
}

