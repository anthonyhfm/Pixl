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

        public void AddComponent(Component component)
        {
            Components.Add(component);
        }


    }
}
