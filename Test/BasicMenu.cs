using Pixl;
using Pixl.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class BasicMenu : Level
    {

        public override void Initialize()
        {
            Window.SetMouseVisibility(true);
        }

        public override void LoadContent()
        {
            Level.Change(new BasicLevel());
        }

        public override void Update()
        {
            
        }

        public override void Draw()
        {
            
            
        }

    }
}
