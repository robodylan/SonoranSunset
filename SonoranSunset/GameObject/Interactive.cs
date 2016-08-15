using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SonoranSunset
{
    class Interactive : GameObject
    {
        public Interactive(int x, int y, Texture2D texture, bool isCollider) : base(x, y, texture, isCollider)
        {
        }

        public override void Update(MouseState mouse, KeyboardState keyboard, List<GameObject> gameObjects)
        {
            if(mouse.LeftButton == ButtonState.Pressed)
            {
                this.isCollider = true;
            }
            if (mouse.LeftButton == ButtonState.Released)
            {
                this.isCollider = false;
            }
        }

        public override Rectangle getSourceRect()
        {
            return texture.Bounds;
        }
    }
}
