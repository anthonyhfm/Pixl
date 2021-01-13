using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl.Systems
{
    public class Input
    {

        public static bool KeyDown(Keys e)
        {
            if (Keyboard.GetState().IsKeyDown(e))
                return true;
            else
                return false;
        }

        public static bool KeyUp(Keys e)
        {
            if (Keyboard.GetState().IsKeyUp(e))
                return true;
            else
                return false;
        }

    }
}
