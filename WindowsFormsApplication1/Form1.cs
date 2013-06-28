using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ASGenerator asGenerator;
        ObjectType layoutState;
        string fileName;

        public Form1()
        {
            InitializeComponent();

            asGenerator = new ASGenerator();
            fileName = "";
            setLayout(ObjectType.ROOM);
            mainViewPanel.Visible = true;
            actionViewPanel.Visible = false;
        }

        private void resetAllFields()
        {
            fileName = "";
            objectNameTextBox.Text = "";
            shortDescTextBox.Text = "";
            longDescTextBox.Text = "";
            aliasTextBox.Text = "";
            itemPickupCheckBox.Checked = true;
            directionTextBox.Text = "";
            exitLocationLabel.Text = "";
            descriptionNameTextBox.Text = "";
            descriptionDescriptionTextBox.Text = "";
            dialogueTextBox.Text = "";
            conversationTextBox.Text = "";

            while (exitsCheckedList.Items.Count > 0)
            {
                exitsCheckedList.Items.Remove(exitsCheckedList.Items[0]);
            }
            while (addedNPCsCheckedList.Items.Count > 0)
            {
                addedNPCsCheckedList.Items.Remove(addedNPCsCheckedList.Items[0]);
            }
            while (addedItemsCheckedList.Items.Count > 0)
            {
                addedItemsCheckedList.Items.Remove(addedItemsCheckedList.Items[0]);
            }
            while (descriptionCheckedList.Items.Count > 0)
            {
                descriptionCheckedList.Items.Remove(descriptionCheckedList.Items[0]);
            }
            while (dialogueCheckedList.Items.Count > 0)
            {
                dialogueCheckedList.Items.Remove(dialogueCheckedList.Items[0]);
            }
            while (conversationCheckedList.Items.Count > 0)
            {
                conversationCheckedList.Items.Remove(conversationCheckedList.Items[0]);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (checkTextIsValid(objectNameTextBox.Text, "Object Name") && checkDescriptionTextIsValid())
            {
                generatedLabel.Text = "Created the file: ...\\" + asGenerator.getObjectName();
                asGenerator.generateAS();
                resetAllFields();
            }
        }

        private Boolean validateObjectName(string objectName)
        {
            Regex re = new Regex("^[0-9a-zA-Z]+$");
            return (re.IsMatch(objectNameTextBox.Text));
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            resetAllFields();
        }

        private Boolean checkTextIsValid(string targetText, string objectName)
        {
            if (targetText.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show(objectName + " cannot be left blank");
                return false;
            }
            else
            {
                double Num;
                bool isNum = double.TryParse(targetText.Substring(0, 1), out Num);
                if (isNum)
                {
                    System.Windows.Forms.MessageBox.Show(objectName + " must start with a letter");
                    return false;
                }
            }

            return true;
        }

        private Boolean checkDescriptionTextIsValid()
        {
            if (shortDescTextBox.Text.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("Short description cannot be left blank");
                return false;
            }
            else if (longDescTextBox.Text.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("Long description cannot be left blank");
                return false;
            }

            return true;
        }

        private void setLayout(ObjectType type)
        {
            layoutState = type;
            asGenerator.setType(type);

            switch (layoutState)
            {
                case ObjectType.ITEM:
                    itemPickupCheckBox.Visible = true;
                    addNPCsPanel.Visible = false;
                    addItemPanel.Visible = false;
                    aliasPanel.Visible = true;
                    exitsPanel.Visible = false;
                    descriptionPanel.Visible = false;
                    addDialoguePanel.Visible = false;
                    addConversationPanel.Visible = false;
                    break;
                case ObjectType.NPC:
                    itemPickupCheckBox.Visible = false;
                    addNPCsPanel.Visible = false;
                    addItemPanel.Visible = false;
                    aliasPanel.Visible = true;
                    exitsPanel.Visible = false;
                    descriptionPanel.Visible = false;
                    addDialoguePanel.Visible = true;
                    addConversationPanel.Visible = true;
                    break;
                case ObjectType.ROOM:
                    itemPickupCheckBox.Visible = false;
                    addNPCsPanel.Visible = true;
                    addItemPanel.Visible = true;
                    aliasPanel.Visible = false;
                    exitsPanel.Visible = true;
                    descriptionPanel.Visible = true;
                    addDialoguePanel.Visible = false;
                    addConversationPanel.Visible = false;
                    break;
                default:
                    return;
            }
        }

        private void objectName_TextChanged(object sender, EventArgs e)
        {
            if (validateObjectName(objectNameTextBox.Text))
            {
                generateButton.Enabled = true;
                objectNameErrorLabel.Text = "";
            }
            else
            {
                generateButton.Enabled = false;
                objectNameErrorLabel.Text = "Object name cannot contain spaces or symbols. You cannot generate this object until these are removed.";
            }

            asGenerator.setObjectName(objectNameTextBox.Text);
        }

        private void itemRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setLayout(ObjectType.ITEM);
        }

        private void npcRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setLayout(ObjectType.NPC);
        }

        private void roomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setLayout(ObjectType.ROOM);
        }

        private void shortDescTextBox_TextChanged(object sender, EventArgs e)
        {
            asGenerator.setShort(shortDescTextBox.Text);
        }

        private void longDescTextBox_TextChanged(object sender, EventArgs e)
        {
            string parseNewLinesForAS = longDescTextBox.Text.Replace(Environment.NewLine, @"\n'+" + "\n					'");
            asGenerator.setLong(parseNewLinesForAS);
        }

        private void aliasTextBox_TextChanged(object sender, EventArgs e)
        {
            string parseNewLinesForAS = aliasTextBox.Text.Replace(Environment.NewLine, "','");
            asGenerator.setAliases("'" + parseNewLinesForAS + "'");
        }

        private void directionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void itemPickupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            asGenerator.setItemGettable(itemPickupCheckBox.Checked);
        }
 
