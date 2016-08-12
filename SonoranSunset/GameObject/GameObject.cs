using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoranSunset.GameObject
{
    abstract class GameObject
    {
        public int x;
        public int y;
        public Texture2D texture;

        public GameObject(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Update();
    }
}
