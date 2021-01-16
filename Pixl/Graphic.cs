using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pixl.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl
{
    public class Graphic : IDisposable
    {
        public GraphicsDevice GraphicsDevice = Runtime.mono.GraphicsDevice;

        public SpriteBatch SpriteBatch = Runtime.mono._spriteBatch;

        public class Rectangle : Graphic
        {
            public Vector2 size;
            public Vector2 position;
            public Color color = Color.White;

            public override void Draw()
            {
                Texture2D _texture;

                _texture = new Texture2D(GraphicsDevice, 1, 1);
                _texture.SetData(new Color[] { color });

                SpriteBatch.Begin();
                SpriteBatch.Draw(_texture, new Microsoft.Xna.Framework.Vector2(position.X, position.Y), new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y), Color.White);
                SpriteBatch.End();
            }
        }


        public virtual void Draw()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
