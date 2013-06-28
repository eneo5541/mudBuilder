using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ActionItem
    {
        string name;
        List<String> keywords;
        ParameterObject requiredObject;
        ParameterObject excludedObject;
        string outputText;
        int experience;
        Boolean reloadRoom;
        Boolean lookAtRoom;
        string movePlayerToRoom;

        Dictionary<string, string> addNPCs;
        Dictionary<string, string> moveNPCs;
        Dictionary<string, string> removeNPCs;
        Dictionary<string, string> addItems;
        Dictionary<string, string> moveItems;
        Dictionary<string, string> removeItems;

        public ActionItem()
        {
            name = "";
            keywords = new List<String>();
            requiredObject = new ParameterObject();
            excludedObject = new ParameterObject();
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

        public ParameterObject()
        {
            message = "";
            objectPath = "";
        }
    }


}
