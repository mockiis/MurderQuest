using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MurderQuest
{
    class GameScreenManager
    {
        
        private List<GameScreen> screenList = new List<GameScreen>();
        private InputManager inputManager, emptyInput;
        //private AudioManager audioManager;

        public Game1 Game;

        //checks for loading screen if all screens are loaded.
        public bool IsScreensLoaded
        {
            get
            {
                foreach (GameScreen s in screenList)
                {
                    if (s.state == ScreenState.LOADING)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public GameScreenManager(ContentManager content)
        {
            GameScreen.GameManager = this;
            GameScreen.Content = content;
            inputManager = new InputManager();
            emptyInput = new EmptyInput();

            //audioManager = new AudioManager();
        }
        public void Update(GameTime gameTime)
        {
            inputManager.Update();
            if(screenList.Count > 0)
                screenList[0].Update(gameTime, inputManager);
            for (int i = 1; i < screenList.Count; i++)
            {
                screenList[i].Update(gameTime, emptyInput);

                if (screenList[i].state== ScreenState.DEAD)
                    screenList.RemoveAt(i);
            }
            //audioManager.Update();
        }

        public void AddScreen(GameScreen screen)
        {
            screenList.Insert(0, screen);
            screenList[0].LoadContent();
        }
        //simply draws all the active screens
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = screenList.Count - 1; i >= 0; i--)
            {
                if (screenList[i].state != ScreenState.LOADING)
                {
                    screenList[i].Draw(spriteBatch);
                }
            }
        }
    }
}
