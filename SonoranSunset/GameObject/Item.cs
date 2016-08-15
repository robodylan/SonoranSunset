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
    class Item : GameObject
    {
        public Item(int x, int y, Texture2D texture) : base(x, y, texture, false)
        {
        }

        public override Rectangle getSourceRect()
        {
            throw new NotImplementedException();
        }

        public override void Update(MouseState mouse, KeyboardState keyboard, List<GameObject> gameObjects)
        {
            throw new NotImplementedException();
        }
    }
}
