using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl.Internal
{
    public class Level : IDisposable
    {
        private List<GameObject> gameObjects = new List<GameObject>();

        public void Instantiate(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public static void Change(Level e) // Level Changer
        {
            Runtime.mono.currentLevel = e;
        }

        public virtual void Initialize()
        {
            foreach(GameObject e in gameObjects)
            {
                e.Initialize();
            }
        }

        public virtual void Update()
        {
            foreach (GameObject e in gameObjects)
            {
                e.Update();
            }
        }

        public virtual void LoadContent()
        {
            foreach (GameObject e in gameObjects)
            {
                e.LoadContent();
            }
        }

        public virtual void Draw()
        {
            foreach (GameObject e in gameObjects)
            {
                e.Draw();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