// Add exits
        private void findExitLocationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileName = "";
                string fileName = "" + openFileDialog1.FileName;

                int objectPath = fileName.IndexOf("\\src\\objects\\rooms\\");
                if (objectPath == -1)
                {
                    System.Windows.Forms.MessageBox.Show(@"That is not a valid file. Exit files must be inside the \src\objects\rooms folder of your project folder.");
                    return;
                }

                string fileExtension = fileName.Substring(fileName.Length - 3, 3);
                if (fileExtension != ".as")
                {
                    System.Windows.Forms.MessageBox.Show("That is not a valid file. Exit files must be .as files.");
                    return;
                }

                string[] path = fileName.Split('\\');
                exitLocationLabel.Text = "... "+path[path.Length - 1];
                this.fileName = fileName.Substring(objectPath, (fileName.Length - objectPath));
            }
        }

        private void addExitButton_Click(object sender, EventArgs e)
        {
            string directionText = directionTextBox.Text;

            if (!checkTextIsValid(directionTextBox.Text, "Exit direction"))
                return;

            if (!checkTextIsValid(fileName, "Exit location"))
                return;

            if (asGenerator.doesExitExist(directionText, fileName))
            {
                System.Windows.Forms.MessageBox.Show("This direction or location for this exit already exists. You must remove it from the list to add this current exit.");
                return;
            }

            string[] path = fileName.Split('\\');
            exitsCheckedList.Items.Add(directionText + " - " + path[path.Length - 1], false);

            asGenerator.addExit(directionText, fileName);

            directionTextBox.Text = exitLocationLabel.Text = "";
            fileName = "";
        }

        private void removeExitsButton_Click(object sender, EventArgs e)
        {
            while (exitsCheckedList.CheckedItems.Count > 0)
            {
                string checkedItem = ""+exitsCheckedList.CheckedItems[0].ToString();
                string[] path = checkedItem.Split('-');
                asGenerator.removeExit(path[0].Trim());
                
                exitsCheckedList.Items.Remove(exitsCheckedList.CheckedItems[0]);
            }
        }

// Add NPCs
        private void addNPCsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string npcName = "" + openFileDialog1.FileName;

                int objectPath = npcName.IndexOf("\\src\\objects\\npcs\\");
                if (objectPath == -1)
                {
                    System.Windows.Forms.MessageBox.Show(@"That is not a valid file. NPC files must be inside the \src\objects\npcs folder of your project folder.");
                    return;
                }

                string fileExtension = npcName.Substring(npcName.Length - 3, 3);
                if (fileExtension != ".as")
                {
                    System.Windows.Forms.MessageBox.Show("That is not a valid file. NPC files must be .as files.");
                    return;
                }

                if (asGenerator.doesNPCExist(npcName))
                {
                    System.Windows.Forms.MessageBox.Show("This NPC has already been added to the room.");
                    return;
                }

                string[] path = npcName.Split('\\');
                addedNPCsCheckedList.Items.Add(path[path.Length - 1], false);
                
                asGenerator.addNPC(path[path.Length - 1], npcName);
            }
        }

        private void removeCheckedNPCsButton_Click(object sender, EventArgs e)
        {
            while (addedNPCsCheckedList.CheckedItems.Count > 0)
            {
                asGenerator.removeNPC(addedNPCsCheckedList.CheckedItems[0].ToString());

                addedNPCsCheckedList.Items.Remove(addedNPCsCheckedList.CheckedItems[0]);
            }
        }

