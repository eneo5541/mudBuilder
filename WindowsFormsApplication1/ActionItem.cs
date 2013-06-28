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
    }

    class ParameterObject
    {
        ObjectType objectType;
        string message;
        string objectPath;

        public ParameterObject(ObjectType objectType, string message, string objectPath)
        {
            this.objectType = objectType;
            this.message = message;
            this.objectPath = objectPath;
        }
    }


}
