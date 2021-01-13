using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl.Internal
{
    public class Level : IDisposable
    {
        public static void Change(Level e) // Level Changer
        {
            Runtime.mono.currentLevel = e;
        }

        public virtual void Initialize()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void LoadContent()
        {

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
