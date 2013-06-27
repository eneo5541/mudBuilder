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

        public ASGenerator()
        {
            setPackage("house");
            exits = new Dictionary<string,string>();
            aliases = "";

            imports = new List<String>();
        }

        public void generateAS()
        {
            string pathString = @"C:\inetpub\wwwroot\asTest\src\objects\" + package[0] + @"\" + package[1] + @"\";
            string fileName = pathString + objectName + ".as";

            string exitsString = "";
            if(objectType == ObjectType.ROOM && exits.Count > 0)
                exitsString = parseExits();
            
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
                    if (objectType == ObjectType.ROOM && exitsString.Length > 0)
                    {
                        sw.WriteLine("        override public function setExits():void");
                        sw.WriteLine("        {");
                        sw.WriteLine("            exits = { " + exitsString + " };");
                        sw.WriteLine("        }");
                        sw.WriteLine("        ");
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

        private string parseExits()
        {
            string exitsString = "";
            foreach (KeyValuePair<string, string> pair in exits)
            {
                string[] path = pair.Value.Split('\\');
                string fileName = path[path.Length - 1];

                exitsString += pair.Key.ToLower() + ":" + fileName.Substring(0, fileName.Length - 3) + ",\n					";
                imports.Add("import objects.rooms." + package[1] + "." + fileName.Substring(0, fileName.Length - 3) + ";");
            }

            if (exitsString.Length > 0)
            {
                exitsString = exitsString.Substring(0, exitsString.Length - 7);
            }

            return exitsString;
        }


    }

}