// Add gettable items
        private void addItemButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string itemName = "" + openFileDialog1.FileName;

                int objectPath = itemName.IndexOf("\\src\\objects\\gettables\\");
                if (objectPath == -1)
                {
                    System.Windows.Forms.MessageBox.Show(@"That is not a valid file. Item files must be inside the \src\objects\gettables folder of your project folder.");
                    return;
                }

                string fileExtension = itemName.Substring(itemName.Length - 3, 3);
                if (fileExtension != ".as")
                {
                    System.Windows.Forms.MessageBox.Show("That is not a valid file. Item files must be .as files.");
                    return;
                }

                if (asGenerator.doesGettableExist(itemName))
                {
                    System.Windows.Forms.MessageBox.Show("This item has already been added to the room.");
                    return;
                }

                string[] path = itemName.Split('\\');
                addedItemsCheckedList.Items.Add(path[path.Length - 1], false);

                asGenerator.addGettable(path[path.Length - 1], itemName);
            }
        }

        private void removeCheckedItemsButton_Click(object sender, EventArgs e)
        {
            while (addedItemsCheckedList.CheckedItems.Count > 0)
            {
                asGenerator.removeGettable(addedNPCsCheckedList.CheckedItems[0].ToString());

                addedItemsCheckedList.Items.Remove(addedItemsCheckedList.CheckedItems[0]);
            }
        }

// Add descriptions to a room
        private void addDescriptionButton_Click(object sender, EventArgs e)
        {
            string descriptionName = descriptionNameTextBox.Text;
            string descriptionDescription = descriptionDescriptionTextBox.Text;

            if (!checkTextIsValid(descriptionName, "Item name"))
                return;

            if (descriptionDescription == "" || descriptionDescription == " ")
            {
                System.Windows.Forms.MessageBox.Show("The item description cannot be left blank.");
                return;
            }

            if (asGenerator.doesDescriptionExist(descriptionName))
            {
                System.Windows.Forms.MessageBox.Show("This item already has a description.");
                return;
            }

            descriptionCheckedList.Items.Add(descriptionName + " - " + descriptionDescription, false);

            asGenerator.addDescription(descriptionName, descriptionDescription);

            descriptionNameTextBox.Text = descriptionDescriptionTextBox.Text = "";
        }

        private void removeCheckedDescriptionsButton_Click(object sender, EventArgs e)
        {
            while (descriptionCheckedList.CheckedItems.Count > 0)
            {
                string[] path = descriptionCheckedList.CheckedItems[0].ToString().Split('.');
                asGenerator.removeDescription(path[0].Trim());

                descriptionCheckedList.Items.Remove(descriptionCheckedList.CheckedItems[0]);
            }
        }

// Add dialogue to an NPC
        private void addDialogueButton_Click(object sender, EventArgs e)
        {
            string dialogueText = dialogueTextBox.Text;

            if (dialogueText == "" || dialogueText == " ")
            {
                System.Windows.Forms.MessageBox.Show("The NPC's dialogue cannot be left blank.");
                return;
            }

            if (asGenerator.doesDialogueExist(dialogueText))
            {
                System.Windows.Forms.MessageBox.Show("This dialogue has already been added.");
                return;
            }

            dialogueCheckedList.Items.Add(dialogueText, false);

            asGenerator.addDialogue(dialogueText);

            dialogueTextBox.Text = "";
        }

        private void removeCheckedDialogueButton_Click(object sender, EventArgs e)
        {
            while (dialogueCheckedList.CheckedItems.Count > 0)
            {
                asGenerator.removeDescription(dialogueCheckedList.CheckedItems[0].ToString());

                dialogueCheckedList.Items.Remove(dialogueCheckedList.CheckedItems[0]);
            }
        }

// Add a conversation to an NPC
        private void addConversationButton_Click(object sender, EventArgs e)
        {
            string conversationText = conversationTextBox.Text;

            if (conversationText == "" || conversationText == " ")
            {
                System.Windows.Forms.MessageBox.Show("The NPC's conversation cannot be left blank.");
                return;
            }

            if (asGenerator.doesDialogueExist(conversationText))
            {
                System.Windows.Forms.MessageBox.Show("This conversation has already been added.");
                return;
            }

            conversationCheckedList.Items.Add(conversationText, false);

            asGenerator.addConversations(conversationText);

            conversationTextBox.Text = "";
        }

        private void removeCheckedConversationsButton_Click(object sender, EventArgs e)
        {
            while (conversationCheckedList.CheckedItems.Count > 0)
            {
                asGenerator.removeConversations(conversationCheckedList.CheckedItems[0].ToString());

                conversationCheckedList.Items.Remove(conversationCheckedList.CheckedItems[0]);
            }
        }




