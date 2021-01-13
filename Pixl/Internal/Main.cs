using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl.Internal
{
    public class Main : Microsoft.Xna.Framework.Game
    {

        public GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;

        public Level currentLevel;

        public Level loadedLevel;

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if(loadedLevel != currentLevel)
            {
                loadedLevel = currentLevel;

                loadedLevel.Initialize();
                loadedLevel.LoadContent();
            }

            loadedLevel.Update();

            base.Update(gameTime);

            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(20, 20, 30));

            loadedLevel.Draw();

            base.Draw(gameTime);
        }

    }
}
