# Simple Visualnovel Script v1.0: Documentation
## Project Structure
- Visualnovel game --> Plots --> nodes
- (The whole game is made up of various plots. While one Plot is made up of an ordered list of nodes)
- When the game is running, it will interpret the whole plot node by node.

## Syntax of a node
```
[Node Type Identifier] [Marker] [Content]
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

**You can add mark to the conversation node if you want to jump to this conversation node later**

```
@[Marker1]Character1: Text line1
             [Marker2]Text line1

...
...
# GOTO: Marker1
# GOTO: Marker2
```

## Function Node(# Node)
1. BGM function: Update the Background music that is currently playing
```

```
2. SOUND function: Play sound effect
```

```
3. ANIMATION function: Play animation on picture
```

```
4. GAME function: Start playing mini game that is embeded in the visualnovel game
```

```
5. SWITCH function: Check current value
```

```
6. OPTION function: Show option
```

```
7. GOTO function: Goto another conversation node
```

```
8. SHOW,SETIMAGE,and MOVE function
Example:
```
# SHOW: character1@(horizontalLocation,VerticalLocation)
// Note: SetPos and Move must be used after SetImage
#SetImage:ch1:pic8
#SetPos:ch1=(1.5,1)
#Move:ch1=(0.5,0.5)
```
9.Add Comment to script
```
// Comment
```