// Manipulate the actions for objects
        private void addActionButton_Click(object sender, EventArgs e)
        {
            mainViewPanel.Visible = false;
            actionViewPanel.Visible = true;
            actionViewLabel.Text = "Adding an action to a " + layoutState.ToString().ToLower() + ".";
        }

        private void removeCheckedAction_Click(object sender, EventArgs e)
        {
            while (actionCheckedList.CheckedItems.Count > 0)
            {
                actionCheckedList.Items.Remove(actionCheckedList.CheckedItems[0]);
            }
        }

// Close the actions panel
        private void actionCancelButton_Click(object sender, EventArgs e)
        {
            mainViewPanel.Visible = true;
            actionViewPanel.Visible = false;
        }

        private void actionConfirmButton_Click(object sender, EventArgs e)
        {
            mainViewPanel.Visible = true;
            actionViewPanel.Visible = false;
        }

// Manipulate the lists of keywords for each action
        private void actionKeywordButton_Click(object sender, EventArgs e)
        {
            string parseNewLinesForAS = "'" + actionKeywordTextBox.Text.Replace(Environment.NewLine, "','") + "'";

            actionKeywordCheckedList.Items.Add(parseNewLinesForAS, false);

            actionKeywordTextBox.Text = "";
        }

        private void actionRemoveCheckedKeywordButton_Click(object sender, EventArgs e)
        {
            while (actionKeywordCheckedList.CheckedItems.Count > 0)
            {
                actionKeywordCheckedList.Items.Remove(actionKeywordCheckedList.CheckedItems[0]);
            }
        }

// Manipulate the required parameter
        string requiredFilePath;

        private void addObjectRequiredButton_Click(object sender, EventArgs e)
        {
            string requiredPath = "";
            ObjectType requiredItemType = ObjectType.NONE;
            if (requiredItemRadio.Checked)
            {
                requiredItemType = ObjectType.ITEM;
                requiredPath = "\\src\\objects\\gettables\\";
            }
            else if (requiredNPCRadio.Checked)
            {
                requiredItemType = ObjectType.NPC;
                requiredPath = "\\src\\objects\\npcs\\";
            }
            else if (requiredRoomRadio.Checked)
            {
                requiredItemType = ObjectType.ROOM;
                requiredPath = "\\src\\objects\\rooms\\";
            }

            if (requiredItemType == ObjectType.NONE)
            {
                System.Windows.Forms.MessageBox.Show("You must select an item type for the required parameter.");
                return;
            }

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileName = "";
                string fileName = "" + openFileDialog1.FileName;

                int objectPath = fileName.IndexOf(requiredPath);
                if (objectPath == -1)
                {
                    System.Windows.Forms.MessageBox.Show(@"That is not a valid file. " + layoutState.ToString().ToLower() + " files must be inside the " + requiredPath + " folder of your project folder.");
                    return;
                }

                string fileExtension = fileName.Substring(fileName.Length - 3, 3);
                if (fileExtension != ".as")
                {
                    System.Windows.Forms.MessageBox.Show("That is not a valid file. " + layoutState.ToString().ToLower() + " files must be .as files.");
                    return;
                }

                string[] path = fileName.Split('\\');
                actionRequiredObjectLabel.Text = "... " + path[path.Length - 1];
                this.requiredFilePath = fileName.Substring(objectPath, (fileName.Length - objectPath));
            }
        }

        private void addRequiredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addRequiredCheckBox.Checked)
                actionRequiredPanel.Visible = true;
            else
                actionRequiredPanel.Visible = false;
        }

