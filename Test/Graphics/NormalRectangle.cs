using Pixl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Graphics
{
    class NormalRectangle : Graphic
    {

        public override void Draw()
        {
            Graphic.Rectangle rec = new Graphic.Rectangle();

            rec.size = new Vector2(150, 50);
            rec.position = new Vector2(100, 100);

            rec.Draw();
        }

    }
}
