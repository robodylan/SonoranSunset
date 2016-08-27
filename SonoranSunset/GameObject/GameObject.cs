using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoranSunset
{
    abstract class GameObject
    {
        public int x;
        public int y;
        public Texture2D texture;
        public bool isCollider;
        public bool isVisible;
        public SpriteEffects effect;
        public GameObject(int x, int y, Texture2D texture, bool isCollider)
        {
            this.x = x;
            this.y = y;
            this.texture = texture;
            this.isCollider = isCollider;
            this.isVisible = true;
        }

        public abstract void Update(MouseState mouse, KeyboardState keyboard, List<GameObject> gameObjects, Character player);
        public abstract Rectangle getSourceRect();
    }
}
