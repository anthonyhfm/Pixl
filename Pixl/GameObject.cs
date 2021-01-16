using System;
using System.Collections.Generic;
using System.Text;
using Pixl.Internal;

namespace Pixl
{
    public class GameObject
    {
        public Vector2 position;

        private List<Component> Components = new List<Component>();

        private List<Graphic> Graphics = new List<Graphic>();

        public void AddComponent(Component component)
        {
            Components.Add(component);
        }

        public void AddGraphics(Graphic graphic)
        {
            Graphics.Add(graphic);
        }

        public virtual void Initialize()
        {

        }

        public virtual void LoadContent()
        {
            foreach(Component e in Components)
            {
                e.Load();
            }
        }

        public virtual void Update()
        {
            foreach (Component e in Components)
            {
                e.Update();
            }
        }

        public virtual void Draw()
        {
            foreach(Graphic e in Graphics)
            {
                e.Draw();
            }
        }


    }
}
