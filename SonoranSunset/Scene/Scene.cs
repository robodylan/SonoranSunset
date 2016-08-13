using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoranSunset
{
    class Scene
    {
        public static Scene current;

        public Texture2D background;
        public List<GameObject> gameObjects;
        private int time;

        public Scene()
        {
            gameObjects = new List<GameObject>();
        }

        public void Update()
        {
            time++;
        }

        public int getTime()
        {
            return time / 1000;
        }

        public void setTime(int time)
        {
            this.time = time;
        }
    }
}
