using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Week5Lab2
{
    /*
    1.	Add a background to the existing screen. You could do that as a Simple Sprite or just as a texture.
    2.	Add a new Animated Sprite object called Collectable. It is stationary.
    3.	When your player Animated Sprite (which moves using ASWD) collides with the Collectable
    a.	Play a sound
    b.	Make the Collectable sprite disappear. 
        i.	Give the Animated Sprite a public bool property called alive.
        ii.	Only check for collision if the Collectable is alive.
        iii.	Only update an Animated Sprite if it is alive
        iv.	Only Draw the an Animated Sprite if it is alive
    4.	Make an array of 5 Collectable Animated Sprites and position them at various positions in the Viewport.
    5.	Collect all the collectables.
    6.	Make a score variable in the game class. Display the score at vector position 20,20
    7.	You get 100 points for every Collectable collected.
    8.	When all the Collectables are collected Display a Game over screen.

    */
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {

            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }
    }
}
