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
            this.objectTypePanel.SuspendLayout();
            this.objectNamePanel.SuspendLayout();
            this.shortDescPanel.SuspendLayout();
            this.longDescPanel.SuspendLayout();
            this.aliasPanel.SuspendLayout();
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
            this.objectTypePanel.Location = new System.Drawing.Point(388, 30);
            this.objectTypePanel.Name = "objectTypePanel";
            this.objectTypePanel.Size = new System.Drawing.Size(74, 97);
            this.objectTypePanel.TabIndex = 3;
            // 
            // objectTypeLabel
            // 
            this.objectTypeLabel.AutoSize = true;
            this.objectTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.objectTypeLabel.Name = "objectTypeLabel";
            this.objectTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.objectTypeLabel.TabIndex = 3;
            this.objectTypeLabel.Text = "Object Type";
            // 
            // roomRadioButton
            // 
            this.roomRadioButton.AutoSize = true;
            this.roomRadioButton.Location = new System.Drawing.Point(6, 71);
            this.roomRadioButton.Name = "roomRadioButton";
            this.roomRadioButton.Size = new System.Drawing.Size(58, 17);
            this.roomRadioButton.TabIndex = 2;
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
            this.itemRadioButton.Checked = true;
            this.itemRadioButton.Location = new System.Drawing.Point(6, 25);
            this.itemRadioButton.Name = "itemRadioButton";
            this.itemRadioButton.Size = new System.Drawing.Size(51, 17);
            this.itemRadioButton.TabIndex = 0;
            this.itemRadioButton.TabStop = true;
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
            this.aliasPanel.Size = new System.Drawing.Size(336, 225);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.aliasPanel);
            this.Controls.Add(this.longDescPanel);
            this.Controls.Add(this.shortDescPanel);
            this.Controls.Add(this.objectNamePanel);
            this.Controls.Add(this.objectTypePanel);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

