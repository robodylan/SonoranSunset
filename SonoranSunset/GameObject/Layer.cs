using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace SonoranSunset
{
    class Layer : GameObject
    {
        private bool collider;
        public Layer(int x, int y, Texture2D texture, bool collider) : base(x, y, texture, collider)
        {
        }

        public override void Update(KeyboardState keyboard, List<GameObject> gameObjects)
        {
        }

        public bool isCollider()
        {
            return collider;
        }

        public override Rectangle getSourceRect()
        {
            return texture.Bounds;
        }
    }
}
