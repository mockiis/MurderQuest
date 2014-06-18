using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Windows.Forms;

namespace MurderQuest
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private GameScreenManager gameScreenManager;
        private VirtualScreen virtualScreen;

        public bool quitgame = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //the window size
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
        }
        public void ChangeBufferSize(int width, int height)
        {
            graphics.PreferredBackBufferWidth = width;
            graphics.PreferredBackBufferHeight = height;
            graphics.ApplyChanges();
            virtualScreen = new VirtualScreen(Globals.ScreenBuffer.X, Globals.ScreenBuffer.Y, GraphicsDevice);
            Globals.ScreenMouseDif = new Vector2(Globals.ScreenBuffer.X/(float)width,Globals.ScreenBuffer.Y/(float)height);
            Window.ClientSizeChanged += new EventHandler<EventArgs>(Window_ClientSizeChanged);
        }
        private void Window_ClientSizeChanged(object sender, EventArgs e)
        {
            virtualScreen.PhysicalResolutionChanged();
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Camera2D.graphicsDevice = GraphicsDevice;

            gameScreenManager = new GameScreenManager(Content);
            gameScreenManager.Game = this;


            gameScreenManager.AddScreen(new MapScreen());
            virtualScreen = new VirtualScreen(Globals.ScreenBuffer.X, Globals.ScreenBuffer.Y, GraphicsDevice);
            Window.ClientSizeChanged += new EventHandler<EventArgs>(Window_ClientSizeChanged);

            //IsMouseVisible = false;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        public void screenMode(bool Borderless, bool fullscreen)
        {
            if (fullscreen && !graphics.IsFullScreen)
            {
                //this.graphics.IsFullScreen = true;
                graphics.ToggleFullScreen();
            }
            else
            {
                graphics.IsFullScreen = false;
                Application.EnableVisualStyles();
                Form gameForm = (Form)Form.FromHandle(Window.Handle);
                if (Borderless)
                    gameForm.FormBorderStyle = FormBorderStyle.None;
                else
                    gameForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
            graphics.ApplyChanges();
        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (quitgame)
                this.Exit();

            // TODO: Add your update logic here
            gameScreenManager.Update(gameTime);
            virtualScreen.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //capture screen
            virtualScreen.BeginCapture();
            GraphicsDevice.Clear(Color.Black);
            gameScreenManager.Draw(spriteBatch);
            virtualScreen.EndCapture();

            //redraw it on new buffer size
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.LinearClamp, null, null);
            virtualScreen.Draw(spriteBatch);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
