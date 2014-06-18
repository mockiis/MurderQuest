using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MurderQuest
{
    class EmptyInput:InputManager
    {
        public override Vector2 MousePos
        {
            get
            {
                return Vector2.Zero;
            }
        }
        public override Rectangle MouseBoundaryBox
        {
            get
            {
                return Rectangle.Empty;
            }
        }

        public override bool KeyboardHold(Keys key)
        {
            return false;
        }
        public override bool KeyboardPress(Keys key)
        {
            return false;
        }
        public override bool MousePress(MouseButton button)
        {
            return false;
        }
    }
}
