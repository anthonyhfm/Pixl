using Pixl.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl
{
    public class Window
    {
        public static void SetMouseVisibility(bool visibility)
        {
            Runtime.mono.IsMouseVisible = visibility;
        }

        public static void SetTitle(string title)
        {
            Runtime.mono.Window.Title = title;
        }

        public static Vector2 GetSize()
        {
            float X = Runtime.mono._graphics.PreferredBackBufferWidth;
            float Y = Runtime.mono._graphics.PreferredBackBufferHeight;

            return new Vector2(X, Y);
        }
          
        public static void SetSize(Vector2 sizes)
        {
            Runtime.mono._graphics.PreferredBackBufferWidth = (int)sizes.X;
            Runtime.mono._graphics.PreferredBackBufferHeight = (int)sizes.Y;
            Runtime.mono._graphics.ApplyChanges();
        }

        public static void ToggleFullscreen()
        {
            Runtime.mono._graphics.ToggleFullScreen();
        }

    }
}
