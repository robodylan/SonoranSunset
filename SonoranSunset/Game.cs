using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SonoranSunset
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Scene.Scene menu;
        Scene.Scene level;

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            menu = new Scene.Scene();
            level = new Scene.Scene();

            Scene.Scene.current = level;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            level.background = Content.Load<Texture2D>("Untitled");
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
            Scene.Scene.current.Update();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.AliceBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(Scene.Scene.current.background, new Rectangle(0,0,graphics.GraphicsDevice.DisplayMode.Width, graphics.GraphicsDevice.DisplayMode.Height), new Rectangle(0, 255 - Scene.Scene.current.getTime(), 1, 1),Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
