using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoranSunset.Scene
{
    class Scene
    {
        public static Scene current;

        public Texture2D background;

        private int time;

        public Scene()
        {
        }

        public void Update()
        {
            time++;
        }

        private int getTime()
        {
            return time / 1;
        }

        private int setTime()
        {
            return time / 1;
        }
    }
}
