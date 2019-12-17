using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLinesEditor
{
    class SceneObj
    {
        public LinkedList<Dictionary<String, Object>> content;
        //public Dictionary<int, String> lineToNodeDic;

        public SceneObj()
        {
            this.content = new LinkedList<Dictionary<string, Object>>();
            //this.lineToNodeDic = new Dictionary<int, string>();
        }

        public void addNode(Dictionary<String, Object> node)
        {
            content.AddLast(node);
        }
    }
}

