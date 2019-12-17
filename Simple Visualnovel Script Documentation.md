# Simple Visualnovel Script v1.0: Documentation
## Project Structure
- Visualnovel game --> Plots --> nodes
- (The whole game is made up of various plots. While one Plot is made up of an ordered list of nodes)
- When the game is running, it will interpret the whole plot node by node.

## Syntax of a node
```
[Node Type Identifier]   [Content]
                         [Content]
                         [Content]
```
There're 2 types of nodes, one is Conversation node(Which is used to update the text), its Node Type Identifier is @; The other One is Function Node(Which is used if you want to do some function in the game)

## Conversation Node(@ Node)
**Here's one example:**
```
@ Character1 : Text1
@ Character2 : Text2
```
Which means :
```
Character 1 says : "Text1".
Character 2 says : "Text2".
```
**Meanwhile, if one character have said several sentences at a time, you can keep adding sentences in the next line without adding Node Type Identifier or Character Name. For Instance:**
```
@ Character1: Text1
              Text2
              Text3
              Text4
```
Means:
```
Character 1 says: Text1.
Character 1 says: Text2.
Character 1 says: Text3.
Character 1 says: Text4.
```
**When a paragraph text is narrative text, you don't need to add colon in the node. For Example:**
```
@ Narritive Text line1
  Narritive Text line2
  Narritive Text line3
  Narritive Text line4
```
## Function Node(# Node)
**TODO: ADD function node documentation**