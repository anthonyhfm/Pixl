using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl.Internal
{
    public class Component : IDisposable
    {

        private GameObject parent { get; set; }

        

        public Component(GameObject s)
        {
            parent = s;
        }

        public virtual void Load()
        {
            
        }

        public virtual void Update()
        {

        }

        public void Dispose()
        {
            // Dispose Method

            throw new NotImplementedException();
        }
    }
}
