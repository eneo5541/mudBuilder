using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            asGenerator = new ASGenerator();
            fileName = "";
            setLayout(ObjectType.ROOM);
            InitializeComponent();
        }


        private void generateButton_Click(object sender, EventArgs e)
        {
            if (checkObjectTextIsValid() && checkDescriptionTextIsValid())
                asGenerator.generateAS();
        }

        private Boolean checkObjectTextIsValid()
        {
            if (objectNameTextBox.Text.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("Object name cannot be left blank");
                return false;
            }
            else
            {
                double Num;
                bool isNum = double.TryParse(objectNameTextBox.Text.Substring(0, 1), out Num);
                if (isNum)
                {
                    System.Windows.Forms.MessageBox.Show("Object name must start with a letter");
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
        }

        private void objectName_TextChanged(object sender, EventArgs e)
        {
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
            string parseNewLinesForAS = longDescTextBox.Text.Replace(Environment.NewLine, @"\n\n'+" + "\n					'");
            asGenerator.setLong(parseNewLinesForAS);
        }

        private void aliasTextBox_TextChanged(object sender, EventArgs e)
        {
            string parseNewLinesForAS = aliasTextBox.Text.Replace(Environment.NewLine, "','");
            asGenerator.setAliases(parseNewLinesForAS);
        }

        private void directionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        
        private void findExitLocationButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
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
            
            if (fileName.Length == 0 || directionText.Length == 0)
            {
                System.Windows.Forms.MessageBox.Show("You must enter a valid direction and a valid location to add an exit.");
                return;
            }

            string[] path = fileName.Split('\\');
            exitsCheckedList.Items.Add(directionText + " - " + path[path.Length - 1], true);
            directionTextBox.Text = exitLocationLabel.Text = "";
            fileName = "";
        }

    }
    
}
