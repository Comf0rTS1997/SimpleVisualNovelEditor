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
        const String ALLIDENTIFIER = "#@";

        public static String ConvertToJson(Scintilla textBox)
        {
            Console.WriteLine("Start converting");
            textBox.ReadOnly = true; // User will not able to change text when processing
            SceneObj sceneMan = new SceneObj();
            int lineCount = textBox.Lines.Count;
            Console.WriteLine("Total Line:" + lineCount);
            for (int i = 0; i < lineCount; i++)
            {
                Console.WriteLine("Processing line:" + i);
                Queue<String> node = new Queue<string>();
                String nodeFirstLine = textBox.Lines[i].Text;
                node.Enqueue(nodeFirstLine);
                int pointer = i + 1;
                bool foundEndOfNode = false;
                while (pointer < lineCount && !foundEndOfNode)
                {
                    String currentLine = textBox.Lines[pointer].Text;
                    char currentLineIdentifier = currentLine[0];
                    // if next line does not contain an identifier, add it to node
                    if (!ALLIDENTIFIER.Contains(currentLineIdentifier))
                    {
                        Console.WriteLine("     Not Node:" + pointer + " Enqueue:" + currentLine);
                        node.Enqueue(currentLine);
                        pointer++;
                    }
                    else // finished processing this node
                    {
                        Console.WriteLine("End of node: " + (pointer -1));
                        Console.WriteLine("Pointer: " + pointer);
                        i = pointer - 1;
                        foundEndOfNode = true;
                    } 
                }
                Console.WriteLine("node Size:" + node.Count);
                switch (nodeFirstLine[0])
                {
                    case '@':
                        conversationHandler(node,sceneMan);
                        break;
                    case '#':
                        functionHandler(node,sceneMan);
                        break;
                }
            }
            textBox.ReadOnly = false; // unlock the textbox
            Console.WriteLine("Conversion Done");
            return JsonConvert.SerializeObject(sceneMan, Formatting.Indented);
        }
        private static void conversationHandler(Queue<String> node, SceneObj sceneMan)
        {
            //process first line
            char[] Sperator = { ':', '：' };
            String[] firstLineComponent = node.Dequeue().Split(Sperator);
            String characterName = firstLineComponent[0];
            String conversationText = firstLineComponent[1];
            conversationHandlerHelper(characterName, conversationText, sceneMan);

            while(node.Count != 0)
            {
                conversationHandlerHelper(characterName, node.Dequeue(), sceneMan);
            }
        }
        private static void conversationHandlerHelper(String character, string text, SceneObj sceneMan) 
        {
            Dictionary<String, Object> newNode = new Dictionary<string, Object>();
            newNode.Add("type", "Conversation"); // the type of the node
            newNode.Add("Name", character); // add character name   
            newNode.Add("text", text); // add text
            sceneMan.addNode(newNode);

        }

        //if the node is a function node
        private static void functionHandler(Queue<String> node, SceneObj sceneMan)
        {
            String firstLine = node.Dequeue();
            char[] Sperator = { ':', '：' };
            String[] firstLineComponent = firstLine.Split(Sperator);
            if (firstLineComponent.Count<String>() > 1)
            {
                String temp = StringArrayToString(firstLineComponent,1, firstLineComponent.Count<String>() - 1);
                node.Enqueue(temp);
            }
            String functionName = firstLineComponent[0];
            functionName = functionName.Remove(0,1);
            functionName = functionName.ToUpper();
            Dictionary<String, Object> newNode = new Dictionary<string, object>();
            newNode.Add("type", "Function");
            newNode.Add("functionName",functionName);
            switch (functionName)
            {
                case "BGM":
                    newNode.Add(functionName,node.Dequeue());
                    break;
                case "SOUND":
                    newNode.Add(functionName, node.Dequeue());
                    break;
                case "ANIMATION":
                    newNode.Add(functionName, node.Dequeue());
                    break;
                case "GAME":
                    newNode.Add(functionName, node.Dequeue());
                    break;
                case "SWITCH":
                    Dictionary<String, String> switchDic = new Dictionary<string, string>();
                    foreach (String pointingLine in node)
                    {
                        String[] pointingLineComponent = node.Dequeue().Split(Sperator);
                        switchDic.Add(pointingLineComponent[0],pointingLineComponent[1]);
                    }
                    newNode.Add("Case", switchDic);
                    break;
                case "OPTION":
                    Dictionary<String, String> optionDic = new Dictionary<string, string>();
                    foreach (String pointingLine in node)
                    {
                        String[] pointingLineComponent = node.Dequeue().Split(Sperator);
                        optionDic.Add(pointingLineComponent[0], pointingLineComponent[1]);
                    }
                    newNode.Add("Option", optionDic);
                    break;
                case "UPDATE":
                    newNode.Add("Update", node.Dequeue());
                    break;
                default:
                    Console.WriteLine("Illegal function:" + functionName);
                    break;
            }
            sceneMan.addNode(newNode);

        }

        private static String StringArrayToString(String[] resource, int start, int end)
        {
            String Result = "";
            for (int i = start; i<= end; i++)
            {
                Result = Result + resource[i];
            }
            return Result;
        }

        


    }
}
