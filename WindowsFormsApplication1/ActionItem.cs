using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ActionItem
    {
        public string name;
        public List<String> keywords;
        public ParameterObject requiredObject;
        public ParameterObject excludedObject;
        public string outputText;
        public int experience;
        public Boolean reloadRoom;
        public Boolean lookAtRoom;
        public string movePlayerToRoom;

        public Dictionary<string, string> addNPCs;
        public Dictionary<string, string> moveNPCs;
        public Dictionary<string, string> removeNPCs;
        public Dictionary<string, string> addItems;
        public Dictionary<string, string> moveItems;
        public Dictionary<string, string> removeItems;

        public ActionItem()
        {
            name = "";
            keywords = new List<String>();
            requiredObject = null;
            excludedObject = null;
            outputText = "";
            experience = 0;
            reloadRoom = false;
            lookAtRoom = false;
            movePlayerToRoom = "";

            addNPCs = new Dictionary<string, string>();
            moveNPCs = new Dictionary<string, string>();
            removeNPCs = new Dictionary<string, string>();
            addItems = new Dictionary<string, string>();
            moveItems = new Dictionary<string, string>();
            removeItems = new Dictionary<string, string>();
        }

        public string compileKeywords()
        {
             var keywordString = "keywords:[";
             foreach (string k in keywords)
             {
                keywordString += "\n[" + k + "],";
             }
             if (keywords.Count > 0)
             {
                keywordString = keywordString.Substring(0, keywordString.Length - 1);
                keywordString += "\n],";
             }
            return keywordString;
        }

        public string compileResponse()
        {
            var responseString = "\nresponse:function (target:*):void {";

            if (outputText.Length > 0)
            {
                responseString += "\ntarget.outputText('" + outputText + "');";
            }
            if (experience > 0)
            {
                responseString += "\ntarget.addExperience('" + experience + "');";
            }
            if (reloadRoom)
            {
                responseString += "\ntarget.lookAtRoom();";
            }
            if (lookAtRoom)
            {
                responseString += "\ntarget.reloadRoom();";
            }
            if (movePlayerToRoom.Length > 0)
            {
                responseString += "\ntarget.moveUserToRoom(new " + getObjectName(movePlayerToRoom) + ");";
            }

            foreach (KeyValuePair<string, string> pair in addNPCs)
            {
                responseString += "\ntarget.addPerson(" + getObjectName(pair.Key) + ", " + getObjectName(pair.Value) + ");";
            }
            foreach (KeyValuePair<string, string> pair in moveNPCs)
            {
                responseString += "\ntarget.movePerson(" + getObjectName(pair.Key) + ", " + getObjectName(pair.Value) + ");";
            }
            foreach (KeyValuePair<string, string> pair in removeNPCs)
            {
                responseString += "\ntarget.removePerson(" + getObjectName(pair.Key) + ");";
            }

            foreach (KeyValuePair<string, string> pair in addItems)
            {
                responseString += "\ntarget.addGettable(" + getObjectName(pair.Key) + ", " + getObjectName(pair.Value) + ");";
            }
            foreach (KeyValuePair<string, string> pair in moveItems)
            {
                responseString += "\ntarget.moveGettable(" + getObjectName(pair.Key) + ", " + getObjectName(pair.Value) + ");";
            }
            foreach (KeyValuePair<string, string> pair in removeNPCs)
            {
                responseString += "\ntarget.removeGettable(" + getObjectName(pair.Key) + ");";
            }

            responseString += "},";

            return responseString;
        }


        string getObjectName(string objectPath)
        {
            string[] splitPath = objectPath.Split('\\');
            string objectName = splitPath[splitPath.Length - 1];
            return objectName.Substring(0, objectName.Length - 3);
        }

    }

    class ParameterObject
    {
        ObjectType objectType;
        string message;
        public string objectPath;

        public ParameterObject(ObjectType objectType, string message, string objectPath)
        {
            this.objectType = objectType;
            this.message = message;
            this.objectPath = objectPath;
        }

        public string compileParameter()
        {
            string actionString = "\n { ";
            switch (objectType)
            {
                case ObjectType.ITEM:
                    actionString += "gettable:";
                    break;
                case ObjectType.NPC:
                    actionString += "npc:";
                    break;
                case ObjectType.ROOM:
                    actionString += "room:";
                    break;
            }

            string[] path = objectPath.Split('\\');
            string objectName = path[path.Length - 1];
            actionString += objectName.Substring(0, objectName.Length - 3) + ", error:'"+message+"' },";

            return actionString;
        }

    }


}
