using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonoranSunset.Utils
{
    class Level
    {
        public static void load(Scene scene, ContentManager content)
        {
            scene.setTime(0);
            scene.background = content.Load<Texture2D>("Back");
            scene.gameObjects.Add(new Layer(0,400, content.Load<Texture2D>("Ground"), true));
            scene.gameObjects.Add(new Layer(400, -67, content.Load<Texture2D>("House"), false));
        } 
    }
}