// Manipulate the excluded parameter
        string excludedFilePath;

        private void addExcludedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addExcludedCheckBox.Checked)
                actionExcludedPanel.Visible = true;
            else
                actionExcludedPanel.Visible = false;
        }

        private void addObjectExcludedButton_Click(object sender, EventArgs e)
        {
            string excludedPath = "";
            ObjectType excludedItemType = ObjectType.NONE;
            if (excludedItemRadio.Checked)
            {
                excludedItemType = ObjectType.ITEM;
                excludedPath = "\\src\\objects\\gettables\\";
            }
            else if (excludedNPCRadio.Checked)
            {
                excludedItemType = ObjectType.NPC;
                excludedPath = "\\src\\objects\\npcs\\";
            }
            else if (excludedRoomRadio.Checked)
            {
                excludedItemType = ObjectType.ROOM;
                excludedPath = "\\src\\objects\\rooms\\";
            }

            if (excludedItemType == ObjectType.NONE)
            {
                System.Windows.Forms.MessageBox.Show("You must select an item type for the excluded parameter.");
                return;
            }

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileName = "";
                string fileName = "" + openFileDialog1.FileName;

                int objectPath = fileName.IndexOf(excludedPath);
                if (objectPath == -1)
                {
                    System.Windows.Forms.MessageBox.Show(@"That is not a valid file. " + layoutState.ToString().ToLower() + " files must be inside the " + excludedPath + " folder of your project folder.");
                    return;
                }

                string fileExtension = fileName.Substring(fileName.Length - 3, 3);
                if (fileExtension != ".as")
                {
                    System.Windows.Forms.MessageBox.Show("That is not a valid file. " + layoutState.ToString().ToLower() + " files must be .as files.");
                    return;
                }

                string[] path = fileName.Split('\\');
                actionExcludedObjectLabel.Text = "... " + path[path.Length - 1];
                this.excludedFilePath = fileName.Substring(objectPath, (fileName.Length - objectPath));
            }
        }

// Manipulate the room the player is moved to
        string movePlayerPath;

        private void movePlayerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (movePlayerCheckBox.Checked)
                movePlayerToNewRoomPanel.Visible = true;
            else
                movePlayerToNewRoomPanel.Visible = false;
        }

        private void movePlayerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileName = "";
                string fileName = "" + openFileDialog1.FileName;

                int objectPath = fileName.IndexOf("\\src\\objects\\rooms\\");
                if (objectPath == -1)
                {
                    System.Windows.Forms.MessageBox.Show(@"That is not a valid file. Room files must be inside the \\src\\objects\\rooms\\ folder of your project folder.");
                    return;
                }

                string fileExtension = fileName.Substring(fileName.Length - 3, 3);
                if (fileExtension != ".as")
                {
                    System.Windows.Forms.MessageBox.Show("That is not a valid file. Room files must be .as files.");
                    return;
                }

                string[] path = fileName.Split('\\');
                movePlayerOutputLabel.Text = "... " + path[path.Length - 1];
                this.movePlayerPath = fileName.Substring(objectPath, (fileName.Length - objectPath));
            }
        }

// Manipulating NPCs in the request
        Dictionary<string, string> addNpcs = new Dictionary<string, string>();
        private void rAddNpcRemoveButton_Click(object sender, EventArgs e)
        {
            while (rAddNpcCheckList.CheckedItems.Count > 0)
            {
                rAddNpcCheckList.Items.Remove(rAddNpcCheckList.CheckedItems[0]);
            }
        }

        Dictionary<string, string> moveNpcs = new Dictionary<string, string>();
        private void rMoveNpcRemoveButton_Click(object sender, EventArgs e)
        {
            while (rMoveNpcCheckList.CheckedItems.Count > 0)
            {
                rMoveNpcCheckList.Items.Remove(rMoveNpcCheckList.CheckedItems[0]);
            }
        }

        Dictionary<string, string> removeNpcs = new Dictionary<string, string>();
        private void rRemoveNpcRemoveButton_Click(object sender, EventArgs e)
        {
            while (rRemoveNpcCheckList.CheckedItems.Count > 0)
            {
                rRemoveNpcCheckList.Items.Remove(rRemoveNpcCheckList.CheckedItems[0]);
            }
        }


// Manipulating items in the request
        Dictionary<string, string> addItem = new Dictionary<string, string>();
        private void rAddItemRemoveButton_Click(object sender, EventArgs e)
        {
            while (rAddItemCheckList.CheckedItems.Count > 0)
            {
                rAddItemCheckList.Items.Remove(rAddItemCheckList.CheckedItems[0]);
            }

        }

        Dictionary<string, string> moveItem = new Dictionary<string, string>();
        private void rMoveItemRemoveButton_Click(object sender, EventArgs e)
        {
            while (rMoveItemCheckList.CheckedItems.Count > 0)
            {
                rMoveItemCheckList.Items.Remove(rMoveItemCheckList.CheckedItems[0]);
            }
        }

        Dictionary<string, string> removeItem = new Dictionary<string, string>();
        private void rRemoveItemRemoveButton_Click(object sender, EventArgs e)
        {
            while (rRemoveItemCheckList.CheckedItems.Count > 0)
            {
                rRemoveItemCheckList.Items.Remove(rRemoveItemCheckList.CheckedItems[0]);
            }
        }



    }
    
}
