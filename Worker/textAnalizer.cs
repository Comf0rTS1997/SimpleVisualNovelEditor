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
        const String ALLIDENTIFIER = "#@/";

        public static String ConvertToJson(Scintilla textBox)
        {
            textBox.ReadOnly = true; // User will not able to change text when processing
            SceneObj sceneMan = new SceneObj();
            int lineCount = textBox.Lines.Count;
            for (int i = 0; i < lineCount; i++)
            {
                if (textBox.Lines[i].Text.Trim() == String.Empty)
                {
                    break;
                }
                Queue<String> node = new Queue<string>();
                String nodeFirstLine = textBox.Lines[i].Text;
                node.Enqueue(nodeFirstLine);
                int pointer = i + 1;
                bool foundEndOfNode = false;
                while (pointer < lineCount && !foundEndOfNode)
                {
                    String currentLine = textBox.Lines[pointer].Text;
                    char currentLineIdentifier = '/';
                    try
                    {
                        currentLineIdentifier = currentLine[0];
                    }
                    catch
                    {

                    }

                    // if next line does not contain an identifier, add it to node
                    if (!ALLIDENTIFIER.Contains(currentLineIdentifier))
                    {
                        node.Enqueue(currentLine);
                        pointer++;
                    }
                    else // finished processing this node
                    {
                        i = pointer - 1;
                        foundEndOfNode = true;
                    } 
                }
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
            return JsonConvert.SerializeObject(sceneMan, Formatting.Indented);
        }
        private static void conversationHandler(Queue<String> node, SceneObj sceneMan)
        {
            //process first line
            char[] Sperator = { ':', '：' };
            String[] firstLineComponent = node.Dequeue().Split(Sperator);
            String characterName = "";
            String conversationText = "";
            if (firstLineComponent.Count<String>() > 1)
            {
                characterName = firstLineComponent[0];
                conversationText = firstLineComponent[1];
            }
            else
            {
                conversationText = firstLineComponent[0]; // narritive text
            }

            
            conversationHandlerHelper(characterName, conversationText, sceneMan);

            while(node.Count != 0)
            {
                conversationHandlerHelper(removeMarker(characterName), node.Dequeue(), sceneMan);
            }
        }
        private static void conversationHandlerHelper(String character, string text, SceneObj sceneMan) 
        {
            // trim given text
            char[] trimChar = { '@', ' ' };
            character = character.Trim(trimChar);
            text = text.Trim(trimChar);
            character = character.Replace(Environment.NewLine, String.Empty);
            text = text.Replace(Environment.NewLine, String.Empty);
            //
            // if character name has marker, add it to text;
            String markerInCharacter = findMarker(character);
            if(markerInCharacter != String.Empty)
            {
                text = '[' + markerInCharacter + ']' + text;
            }
            character = removeMarker(character);
            //
            Dictionary<String, Object> newNode = new Dictionary<string, Object>();
            newNode.Add("Wait", "true");
            newNode.Add("Type", "Conversation"); // the type of the node
            newNode.Add("Name", character); // add character name   
            String marker = findMarker(text);
            if (marker == String.Empty)
            {
                newNode.Add("Text", text); // add text
            }
            else // when there is marker in name
            {
                newNode.Add("MARKER", marker);
                newNode.Add("Text", removeMarker(text));
            }
            
            sceneMan.addNode(newNode);
        }

        //if the node is a function node
        private static void functionHandler(Queue<String> node, SceneObj sceneMan)
        {
            String firstLine = node.Dequeue();
            String marker = findMarker(firstLine);
            firstLine = removeMarker(firstLine);
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
            functionName = functionName.Trim();
            
            Dictionary<String, Object> newNode = new Dictionary<string, object>();
            if(marker != String.Empty)
            {
                newNode.Add("MARKER", marker);
            }
            newNode.Add("Type", "Function");
            newNode.Add("FunctionName",functionName);
            // analize this node
            switch (functionName)
            {
                case "BGM":
                    newNode.Add(functionName,node.Dequeue().Trim());
                    break;
                case "SOUND":
                    newNode.Add(functionName, node.Dequeue().Trim());
                    break;
                case "ANIMATION":
                    newNode.Add(functionName, node.Dequeue().Trim());
                    break;
                case "GAME":
                    newNode.Add(functionName, node.Dequeue().Trim());
                    break;
                case "SWITCH":
                    Dictionary<String, String> switchDic = new Dictionary<string, string>();
                    while (node.Count > 0)
                    {
                        String pointingLine = node.Dequeue();
                        String[] pointingLineComponent = pointingLine.Split(Sperator);
                        // trim and add parameters
                        char[] trimChar = { '#', ' ' };
                        try
                        {
                            String parName = pointingLineComponent[0].Trim(trimChar).Replace(Environment.NewLine, String.Empty);
                            String parValue = pointingLineComponent[1].Trim(trimChar).Replace(Environment.NewLine, String.Empty);
                            switchDic.Add(parName, parValue);
                        }
                        catch
                        {
                            Console.WriteLine("Bad Parameter");
                        }
                    }
                    newNode.Add("SWITCH", switchDic);
                    break;
                case "OPTION":
                    Dictionary<String, String> optionDic = new Dictionary<string, string>();
                    while (node.Count > 0)
                    {
                        optionDic.Add("Wait","true");
                        String pointingLine = node.Dequeue();
                        String[] pointingLineComponent = pointingLine.Split(Sperator);
                        // trim and add parameters
                        char[] trimChar = { '#', ' ' };
                        //
                        try
                        {
                            String parName = pointingLineComponent[0].Trim(trimChar).Replace(Environment.NewLine, String.Empty);
                            String parValue = pointingLineComponent[1].Trim(trimChar).Replace(Environment.NewLine, String.Empty);
                            optionDic.Add(parName, parValue);
                        }
                        catch 
                        {
                            Console.WriteLine("Bad Parameter");
                        }
                        
                    }
                    newNode.Add("OPTION", optionDic);
                    break;
                case "UPDATE":
                    newNode.Add("UPDATE", node.Dequeue().Trim());
                    break;
                case "GOTO":
                    newNode.Add("GOTO", node.Dequeue().Trim());
                    break;
                case "SET":
                    newNode.Add("SET", node.Dequeue().Trim());
                    break;
                case "POS":
                    newNode.Add("POS", node.Dequeue().Trim());
                    break;
                case "MOVE":
                    newNode.Add("MOVE", node.Dequeue().Trim());
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

        // get the marker with given line
        //(input does not contains node type indicator)
        private static String findMarker(String input)
        {
            String result = String.Empty;
            if (input.Contains("[") && input.Contains("]"))
            {
                input = input.Trim();
                int left = input.IndexOf('[');
                int right = input.IndexOf(']');
                result = input.Substring(left + 1,right - left -1);
            }
            return result;
        }

        // remove the marker in the given line
        private static String removeMarker(String input)
        {
            if (input.Contains("[") && input.Contains("]"))
            {
                int left = input.IndexOf('[');
                int right = input.IndexOf(']');
                input = input.Remove(left, right - left + 1);
            }
            return input;
        }
        

        


    }
}
