using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SonoranSunset
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D blank;
        Scene menu;
        Scene level;
        Character player;
        Character chuck;
        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            graphics.IsFullScreen = true;
            menu = new Scene();
            level = new Scene();

            Scene.current = level;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Utils.Level.load(level, Content);
            player = new Character(0,0, Content.Load<Texture2D>("spineboy-walk"), true);
            //player.texture = Content.Load<Texture2D>("Player");
            level.gameObjects.Add(player);

            blank = new Texture2D(GraphicsDevice, 1, 1);
        }

        protected override void UnloadContent()
        {
            blank.Dispose();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (GameObject obj in Scene.current.gameObjects)
            {
                obj.Update(Keyboard.GetState(), Scene.current.gameObjects);
            }

            Scene.current.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.AliceBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(Scene.current.background, new Rectangle(0,0,graphics.GraphicsDevice.DisplayMode.Width, graphics.GraphicsDevice.DisplayMode.Height), new Rectangle(0, 255 - Scene.current.getTime(), 1, 1), Color.White);
            foreach(GameObject obj in Scene.current. gameObjects)
            {
                spriteBatch.Draw(obj.texture, new Vector2(obj.x - (player.x - ((1920 / 2) - (player.getSourceRect().Width / 2))), obj.y), obj.getSourceRect(), Color.White, 0f, new Vector2(0,0), 1f, obj.effect, 1);
            }

            blank.SetData<Color>(new Color[] { new Color(Color.DarkOrange, 255) });
            spriteBatch.Draw(blank, new Rectangle(0,0,1920,1080), new Color(Color.Black, Scene.current.getTime()));
            spriteBatch.Draw(blank, new Rectangle(0, 0, 1920, 200), new Color(Color.Black, 255));
            spriteBatch.Draw(blank, new Rectangle(0, 1080 - 200, 1920, 1080), new Color(Color.Black, 255));
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
