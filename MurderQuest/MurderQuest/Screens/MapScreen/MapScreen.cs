using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TextDataXML;
using System.Xml;

namespace MurderQuest
{
    class MapScreen:GameScreen
    {
        private PeopleTextData WorkData;
        public override void LoadContent()
        {
            state = ScreenState.READY;

            WorkData = new PeopleTextData();
            ReadXMLFile();
        }
        private void ReadXMLFile()
        {
            using (XmlReader reader = XmlReader.Create("Content/XML/test.xml"))
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
        public override void Update(GameTime gameTime, InputManager input)
        {
            
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}
