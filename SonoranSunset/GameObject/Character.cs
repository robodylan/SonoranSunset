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
    class Character : GameObject
    {
        private bool controlled;
        public Character(int x, int y, Texture2D texture, bool controlled) : base(x, y, texture, false)
        {
            this.controlled = controlled;
        }

        public override void Update(KeyboardState keyboard, List<GameObject> gameObjects)
        {
            if(controlled)
            {
                int stepY = 4;
                int stepX = 0;
                if (keyboard.IsKeyDown(Keys.A))
                {
                    stepX = -1;
                }

                if (keyboard.IsKeyDown(Keys.D))
                {
                    stepX = +1;
                }
                Recurse:
                bool collideX = false;
                bool collideY = false;
                foreach(GameObject obj in gameObjects)
                {
                    if(obj.isCollider)
                    {
                        Rectangle A = new Rectangle(x + stepX, y, texture.Width, texture.Height);
                        Rectangle B = new Rectangle(obj.x, obj.y, obj.texture.Width, obj.texture.Height);
                        if (A.Intersects(B)) collideX = true;
                        A = new Rectangle(x, y + stepY, texture.Width, texture.Height);
                        if (A.Intersects(B)) collideY = true;
                    }
                }

                if(!collideX)
                {
                    this.x += stepX;
                }
                else
                {
                    stepX = stepX / 2;
                    if(stepX > 0) goto Recurse;
                }

                if (!collideY)
                {
                    this.y += stepY;
                }
                else
                {
                    stepY = stepY / 2;
                    if(stepY > 0) goto Recurse;
                }
            }
        }
    }
}
