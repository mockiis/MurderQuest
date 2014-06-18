using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MurderQuest
{
    public static class Globals
    {
        public static SpriteFont GameFont, GameFont2;
        public static Random Rand = new Random();
        public static Color StandardFontColor = Color.Wheat;

        //the resolution of the buffer
        public static Point ScreenBuffer = new Point(1920, 1080);
        //the resolution of the current screen 
        public static Point ScreenSize = new Point(1280, 720);

        //decides the real mouse position depending on the diference between the real windows size and the buffer size
        public static Vector2 ScreenMouseDif = new Vector2(1.5f,1.5f);
        public static int MouseBoxSize = 32;
    }
    //enums

    //gamescreen state
    public enum ScreenState
    {
        LOADING,
        READY,
        ONHOLD,
        DEAD
    }
    public enum MouseButton
    {
        LEFT,
        MIDDLE,
        RIGHT
    }
}
