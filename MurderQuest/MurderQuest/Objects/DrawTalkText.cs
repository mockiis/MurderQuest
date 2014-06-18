using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MurderQuest
{
    class DrawTalkText
    {
        private float elapsed,time, size;

        private string textToDraw="";

        private SpriteFont spriteFont;
        private int textCharCount=0,  charStartPos=0;
        private List<string> textDrawList = new List<string>();
        private List<Vector2> textPosList = new List<Vector2>();
        private List<Color> textColorList = new List<Color>();

        //just testing

        public bool Done = false;
        public bool TextDone
        {
            get { return textCharCount == textToDraw.Length; }
        }
        public DrawTalkText(string _text, Vector2 _StartPosition, float _textSize , float _time )
        {

            textToDraw=_text;
            time = _time;
            //starts the list with position and empty string
            textPosList.Add(_StartPosition);
            textDrawList.Add("");
            textColorList.Add(Globals.StandardFontColor);//start Color

            size=_textSize;
            spriteFont = Globals.GameFont;
        }


        public void Update(GameTime gameTime)
        {
            elapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (textCharCount < textToDraw.Length)
            {
                if (elapsed >= time)
                {
                    elapsed-=time;
                    if (textToDraw.Substring(textCharCount, 1) == "#")//special color text inbound or new line
                    {
                        //adds new string, pos and color
                        textDrawList.Add("");
                        textPosList.Add(new Vector2(textPosList[textPosList.Count - 1].X + spriteFont.MeasureString(textDrawList[textPosList.Count - 1]).X * size, textPosList[textPosList.Count-1].Y));
                        textColorList.Add(Globals.StandardFontColor);

                        //loads the next char after the # command
                        string nextComand = textToDraw.Substring(textCharCount+1, 1);
                        switch (nextComand)
                        {
                                //double # = new line
                            case "#": { textPosList[textPosList.Count - 1] = new Vector2(textPosList[0].X, textPosList[0].Y + spriteFont.MeasureString("H").Y * size * 1.5f); } break;
                                //colors
                            case "R": { textColorList[textColorList.Count - 1] = Color.Red; } break;
                            case "B": { textColorList[textColorList.Count - 1] = Color.Blue; } break;
                        }
                        charStartPos = textCharCount +2;
                        textCharCount++;
                    }
                    else
                    {
                        textDrawList[textDrawList.Count-1] = textToDraw.Substring(charStartPos, (textCharCount+1 - charStartPos));
                    }

                    textCharCount++;
                    //AudioManager.PlaySound(SoundFXName.DoorOpen);
                }
               
                
            }
            else // the text have now all been draw, wait a bit and then kill it
            {
                if (elapsed >= 1.0f)
                    Done = true;
            }

            
        }
        public void Skip()
        {
            time = 0;
            elapsed = 0;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //draw text 
            for (int i = 0; i < textDrawList.Count; i++)
                spriteBatch.DrawString(spriteFont, textDrawList[i], textPosList[i], textColorList[i], 0, Vector2.Zero, size, SpriteEffects.None, 0.101f);
        }
    }
}
