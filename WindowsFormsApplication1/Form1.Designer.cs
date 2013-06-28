namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateButton = new System.Windows.Forms.Button();
            this.objectNameTextBox = new System.Windows.Forms.TextBox();
            this.objectTypePanel = new System.Windows.Forms.Panel();
            this.objectTypeLabel = new System.Windows.Forms.Label();
            this.roomRadioButton = new System.Windows.Forms.RadioButton();
            this.npcRadioButton = new System.Windows.Forms.RadioButton();
            this.itemRadioButton = new System.Windows.Forms.RadioButton();
            this.objectNamePanel = new System.Windows.Forms.Panel();
            this.objectNameLabel = new System.Windows.Forms.Label();
            this.shortDescPanel = new System.Windows.Forms.Panel();
            this.shortDescLabel = new System.Windows.Forms.Label();
            this.shortDescTextBox = new System.Windows.Forms.TextBox();
            this.longDescPanel = new System.Windows.Forms.Panel();
            this.longDescLabel = new System.Windows.Forms.Label();
            this.longDescTextBox = new System.Windows.Forms.TextBox();
            this.aliasPanel = new System.Windows.Forms.Panel();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.exitsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.exitsLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.exitsPanel = new System.Windows.Forms.Panel();
            this.exitLocationLabel = new System.Windows.Forms.Label();
            this.addExitButton = new System.Windows.Forms.Button();
            this.findExitLocationButton = new System.Windows.Forms.Button();
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.removeExitsButton = new System.Windows.Forms.Button();
            this.itemPickupCheckBox = new System.Windows.Forms.CheckBox();
            this.addNPCsPanel = new System.Windows.Forms.Panel();
            this.removeCheckedNPCsButton = new System.Windows.Forms.Button();
            this.addNPCsButton = new System.Windows.Forms.Button();
            this.addedNPCsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.addNpcsLabel = new System.Windows.Forms.Label();
            this.addItemPanel = new System.Windows.Forms.Panel();
            this.removeCheckedItemsButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.addedItemsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.addItemLabel = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionNameLabel = new System.Windows.Forms.Label();
            this.descriptionDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addDescriptionButton = new System.Windows.Forms.Button();
            this.descriptionCheckedList = new System.Windows.Forms.CheckedListBox();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.removeCheckedDescriptionsButton = new System.Windows.Forms.Button();
            this.addDialoguePanel = new System.Windows.Forms.Panel();
            this.removeCheckedDialogueButton = new System.Windows.Forms.Button();
            this.dialogueCheckedList = new System.Windows.Forms.CheckedListBox();
            this.addDialogueButton = new System.Windows.Forms.Button();
            this.dialogueLabel = new System.Windows.Forms.Label();
            this.dialogueTextBox = new System.Windows.Forms.TextBox();
            this.addDialogueLabel = new System.Windows.Forms.Label();
            this.addConversationPanel = new System.Windows.Forms.Panel();
            this.removeCheckedConversationsButton = new System.Windows.Forms.Button();
            this.conversationCheckedList = new System.Windows.Forms.CheckedListBox();
            this.addConversationButton = new System.Windows.Forms.Button();
            this.conversationLabel = new System.Windows.Forms.Label();
            this.conversationTextBox = new System.Windows.Forms.TextBox();
            this.addConversationLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.objectTypePanel.SuspendLayout();
            this.objectNamePanel.SuspendLayout();
            this.shortDescPanel.SuspendLayout();
            this.longDescPanel.SuspendLayout();
            this.aliasPanel.SuspendLayout();
            this.exitsPanel.SuspendLayout();
            this.addNPCsPanel.SuspendLayout();
            this.addItemPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.addDialoguePanel.SuspendLayout();
            this.addConversationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(921, 695);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // objectNameTextBox
            // 
            this.objectNameTextBox.Location = new System.Drawing.Point(97, 0);
            this.objectNameTextBox.Name = "objectNameTextBox";
            this.objectNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.objectNameTextBox.TabIndex = 2;
            this.objectNameTextBox.TextChanged += new System.EventHandler(this.objectName_TextChanged);
            // 
            // objectTypePanel
            // 
            this.objectTypePanel.Controls.Add(this.objectTypeLabel);
            this.objectTypePanel.Controls.Add(this.roomRadioButton);
            this.objectTypePanel.Controls.Add(this.npcRadioButton);
            this.objectTypePanel.Controls.Add(this.itemRadioButton);
            this.objectTypePanel.Location = new System.Drawing.Point(388, 27);
            this.objectTypePanel.Name = "objectTypePanel";
            this.objectTypePanel.Size = new System.Drawing.Size(74, 97);
            this.objectTypePanel.TabIndex = 3;
            // 
            // objectTypeLabel
            // 
            this.objectTypeLabel.AutoSize = true;
            this.objectTypeLabel.Location = new System.Drawing.Point(3, 3);
            this.objectTypeLabel.Name = "objectTypeLabel";
            this.objectTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.objectTypeLabel.TabIndex = 3;
            this.objectTypeLabel.Text = "Object Type";
            // 
            // roomRadioButton
            // 
            this.roomRadioButton.AutoSize = true;
            this.roomRadioButton.Checked = true;
            this.roomRadioButton.Location = new System.Drawing.Point(6, 71);
            this.roomRadioButton.Name = "roomRadioButton";
            this.roomRadioButton.Size = new System.Drawing.Size(58, 17);
            this.roomRadioButton.TabIndex = 2;
            this.roomRadioButton.TabStop = true;
            this.roomRadioButton.Text = "ROOM";
            this.roomRadioButton.UseVisualStyleBackColor = true;
            this.roomRadioButton.CheckedChanged += new System.EventHandler(this.roomRadioButton_CheckedChanged);
            // 
            // npcRadioButton
            // 
            this.npcRadioButton.AutoSize = true;
            this.npcRadioButton.Location = new System.Drawing.Point(6, 48);
            this.npcRadioButton.Name = "npcRadioButton";
            this.npcRadioButton.Size = new System.Drawing.Size(47, 17);
            this.npcRadioButton.TabIndex = 1;
            this.npcRadioButton.Text = "NPC";
            this.npcRadioButton.UseVisualStyleBackColor = true;
            this.npcRadioButton.CheckedChanged += new System.EventHandler(this.npcRadioButton_CheckedChanged);
            // 
            // itemRadioButton
            // 
            this.itemRadioButton.AutoSize = true;
            this.itemRadioButton.Location = new System.Drawing.Point(6, 25);
            this.itemRadioButton.Name = "itemRadioButton";
            this.itemRadioButton.Size = new System.Drawing.Size(51, 17);
            this.itemRadioButton.TabIndex = 0;
            this.itemRadioButton.Text = "ITEM";
            this.itemRadioButton.UseVisualStyleBackColor = true;
            this.itemRadioButton.CheckedChanged += new System.EventHandler(this.itemRadioButton_CheckedChanged);
            // 
            // objectNamePanel
            // 
            this.objectNamePanel.Controls.Add(this.objectNameLabel);
            this.objectNamePanel.Controls.Add(this.objectNameTextBox);
            this.objectNamePanel.Location = new System.Drawing.Point(24, 27);
            this.objectNamePanel.Name = "objectNamePanel";
            this.objectNamePanel.Size = new System.Drawing.Size(336, 24);
            this.objectNamePanel.TabIndex = 4;
            // 
            // objectNameLabel
            // 
            this.objectNameLabel.AutoSize = true;
            this.objectNameLabel.Location = new System.Drawing.Point(3, 3);
            this.objectNameLabel.Name = "objectNameLabel";
            this.objectNameLabel.Size = new System.Drawing.Size(69, 13);
            this.objectNameLabel.TabIndex = 3;
            this.objectNameLabel.Text = "Object Name";
            // 
            // shortDescPanel
            // 
            this.shortDescPanel.Controls.Add(this.shortDescLabel);
            this.shortDescPanel.Controls.Add(this.shortDescTextBox);
            this.shortDescPanel.Location = new System.Drawing.Point(24, 81);
            this.shortDescPanel.Name = "shortDescPanel";
            this.shortDescPanel.Size = new System.Drawing.Size(336, 24);
            this.shortDescPanel.TabIndex = 5;
            // 
            // shortDescLabel
            // 
            this.shortDescLabel.AutoSize = true;
            this.shortDescLabel.Location = new System.Drawing.Point(3, 3);
            this.shortDescLabel.Name = "shortDescLabel";
            this.shortDescLabel.Size = new System.Drawing.Size(88, 13);
            this.shortDescLabel.TabIndex = 3;
            this.shortDescLabel.Text = "Short Description";
            // 
            // shortDescTextBox
            // 
            this.shortDescTextBox.Location = new System.Drawing.Point(97, 0);
            this.shortDescTextBox.Name = "shortDescTextBox";
            this.shortDescTextBox.Size = new System.Drawing.Size(236, 20);
            this.shortDescTextBox.TabIndex = 2;
            this.shortDescTextBox.TextChanged += new System.EventHandler(this.shortDescTextBox_TextChanged);
            // 
            // longDescPanel
            // 
            this.longDescPanel.Controls.Add(this.longDescLabel);
            this.longDescPanel.Controls.Add(this.longDescTextBox);
            this.longDescPanel.Location = new System.Drawing.Point(24, 135);
            this.longDescPanel.Name = "longDescPanel";
            this.longDescPanel.Size = new System.Drawing.Size(336, 225);
            this.longDescPanel.TabIndex = 6;
            // 
            // longDescLabel
            // 
            this.longDescLabel.AutoSize = true;
            this.longDescLabel.Location = new System.Drawing.Point(3, 3);
            this.longDescLabel.Name = "longDescLabel";
            this.longDescLabel.Size = new System.Drawing.Size(87, 13);
            this.longDescLabel.TabIndex = 3;
            this.longDescLabel.Text = "Long Description";
            // 
            // longDescTextBox
            // 
            this.longDescTextBox.Location = new System.Drawing.Point(97, 0);
            this.longDescTextBox.Multiline = true;
            this.longDescTextBox.Name = "longDescTextBox";
            this.longDescTextBox.Size = new System.Drawing.Size(236, 222);
            this.longDescTextBox.TabIndex = 2;
            this.longDescTextBox.TextChanged += new System.EventHandler(this.longDescTextBox_TextChanged);
            // 
            // aliasPanel
            // 
            this.aliasPanel.Controls.Add(this.aliasLabel);
            this.aliasPanel.Controls.Add(this.aliasTextBox);
            this.aliasPanel.Location = new System.Drawing.Point(24, 390);
            this.aliasPanel.Name = "aliasPanel";
            this.aliasPanel.Size = new System.Drawing.Size(336, 260);
            this.aliasPanel.TabIndex = 7;
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(3, 3);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(40, 13);
            this.aliasLabel.TabIndex = 3;
            this.aliasLabel.Text = "Aliases";
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.AcceptsReturn = true;
            this.aliasTextBox.Location = new System.Drawing.Point(97, 0);
            this.aliasTextBox.Multiline = true;
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(236, 222);
            this.aliasTextBox.TabIndex = 2;
            this.aliasTextBox.TextChanged += new System.EventHandler(this.aliasTextBox_TextChanged);
            // 
            // exitsCheckedList
            // 
            this.exitsCheckedList.CheckOnClick = true;
            this.exitsCheckedList.FormattingEnabled = true;
            this.exitsCheckedList.Location = new System.Drawing.Point(6, 106);
            this.exitsCheckedList.Name = "exitsCheckedList";
            this.exitsCheckedList.Size = new System.Drawing.Size(244, 154);
            this.exitsCheckedList.TabIndex = 8;
            // 
            // exitsLabel
            // 
            this.exitsLabel.AutoSize = true;
            this.exitsLabel.Location = new System.Drawing.Point(3, 3);
            this.exitsLabel.Name = "exitsLabel";
            this.exitsLabel.Size = new System.Drawing.Size(61, 13);
            this.exitsLabel.TabIndex = 9;
            this.exitsLabel.Text = "Add an Exit";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(3, 29);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(49, 13);
            this.directionLabel.TabIndex = 10;
            this.directionLabel.Text = "Direction";
            // 
            // exitsPanel
            // 
            this.exitsPanel.Controls.Add(this.removeExitsButton);
            this.exitsPanel.Controls.Add(this.exitLocationLabel);
            this.exitsPanel.Controls.Add(this.addExitButton);
            this.exitsPanel.Controls.Add(this.findExitLocationButton);
            this.exitsPanel.Controls.Add(this.directionTextBox);
            this.exitsPanel.Controls.Add(this.exitsCheckedList);
            this.exitsPanel.Controls.Add(this.directionLabel);
            this.exitsPanel.Controls.Add(this.exitsLabel);
            this.exitsPanel.Location = new System.Drawing.Point(24, 390);
            this.exitsPanel.Name = "exitsPanel";
            this.exitsPanel.Size = new System.Drawing.Size(258, 297);
            this.exitsPanel.TabIndex = 11;
            // 
            // exitLocationLabel
            // 
            this.exitLocationLabel.AutoEllipsis = true;
            this.exitLocationLabel.Location = new System.Drawing.Point(11, 78);
            this.exitLocationLabel.Name = "exitLocationLabel";
            this.exitLocationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitLocationLabel.Size = new System.Drawing.Size(157, 13);
            this.exitLocationLabel.TabIndex = 14;
            // 
            // addExitButton
            // 
            this.addExitButton.Location = new System.Drawing.Point(175, 72);
            this.addExitButton.Name = "addExitButton";
            this.addExitButton.Size = new System.Drawing.Size(75, 23);
            this.addExitButton.TabIndex = 13;
            this.addExitButton.Text = "Add Exit";
            this.addExitButton.UseVisualStyleBackColor = true;
            this.addExitButton.Click += new System.EventHandler(this.addExitButton_Click);
            // 
            // findExitLocationButton
            // 
            this.findExitLocationButton.Location = new System.Drawing.Point(175, 43);
            this.findExitLocationButton.Name = "findExitLocationButton";
            this.findExitLocationButton.Size = new System.Drawing.Size(75, 23);
            this.findExitLocationButton.TabIndex = 12;
            this.findExitLocationButton.Text = "Location";
            this.findExitLocationButton.UseVisualStyleBackColor = true;
            this.findExitLocationButton.Click += new System.EventHandler(this.findExitLocationButton_Click);
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(6, 46);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.Size = new System.Drawing.Size(162, 20);
            this.directionTextBox.TabIndex = 11;
            this.directionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.directionTextBox_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // removeExitsButton
            // 
            this.removeExitsButton.Location = new System.Drawing.Point(6, 266);
            this.removeExitsButton.Name = "removeExitsButton";
            this.removeExitsButton.Size = new System.Drawing.Size(162, 23);
            this.removeExitsButton.TabIndex = 15;
            this.removeExitsButton.Text = "Remove checked exits";
            this.removeExitsButton.UseVisualStyleBackColor = true;
            this.removeExitsButton.Click += new System.EventHandler(this.removeExitsButton_Click);
            // 
            // itemPickupCheckBox
            // 
            this.itemPickupCheckBox.Checked = true;
            this.itemPickupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemPickupCheckBox.Location = new System.Drawing.Point(388, 135);
            this.itemPickupCheckBox.Name = "itemPickupCheckBox";
            this.itemPickupCheckBox.Size = new System.Drawing.Size(101, 48);
            this.itemPickupCheckBox.TabIndex = 12;
            this.itemPickupCheckBox.Text = "Player can carry this item";
            this.itemPickupCheckBox.UseVisualStyleBackColor = true;
            this.itemPickupCheckBox.CheckedChanged += new System.EventHandler(this.itemPickupCheckBox_CheckedChanged);
            // 
            // addNPCsPanel
            // 
            this.addNPCsPanel.Controls.Add(this.removeCheckedNPCsButton);
            this.addNPCsPanel.Controls.Add(this.addNPCsButton);
            this.addNPCsPanel.Controls.Add(this.addedNPCsCheckedList);
            this.addNPCsPanel.Controls.Add(this.addNpcsLabel);
            this.addNPCsPanel.Location = new System.Drawing.Point(388, 135);
            this.addNPCsPanel.Name = "addNPCsPanel";
            this.addNPCsPanel.Size = new System.Drawing.Size(188, 237);
            this.addNPCsPanel.TabIndex = 13;
            // 
            // removeCheckedNPCsButton
            // 
            this.removeCheckedNPCsButton.Location = new System.Drawing.Point(6, 209);
            this.removeCheckedNPCsButton.Name = "removeCheckedNPCsButton";
            this.removeCheckedNPCsButton.Size = new System.Drawing.Size(162, 23);
            this.removeCheckedNPCsButton.TabIndex = 15;
            this.removeCheckedNPCsButton.Text = "Remove checked NPCs";
            this.removeCheckedNPCsButton.UseVisualStyleBackColor = true;
            this.removeCheckedNPCsButton.Click += new System.EventHandler(this.removeCheckedNPCsButton_Click);
            // 
            // addNPCsButton
            // 
            this.addNPCsButton.Location = new System.Drawing.Point(6, 22);
            this.addNPCsButton.Name = "addNPCsButton";
            this.addNPCsButton.Size = new System.Drawing.Size(75, 23);
            this.addNPCsButton.TabIndex = 12;
            this.addNPCsButton.Text = "Add NPC";
            this.addNPCsButton.UseVisualStyleBackColor = true;
            this.addNPCsButton.Click += new System.EventHandler(this.addNPCsButton_Click);
            // 
            // addedNPCsCheckedList
            // 
            this.addedNPCsCheckedList.CheckOnClick = true;
            this.addedNPCsCheckedList.FormattingEnabled = true;
            this.addedNPCsCheckedList.Location = new System.Drawing.Point(6, 49);
            this.addedNPCsCheckedList.Name = "addedNPCsCheckedList";
            this.addedNPCsCheckedList.Size = new System.Drawing.Size(179, 154);
            this.addedNPCsCheckedList.TabIndex = 8;
            // 
            // addNpcsLabel
            // 
            this.addNpcsLabel.AutoSize = true;
            this.addNpcsLabel.Location = new System.Drawing.Point(3, 3);
            this.addNpcsLabel.Name = "addNpcsLabel";
            this.addNpcsLabel.Size = new System.Drawing.Size(66, 13);
            this.addNpcsLabel.TabIndex = 9;
            this.addNpcsLabel.Text = "Add an NPC";
            // 
            // addItemPanel
            // 
            this.addItemPanel.Controls.Add(this.removeCheckedItemsButton);
            this.addItemPanel.Controls.Add(this.addItemButton);
            this.addItemPanel.Controls.Add(this.addedItemsCheckedList);
            this.addItemPanel.Controls.Add(this.addItemLabel);
            this.addItemPanel.Location = new System.Drawing.Point(388, 390);
            this.addItemPanel.Name = "addItemPanel";
            this.addItemPanel.Size = new System.Drawing.Size(188, 237);
            this.addItemPanel.TabIndex = 14;
            // 
            // removeCheckedItemsButton
            // 
            this.removeCheckedItemsButton.Location = new System.Drawing.Point(6, 209);
            this.removeCheckedItemsButton.Name = "removeCheckedItemsButton";
            this.removeCheckedItemsButton.Size = new System.Drawing.Size(162, 23);
            this.removeCheckedItemsButton.TabIndex = 15;
            this.removeCheckedItemsButton.Text = "Remove checked Items";
            this.removeCheckedItemsButton.UseVisualStyleBackColor = true;
            this.removeCheckedItemsButton.Click += new System.EventHandler(this.removeCheckedItemsButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(6, 22);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 12;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // addedItemsCheckedList
            // 
            this.addedItemsCheckedList.CheckOnClick = true;
            this.addedItemsCheckedList.FormattingEnabled = true;
            this.addedItemsCheckedList.Location = new System.Drawing.Point(6, 49);
            this.addedItemsCheckedList.Name = "addedItemsCheckedList";
            this.addedItemsCheckedList.Size = new System.Drawing.Size(179, 154);
            this.addedItemsCheckedList.TabIndex = 8;
            // 
            // addItemLabel
            // 
            this.addItemLabel.AutoSize = true;
            this.addItemLabel.Location = new System.Drawing.Point(3, 3);
            this.addItemLabel.Name = "addItemLabel";
            this.addItemLabel.Size = new System.Drawing.Size(64, 13);
            this.addItemLabel.TabIndex = 9;
            this.addItemLabel.Text = "Add an Item";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.removeCheckedDescriptionsButton);
            this.descriptionPanel.Controls.Add(this.descriptionCheckedList);
            this.descriptionPanel.Controls.Add(this.addDescriptionButton);
            this.descriptionPanel.Controls.Add(this.descriptionDescriptionTextBox);
            this.descriptionPanel.Controls.Add(this.descriptionDescriptionLabel);
            this.descriptionPanel.Controls.Add(this.descriptionNameLabel);
            this.descriptionPanel.Controls.Add(this.descriptionNameTextBox);
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Location = new System.Drawing.Point(600, 135);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(280, 367);
            this.descriptionPanel.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(158, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Add a description to a room item";
            // 
            // descriptionNameTextBox
            // 
            this.descriptionNameTextBox.Location = new System.Drawing.Point(6, 42);
            this.descriptionNameTextBox.Name = "descriptionNameTextBox";
            this.descriptionNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.descriptionNameTextBox.TabIndex = 1;
            // 
            // descriptionNameLabel
            // 
            this.descriptionNameLabel.AutoSize = true;
            this.descriptionNameLabel.Location = new System.Drawing.Point(3, 24);
            this.descriptionNameLabel.Name = "descriptionNameLabel";
            this.descriptionNameLabel.Size = new System.Drawing.Size(56, 13);
            this.descriptionNameLabel.TabIndex = 2;
            this.descriptionNameLabel.Text = "Item name";
            // 
            // descriptionDescriptionLabel
            // 
            this.descriptionDescriptionLabel.AutoSize = true;
            this.descriptionDescriptionLabel.Location = new System.Drawing.Point(3, 67);
            this.descriptionDescriptionLabel.Name = "descriptionDescriptionLabel";
            this.descriptionDescriptionLabel.Size = new System.Drawing.Size(81, 13);
            this.descriptionDescriptionLabel.TabIndex = 3;
            this.descriptionDescriptionLabel.Text = "Item description";
            // 
            // descriptionDescriptionTextBox
            // 
            this.descriptionDescriptionTextBox.Location = new System.Drawing.Point(6, 85);
            this.descriptionDescriptionTextBox.Multiline = true;
            this.descriptionDescriptionTextBox.Name = "descriptionDescriptionTextBox";
            this.descriptionDescriptionTextBox.Size = new System.Drawing.Size(260, 72);
            this.descriptionDescriptionTextBox.TabIndex = 4;
            // 
            // addDescriptionButton
            // 
            this.addDescriptionButton.Location = new System.Drawing.Point(167, 39);
            this.addDescriptionButton.Name = "addDescriptionButton";
            this.addDescriptionButton.Size = new System.Drawing.Size(99, 23);
            this.addDescriptionButton.TabIndex = 5;
            this.addDescriptionButton.Text = "Add description";
            this.addDescriptionButton.UseVisualStyleBackColor = true;
            this.addDescriptionButton.Click += new System.EventHandler(this.addDescriptionButton_Click);
            // 
            // descriptionCheckedList
            // 
            this.descriptionCheckedList.CheckOnClick = true;
            this.descriptionCheckedList.FormattingEnabled = true;
            this.descriptionCheckedList.Location = new System.Drawing.Point(6, 164);
            this.descriptionCheckedList.Name = "descriptionCheckedList";
            this.descriptionCheckedList.Size = new System.Drawing.Size(260, 169);
            this.descriptionCheckedList.TabIndex = 6;
            // 
            // generatedLabel
            // 
            this.generatedLabel.Location = new System.Drawing.Point(604, 695);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(294, 23);
            this.generatedLabel.TabIndex = 16;
            // 
            // removeCheckedDescriptionsButton
            // 
            this.removeCheckedDescriptionsButton.Location = new System.Drawing.Point(6, 339);
            this.removeCheckedDescriptionsButton.Name = "removeCheckedDescriptionsButton";
            this.removeCheckedDescriptionsButton.Size = new System.Drawing.Size(215, 23);
            this.removeCheckedDescriptionsButton.TabIndex = 17;
            this.removeCheckedDescriptionsButton.Text = "Remove checked Descriptions";
            this.removeCheckedDescriptionsButton.UseVisualStyleBackColor = true;
            this.removeCheckedDescriptionsButton.Click += new System.EventHandler(this.removeCheckedDescriptionsButton_Click);
            // 
            // addDialoguePanel
            // 
            this.addDialoguePanel.Controls.Add(this.removeCheckedDialogueButton);
            this.addDialoguePanel.Controls.Add(this.dialogueCheckedList);
            this.addDialoguePanel.Controls.Add(this.addDialogueButton);
            this.addDialoguePanel.Controls.Add(this.dialogueLabel);
            this.addDialoguePanel.Controls.Add(this.dialogueTextBox);
            this.addDialoguePanel.Controls.Add(this.addDialogueLabel);
            this.addDialoguePanel.Location = new System.Drawing.Point(388, 135);
            this.addDialoguePanel.Name = "addDialoguePanel";
            this.addDialoguePanel.Size = new System.Drawing.Size(280, 251);
            this.addDialoguePanel.TabIndex = 18;
            // 
            // removeCheckedDialogueButton
            // 
            this.removeCheckedDialogueButton.Location = new System.Drawing.Point(6, 213);
            this.removeCheckedDialogueButton.Name = "removeCheckedDialogueButton";
            this.removeCheckedDialogueButton.Size = new System.Drawing.Size(215, 23);
            this.removeCheckedDialogueButton.TabIndex = 17;
            this.removeCheckedDialogueButton.Text = "Remove checked dialogue";
            this.removeCheckedDialogueButton.UseVisualStyleBackColor = true;
            this.removeCheckedDialogueButton.Click += new System.EventHandler(this.removeCheckedDialogueButton_Click);
            // 
            // dialogueCheckedList
            // 
            this.dialogueCheckedList.CheckOnClick = true;
            this.dialogueCheckedList.FormattingEnabled = true;
            this.dialogueCheckedList.Location = new System.Drawing.Point(6, 68);
            this.dialogueCheckedList.Name = "dialogueCheckedList";
            this.dialogueCheckedList.Size = new System.Drawing.Size(260, 139);
            this.dialogueCheckedList.TabIndex = 6;
            // 
            // addDialogueButton
            // 
            this.addDialogueButton.Location = new System.Drawing.Point(167, 39);
            this.addDialogueButton.Name = "addDialogueButton";
            this.addDialogueButton.Size = new System.Drawing.Size(99, 23);
            this.addDialogueButton.TabIndex = 5;
            this.addDialogueButton.Text = "Add dialogue";
            this.addDialogueButton.UseVisualStyleBackColor = true;
            this.addDialogueButton.Click += new System.EventHandler(this.addDialogueButton_Click);
            // 
            // dialogueLabel
            // 
            this.dialogueLabel.AutoSize = true;
            this.dialogueLabel.Location = new System.Drawing.Point(3, 24);
            this.dialogueLabel.Name = "dialogueLabel";
            this.dialogueLabel.Size = new System.Drawing.Size(69, 13);
            this.dialogueLabel.TabIndex = 2;
            this.dialogueLabel.Text = "Dialogue text";
            // 
            // dialogueTextBox
            // 
            this.dialogueTextBox.Location = new System.Drawing.Point(6, 42);
            this.dialogueTextBox.Name = "dialogueTextBox";
            this.dialogueTextBox.Size = new System.Drawing.Size(155, 20);
            this.dialogueTextBox.TabIndex = 1;
            // 
            // addDialogueLabel
            // 
            this.addDialogueLabel.AutoSize = true;
            this.addDialogueLabel.Location = new System.Drawing.Point(3, 3);
            this.addDialogueLabel.Name = "addDialogueLabel";
            this.addDialogueLabel.Size = new System.Drawing.Size(140, 13);
            this.addDialogueLabel.TabIndex = 0;
            this.addDialogueLabel.Text = "Add idle dialogue to an NPC";
            // 
            // addConversationPanel
            // 
            this.addConversationPanel.Controls.Add(this.removeCheckedConversationsButton);
            this.addConversationPanel.Controls.Add(this.conversationCheckedList);
            this.addConversationPanel.Controls.Add(this.addConversationButton);
            this.addConversationPanel.Controls.Add(this.conversationLabel);
            this.addConversationPanel.Controls.Add(this.conversationTextBox);
            this.addConversationPanel.Controls.Add(this.addConversationLabel);
            this.addConversationPanel.Location = new System.Drawing.Point(388, 390);
            this.addConversationPanel.Name = "addConversationPanel";
            this.addConversationPanel.Size = new System.Drawing.Size(280, 251);
            this.addConversationPanel.TabIndex = 19;
            // 
            // removeCheckedConversationsButton
            // 
            this.removeCheckedConversationsButton.Location = new System.Drawing.Point(6, 213);
            this.removeCheckedConversationsButton.Name = "removeCheckedConversationsButton";
            this.removeCheckedConversationsButton.Size = new System.Drawing.Size(215, 23);
            this.removeCheckedConversationsButton.TabIndex = 17;
            this.removeCheckedConversationsButton.Text = "Remove checked conversations";
            this.removeCheckedConversationsButton.UseVisualStyleBackColor = true;
            this.removeCheckedConversationsButton.Click += new System.EventHandler(this.removeCheckedConversationsButton_Click);
            // 
            // conversationCheckedList
            // 
            this.conversationCheckedList.CheckOnClick = true;
            this.conversationCheckedList.FormattingEnabled = true;
            this.conversationCheckedList.Location = new System.Drawing.Point(6, 68);
            this.conversationCheckedList.Name = "conversationCheckedList";
            this.conversationCheckedList.Size = new System.Drawing.Size(260, 139);
            this.conversationCheckedList.TabIndex = 6;
            // 
            // addConversationButton
            // 
            this.addConversationButton.Location = new System.Drawing.Point(167, 39);
            this.addConversationButton.Name = "addConversationButton";
            this.addConversationButton.Size = new System.Drawing.Size(99, 23);
            this.addConversationButton.TabIndex = 5;
            this.addConversationButton.Text = "Add conversation";
            this.addConversationButton.UseVisualStyleBackColor = true;
            this.addConversationButton.Click += new System.EventHandler(this.addConversationButton_Click);
            // 
            // conversationLabel
            // 
            this.conversationLabel.AutoSize = true;
            this.conversationLabel.Location = new System.Drawing.Point(3, 24);
            this.conversationLabel.Name = "conversationLabel";
            this.conversationLabel.Size = new System.Drawing.Size(89, 13);
            this.conversationLabel.TabIndex = 2;
            this.conversationLabel.Text = "Conversation text";
            // 
            // conversationTextBox
            // 
            this.conversationTextBox.Location = new System.Drawing.Point(6, 42);
            this.conversationTextBox.Name = "conversationTextBox";
            this.conversationTextBox.Size = new System.Drawing.Size(155, 20);
            this.conversationTextBox.TabIndex = 1;
            // 
            // addConversationLabel
            // 
            this.addConversationLabel.AutoSize = true;
            this.addConversationLabel.Location = new System.Drawing.Point(3, 3);
            this.addConversationLabel.Name = "addConversationLabel";
            this.addConversationLabel.Size = new System.Drawing.Size(179, 13);
            this.addConversationLabel.TabIndex = 0;
            this.addConversationLabel.Text = "Add conversation options to an NPC";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(921, 30);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 20;
            this.clearAllButton.Text = "Clear all ";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.addItemPanel);
            this.Controls.Add(this.addNPCsPanel);
            this.Controls.Add(this.itemPickupCheckBox);
            this.Controls.Add(this.exitsPanel);
            this.Controls.Add(this.aliasPanel);
            this.Controls.Add(this.longDescPanel);
            this.Controls.Add(this.shortDescPanel);
            this.Controls.Add(this.objectNamePanel);
            this.Controls.Add(this.objectTypePanel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.addConversationPanel);
            this.Controls.Add(this.addDialoguePanel);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "World Generator";
            this.objectTypePanel.ResumeLayout(false);
            this.objectTypePanel.PerformLayout();
            this.objectNamePanel.ResumeLayout(false);
            this.objectNamePanel.PerformLayout();
            this.shortDescPanel.ResumeLayout(false);
            this.shortDescPanel.PerformLayout();
            this.longDescPanel.ResumeLayout(false);
            this.longDescPanel.PerformLayout();
            this.aliasPanel.ResumeLayout(false);
            this.aliasPanel.PerformLayout();
            this.exitsPanel.ResumeLayout(false);
            this.exitsPanel.PerformLayout();
            this.addNPCsPanel.ResumeLayout(false);
            this.addNPCsPanel.PerformLayout();
            this.addItemPanel.ResumeLayout(false);
            this.addItemPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.addDialoguePanel.ResumeLayout(false);
            this.addDialoguePanel.PerformLayout();
            this.addConversationPanel.ResumeLayout(false);
            this.addConversationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox objectNameTextBox;
        private System.Windows.Forms.Panel objectTypePanel;
        private System.Windows.Forms.RadioButton roomRadioButton;
        private System.Windows.Forms.RadioButton npcRadioButton;
        private System.Windows.Forms.RadioButton itemRadioButton;
        private System.Windows.Forms.Panel objectNamePanel;
        private System.Windows.Forms.Label objectTypeLabel;
        private System.Windows.Forms.Label objectNameLabel;
        private System.Windows.Forms.Panel shortDescPanel;
        private System.Windows.Forms.Label shortDescLabel;
        private System.Windows.Forms.TextBox shortDescTextBox;
        private System.Windows.Forms.Panel longDescPanel;
        private System.Windows.Forms.Label longDescLabel;
        private System.Windows.Forms.TextBox longDescTextBox;
        private System.Windows.Forms.Panel aliasPanel;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.CheckedListBox exitsCheckedList;
        private System.Windows.Forms.Label exitsLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Panel exitsPanel;
        private System.Windows.Forms.Label exitLocationLabel;
        private System.Windows.Forms.Button addExitButton;
        private System.Windows.Forms.Button findExitLocationButton;
        private System.Windows.Forms.TextBox directionTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button removeExitsButton;
        private System.Windows.Forms.CheckBox itemPickupCheckBox;
        private System.Windows.Forms.Panel addNPCsPanel;
        private System.Windows.Forms.Button removeCheckedNPCsButton;
        private System.Windows.Forms.Button addNPCsButton;
        private System.Windows.Forms.CheckedListBox addedNPCsCheckedList;
        private System.Windows.Forms.Label addNpcsLabel;
        private System.Windows.Forms.Panel addItemPanel;
        private System.Windows.Forms.Button removeCheckedItemsButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.CheckedListBox addedItemsCheckedList;
        private System.Windows.Forms.Label addItemLabel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.CheckedListBox descriptionCheckedList;
        private System.Windows.Forms.Button addDescriptionButton;
        private System.Windows.Forms.TextBox descriptionDescriptionTextBox;
        private System.Windows.Forms.Label descriptionDescriptionLabel;
        private System.Windows.Forms.Label descriptionNameLabel;
        private System.Windows.Forms.TextBox descriptionNameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label generatedLabel;
        private System.Windows.Forms.Button removeCheckedDescriptionsButton;
        private System.Windows.Forms.Panel addDialoguePanel;
        private System.Windows.Forms.Button removeCheckedDialogueButton;
        private System.Windows.Forms.CheckedListBox dialogueCheckedList;
        private System.Windows.Forms.Button addDialogueButton;
        private System.Windows.Forms.Label dialogueLabel;
        private System.Windows.Forms.TextBox dialogueTextBox;
        private System.Windows.Forms.Label addDialogueLabel;
        private System.Windows.Forms.Panel addConversationPanel;
        private System.Windows.Forms.Button removeCheckedConversationsButton;
        private System.Windows.Forms.CheckedListBox conversationCheckedList;
        private System.Windows.Forms.Button addConversationButton;
        private System.Windows.Forms.Label conversationLabel;
        private System.Windows.Forms.TextBox conversationTextBox;
        private System.Windows.Forms.Label addConversationLabel;
        private System.Windows.Forms.Button clearAllButton;
    }
}

