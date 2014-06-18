using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MurderQuest
{
    abstract class GameScreen
    {
        //the base screen all other screen are gonna to inherit
        protected static GameScreenManager gameManager;
        protected static ContentManager content;

        public ScreenState state = ScreenState.LOADING;

        //static important referens, content is used to load content and gamemanager to load other screens 
        public static GameScreenManager GameManager
        {
            set { gameManager = value; }
        }
        public static ContentManager Content
        {
            set { content = value; }
        }

        //methods to be inplemented
        public abstract void LoadContent();
        public abstract void Update(GameTime gameTime, InputManager input);
        public abstract void Draw(SpriteBatch spriteBatch);

    }
}
