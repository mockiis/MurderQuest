using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace MurderQuest
{
    class InputManager
    {
        private KeyboardState keyboardState, previousKeyboardState;
        private GamePadState[] gamepadState, previousGamePadState;
        private MouseState mouseState, previousMouseState;
        

        public virtual Vector2 MousePos//Real mouse position depending on draw window size rather than actual window size,must later on change depending on the window size
        {
            get { return new Vector2(mouseState.X * Globals.ScreenMouseDif.X, mouseState.Y * Globals.ScreenMouseDif.Y); }
        }
        public virtual Rectangle MouseBoundaryBox
        {
            get { return new Rectangle((int)MousePos.X - Globals.MouseBoxSize / 2, (int)MousePos.Y - Globals.MouseBoxSize / 2, Globals.MouseBoxSize, Globals.MouseBoxSize); }
        }

        public InputManager() { }

        public void Update()
        {
            previousKeyboardState = keyboardState;
            keyboardState = Keyboard.GetState();

            previousMouseState = mouseState;
            mouseState = Mouse.GetState();
        }
        public virtual bool KeyboardPress(Keys key)
        {
            if (keyboardState.IsKeyDown(key) && previousKeyboardState.IsKeyUp(key))
                return true;
            return false;
        }
        public virtual bool KeyboardHold(Keys key)
        {
            if (keyboardState.IsKeyDown(key) && previousKeyboardState.IsKeyDown(key))
                return true;
            return false;
        }
        public virtual bool MousePress(MouseButton button)
        {
            switch (button)
            {
                case MouseButton.LEFT:
                    {
                        if (mouseState.LeftButton == ButtonState.Pressed && previousMouseState.LeftButton != ButtonState.Pressed)
                            return true;
                    } break;
                case MouseButton.MIDDLE:
                    {
                        if (mouseState.MiddleButton == ButtonState.Pressed && previousMouseState.MiddleButton != ButtonState.Pressed)
                            return true;
                    } break;
                case MouseButton.RIGHT:
                    {
                        if (mouseState.RightButton == ButtonState.Pressed && previousMouseState.RightButton != ButtonState.Pressed)
                            return true;
                    } break;
            }
            return false;
        }


    }
}
