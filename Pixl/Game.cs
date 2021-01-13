using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pixl.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pixl
{
    public class Game
    {
        public void Run(Level startLevel)
        {
            Runtime.mono.currentLevel = startLevel;
            Runtime.mono.Run();
        }
    }
}
