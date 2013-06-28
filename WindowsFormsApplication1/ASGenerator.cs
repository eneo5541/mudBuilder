using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Flags]
enum ObjectType
{
    NONE,
    ITEM,
    NPC,
    ROOM
}

namespace WindowsFormsApplication1
{
    class ASGenerator
    {
        ObjectType objectType;
        string[] package = new String[2];
        List<String> imports;
        string extension;
        string objectName;
        string shortDesc;
        string aliases;
        string longDesc;
        Dictionary<string, string> exits;
        Boolean isGettable;
        Dictionary<string, string> npcs;
        Dictionary<string, string> gettables;
        Dictionary<string, string> descriptions;
        List<String> dialogue;
        List<String> conversations;

        public ASGenerator()
        {
            setPackage("house");
            resetAllFields();
        }

        public string getObjectName()
        {
            return "objects\\" + package[0] + "\\" + package[1] + "\\" + objectName + ".as";
        }

        private void resetAllFields()
        {
            string[] package = new String[2];
            imports = new List<String>();
            extension = "";
            objectName = "";
            shortDesc = "";
            aliases = "";
            longDesc = "";
            exits = new Dictionary<string, string>();
            isGettable = true;
            npcs = new Dictionary<string, string>();
            gettables = new Dictionary<string, string>();
            descriptions = new Dictionary<string, string>();
            dialogue = new List<String>();
            conversations = new List<String>();
        }

