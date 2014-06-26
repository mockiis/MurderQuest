using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TextDataXML;
using System.Xml;

namespace MQTextEditor
{
    public partial class Form1 : Form
    {
        protected PeopleTextData WorkData;
        protected string FilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            //creates new xml data
            WorkData = new PeopleTextData("farmer",10,1,2,3);
            //testing adding some random values
            WorkData.Dialogs.Add(new DialogData(1,2,0,"i see"));
            
            //add a new save file dialog and choose the new destination of the save file
            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "Xml Files|*.xml";

            if (x.ShowDialog() == DialogResult.OK)
            {
                //get the path and creates a new file
                FilePath = x.FileName;

                //File.CreateText(FilePath);
                SaveXMLFile();

                //display the info and unlock the program
                DisplayReadData();
                UnlockTheProgram();
                
            }
        }
        private void SaveXMLFile()
        {
            //creates the seetings os evrything is formated right
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            //write the xml file , it will override any xml file allready on it's path
            using (XmlWriter writer = XmlWriter.Create(FilePath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("XnaContent");
                writer.WriteElementString("Work", WorkData.Work);
                writer.WriteElementString("Age", WorkData.Age.ToString());
                writer.WriteElementString("Intelligence", WorkData.Intelligence.ToString());
                writer.WriteElementString("Strenght", WorkData.Strenght.ToString());
                writer.WriteElementString("Sanity", WorkData.Sanity.ToString());

                foreach (DialogData dialog in WorkData.Dialogs)
                {
                    writer.WriteStartElement("Dialogs");

                    writer.WriteElementString("ID", dialog.ID.ToString());
                    writer.WriteElementString("NextID", dialog.NextID.ToString());
                    writer.WriteElementString("NPCStatus", dialog.NPCStatus.ToString());
                    writer.WriteElementString("Dialog", dialog.Dialog);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "Xml Files|*.xml";
            if (x.ShowDialog() == DialogResult.OK)
            {
                //get the path and creates a new file
                FilePath = x.FileName;

                //create a new empty work file
                WorkData = new PeopleTextData();

                //read the new xml file
                ReadXMLFile();

                //display the info and unlock the program
                DisplayReadData();
                UnlockTheProgram();
            }
        }
        private void DisplayReadData()
        {
            Stats1Box.Text = WorkData.Age.ToString();
            Stats2Box.Text = WorkData.Intelligence.ToString();
            Stats3Box.Text = WorkData.Strenght.ToString();
            Stats4Box.Text = WorkData.Sanity.ToString();

            UpdateTheDialogOptions(-1);

        }
        private void UpdateTheDialogOptions(int focus)
        {
            DialogsComboBox.Items.Clear();
            foreach (DialogData dg in WorkData.Dialogs)
            {
                DialogsComboBox.Items.Add(dg.ID.ToString());
            }
            if (focus >= 0)
                DialogsComboBox.SelectedIndex = focus;
        }
        private void UnlockTheProgram()
        {
            DataBox.Enabled = true;
            SaveBtn.Enabled = true;
        }
        private void ReadXMLFile()
        {
            using (XmlReader reader = XmlReader.Create(FilePath))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "Work":
                                WorkData.Work = reader.ReadElementContentAsString();
                                break;
                            case "Age":
                                WorkData.Age = reader.ReadElementContentAsInt();
                                break;
                            case "Intelligence":
                                WorkData.Intelligence = reader.ReadElementContentAsInt();
                                break;
                            case "Strenght":
                                WorkData.Strenght = reader.ReadElementContentAsInt();
                                break;
                            case "Sanity":
                                WorkData.Sanity = reader.ReadElementContentAsInt();
                                break;
                            case "Dialogs":
                                //create new empty dialog
                                DialogData Temp = new DialogData();

                                //read next value
                                reader.ReadString();
                                Temp.ID = reader.ReadElementContentAsInt();
                                reader.ReadString();
                                Temp.NextID = reader.ReadElementContentAsInt();
                                reader.ReadString();
                                Temp.NPCStatus = reader.ReadElementContentAsInt();
                                reader.ReadString();
                                Temp.Dialog = reader.ReadElementContentAsString();
                                WorkData.Dialogs.Add(Temp);
                                break;
                        }
                    }
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveXMLFile();
            //display message box that save is complete
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            WorkData.Dialogs[DialogsComboBox.SelectedIndex].NextID = int.Parse(NextTextBox.Text);
            //the text data needs to be reformated before saved here so it knows when to brake lines 
            //or maybe later on in the game when it gets the full text data
            WorkData.Dialogs[DialogsComboBox.SelectedIndex].Dialog = DialogTextBox.Text;

            if (DialogsComboBox.SelectedIndex < WorkData.Dialogs.Count - 1)
            {
                DialogsComboBox.SelectedIndex += 1;
            }
            else
            {
                WorkData.Dialogs.Add(new DialogData(WorkData.Dialogs.Count + 1, 0, 0, ""));
                UpdateTheDialogOptions(WorkData.Dialogs.Count - 1);
            }
        }

        private void DialogsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DialogsComboBox.SelectedIndex >= 0)
            {
                NextTextBox.Text = WorkData.Dialogs[DialogsComboBox.SelectedIndex].NextID.ToString();
                DialogTextBox.Text = WorkData.Dialogs[DialogsComboBox.SelectedIndex].Dialog;
                OkBtn.Enabled = true;
            }
            
        }


    }
}