        public void generateAS()
        {
            string pathString = @"C:\inetpub\wwwroot\asTest\src\objects\" + package[0] + @"\" + package[1] + @"\";
            string fileName = pathString + objectName + ".as";

            string gettablesString = "";
            string npcString = "";
            string dialogueString = "";
            string conversationString = "";

            if (objectType == ObjectType.ROOM)
            {
                if (exits.Count > 0)
                    parseExits();
                if (gettables.Count > 0)
                    gettablesString = parseGettables();
                if (npcs.Count > 0)
                    npcString = parseNPCs();
            }
            else if (objectType == ObjectType.NPC)
            {
                if (dialogue.Count > 0)
                    dialogueString = parseDialogue();
                if (conversations.Count > 0)
                    conversationString = parseConversations();
            }
            
            try
            {
                if (!Directory.Exists(pathString))
                {
                    System.IO.Directory.CreateDirectory(pathString);
                }

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("package objects." + package[0] + "." + package[1]);
                    sw.WriteLine("{");
                    foreach (string lib in imports) // Loop through List with foreach
                    {
                        sw.WriteLine("    " + lib + "");
                    }
                    sw.WriteLine("    ");
                    sw.WriteLine("    public class " + objectName + " extends " + extension + "");
                    sw.WriteLine("    {");
                    sw.WriteLine("        public function " + objectName + "() ");
                    sw.WriteLine("        {");
                    sw.WriteLine("            super();");
                    if (objectType == ObjectType.ITEM && !isGettable)
                    {
                        sw.WriteLine("            ");
                        sw.WriteLine("            isGettable = false;");
                    }
                    sw.WriteLine("        }");
                    sw.WriteLine("        ");
                    sw.WriteLine("        override public function setShortDesc():void");
                    sw.WriteLine("        {");
                    sw.WriteLine("            shortDesc = '" + shortDesc + "';");
                    sw.WriteLine("        }");
                    sw.WriteLine("        ");
                    if (aliases.Length > 2)
                    {
                        sw.WriteLine("        override public function setAlias():void");
                        sw.WriteLine("        {");
                        sw.WriteLine("            alias = [" + aliases + "];");
                        sw.WriteLine("        }");
                        sw.WriteLine("        ");
                    }
                    sw.WriteLine("        override public function setLongDesc():void");
                    sw.WriteLine("        {");
                    sw.WriteLine("            longDesc = '" + longDesc + "';");
                    sw.WriteLine("        }");
                    sw.WriteLine("        ");
                    if (objectType == ObjectType.ROOM)
                    {
                        if (exits.Count > 0)
                        {
                            sw.WriteLine("        override public function setExits():void");
                            sw.WriteLine("        {");
                            foreach (KeyValuePair<string, string> pair in exits)
                            {
                                string[] path = pair.Value.Split('\\');
                                string exitName = path[path.Length - 1];
                                sw.WriteLine("            exits['" + pair.Key.Trim().ToLower() + "'] = " + exitName.Substring(0, exitName.Length - 3) + ";");
                            }
                            sw.WriteLine("        }");
                            sw.WriteLine("        ");
                        }
                        if (npcString.Length > 0)
                        {
                            sw.WriteLine("        override public function setNpcs():void");
                            sw.WriteLine("        {");
                            sw.WriteLine("            npcs = [ " + npcString + " ];");
                            sw.WriteLine("        }");
                            sw.WriteLine("        ");
                        }
                        if (gettablesString.Length > 0)
                        {
                            sw.WriteLine("        override public function setGettables():void");
                            sw.WriteLine("        {");
                            sw.WriteLine("            gettables = [ " + gettablesString + " ];");
                            sw.WriteLine("        }");
                            sw.WriteLine("        ");
                        } 
                        if (descriptions.Count > 0)
                        {
                            sw.WriteLine("        override public function setItems():void");
                            sw.WriteLine("        {");
                            foreach (KeyValuePair<string, string> pair in descriptions)
                            {
                                sw.WriteLine("            items['" + pair.Key.Trim().ToLower() + "'] = '" + pair.Value + "';");
                            }
                            sw.WriteLine("        }");
                            sw.WriteLine("        ");
                        }
                    }
                    else if (objectType == ObjectType.NPC)
                    {
                        if (dialogueString.Length > 0)
                        {
                            sw.WriteLine("        override public function setDialogue():void");
                            sw.WriteLine("        {");
                            sw.WriteLine("			dialogue = [");
                            sw.WriteLine(dialogueString);
                            sw.WriteLine("			];");
                            sw.WriteLine("        }");
                            sw.WriteLine("        ");
                        }
                        if (conversationString.Length > 0)
                        {
                            sw.WriteLine("        override public function setConversations():void");
                            sw.WriteLine("        {");
                            sw.WriteLine("			conversations = [");
                            sw.WriteLine(conversationString);
                            sw.WriteLine("			];");
                            sw.WriteLine("        }");
                            sw.WriteLine("        ");
                        }
                    }
                    sw.WriteLine("    }");
                    sw.WriteLine("    ");
                    sw.WriteLine("}");
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

                resetAllFields();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        public void setType(ObjectType type)
        {
            this.objectType = type;

            imports = new List<String>();

            switch (type)
            {
                case ObjectType.ITEM:
                    imports.Add("import objects.Gettable;");
                    package[0] = "gettables";
                    extension = "Gettable";
                    break;
                case ObjectType.NPC:
                    imports.Add("import objects.Person;");
                    package[0] = "npcs";
                    extension = "Person";
                    break;
                case ObjectType.ROOM:
                    imports.Add("import objects.Room;");
                    package[0] = "rooms";
                    extension = "Room";
                    break;
                default:
                    return;
            }
        }

        public void setPackage(string package)
        {
            this.package[1] = package.ToLower();
        }

        public void setObjectName(string objectName)
        {
            if (objectName.Length == 0)
                this.objectName = "";
            else
                this.objectName = objectName.Substring(0, 1).ToUpper() + objectName.Substring(1, objectName.Length-1);
        }

        public void setShort(string shortDesc)
        {
            if (shortDesc.Length == 0)
                shortDesc = "";
            this.shortDesc = shortDesc;
        }

        public void setAliases(string aliases)
        {
            if (aliases.Length == 0)
                aliases = shortDesc.ToLower();

            this.aliases = aliases;
        }

        public void setLong(string longDesc)
        {
            if (longDesc.Length == 0)
                longDesc = "";
            this.longDesc = longDesc;
        }

        public void setItemGettable(Boolean isGettable)
        {
            this.isGettable = isGettable;
        }

// Manipulate the exits of a room here
        public void addExit(string direction, string location)
        {
            exits.Add(direction, location);
        }

        public void removeExit(string direction)
        {
            exits.Remove(direction);
        }

        public Boolean doesExitExist(string direction, string location)
        {
            foreach (KeyValuePair<string, string> pair in exits)
            {
                if(pair.Key == direction || pair.Value == location)
                    return true;
            }

            return false;
        }

        private void parseExits()
        {
            foreach (KeyValuePair<string, string> pair in exits)
            {
                string[] path = pair.Value.Split('\\');
                string fileName = path[path.Length - 1];
                imports.Add("import objects.rooms." + package[1] + "." + fileName.Substring(0, fileName.Length - 3) + ";");
            }
        }

// Manipulate the NPCs of a room here
        public void addNPC(string npcName, string npcLocation)
        {
            npcs.Add(npcName, npcLocation);
        }

        public void removeNPC(string npcName)
        {
            npcs.Remove(npcName);
        }

        public Boolean doesNPCExist(string npcLocation)
        {
            return npcs.ContainsValue(npcLocation);
        }

        private string parseNPCs()
        {
            string npcsString = "";
            foreach (KeyValuePair<string, string> pair in npcs)
            {
                string[] path = pair.Value.Split('\\');
                string fileName = path[path.Length - 1];

                npcsString += fileName.Substring(0, fileName.Length - 3) + ", ";
                imports.Add("import objects.npcs." + package[1] + "." + fileName.Substring(0, fileName.Length - 3) + ";");
            }

            if (npcsString.Length > 0)
            {
                npcsString = npcsString.Substring(0, npcsString.Length - 2);
            }

            return npcsString;
        }

// Manipulate the gettables of a room here
        public void addGettable(string itemName, string itemLocation)
        {
            gettables.Add(itemName, itemLocation);
        }

        public void removeGettable(string itemName)
        {
            gettables.Remove(itemName);
        }

        public Boolean doesGettableExist(string gettableLocation)
        {
            return gettables.ContainsValue(gettableLocation);
        }

        private string parseGettables()
        {
            string gettableString = "";
            foreach (KeyValuePair<string, string> pair in gettables)
            {
                string[] path = pair.Value.Split('\\');
                string fileName = path[path.Length - 1];

                gettableString += fileName.Substring(0, fileName.Length - 3) + ", ";
                imports.Add("import objects.gettables." + package[1] + "." + fileName.Substring(0, fileName.Length - 3) + ";");
            }

            if (gettableString.Length > 0)
            {
                gettableString = gettableString.Substring(0, gettableString.Length - 2);
            }
                    
            return gettableString;
        }


// Manipulate the item descriptions of a room here
        public void addDescription(string descName, string desc)
        {
            descriptions.Add(descName, desc);
        }

        public void removeDescription(string descName)
        {
            descriptions.Remove(descName);
        }

        public Boolean doesDescriptionExist(string descName)
        {
            return descriptions.ContainsValue(descName);
        }

// Manipulate the dialogue of an NPC
        public void addDialogue(string dialogueText)
        {
            dialogue.Add(dialogueText);
        }

        public void removeDialogue(string dialogueText)
        {
            dialogue.Remove(dialogueText);
        }

        public Boolean doesDialogueExist(string dialogueText)
        {
            foreach (string d in dialogue)
            {
                if (dialogueText == d)
                {
                    return true;
                }
            }

            return false;
        }

        private string parseDialogue()
        {
            string dialogueString = "";
            foreach (string d in dialogue)
            {
                dialogueString += "				'" + d + "',\n";
            }

            if (dialogueString.Length > 0)
            {
                dialogueString = dialogueString.Substring(0, dialogueString.Length - 2);
            }

            return dialogueString;
        }

// Manipulate the conversations of an NPC
        public void addConversations(string conversationText)
        {
            conversations.Add(conversationText);
        }

        public void removeConversations(string conversationText)
        {
            conversations.Remove(conversationText);
        }

        public Boolean doesConversationExist(string conversationText)
        {
            foreach (string c in conversations)
            {
                if (conversationText == c) 
                {
                    return true;
                }
            }

            return false;
        }

        private string parseConversations()
        {
            string conversationString = "";
            foreach (string c in conversations)
            {
                conversationString += "				'" + c + "',\n";
            }

            if (conversationString.Length > 0)
            {
                conversationString = conversationString.Substring(0, conversationString.Length - 2);
            }

            return conversationString;
        }




    }

}
