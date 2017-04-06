using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonStalker0._1.MainMenuFolder
{
    class MainMenu
    {
        #region Variables
        Cursor cursor;

        Button playButton;

        MouseState mouse;

        Vector2 cursorPosition;

        int screenHeight;
        int screenWidth;
        #endregion
        

        public MainMenu(GraphicsDevice g, ContentManager Content)
        {
            screenHeight = g.Viewport.Bounds.Height;
            screenWidth = g.Viewport.Bounds.Width;

            LoadContent(Content);
        }

        /// <summary>
        /// Loads all neccessary resources and conent
        /// </summary>
        /// <param name="Content"></param>
        private void LoadContent(ContentManager Content)
        {
            cursor = new Cursor(Content.Load<Texture2D>("small crosshair"));
            

            playButton = new Button(Content.Load<Texture2D>("MenuResources/playButtonTemp"),
                new Vector2(screenWidth / 2, screenHeight / 2));
        }

        /// <summary>
        /// Updates all the elements in the menu
        /// </summary>
        public void Update()
        {
            MouseInput();

            cursor.Update(cursorPosition);
        }

        /// <summary>
        /// Handles all input from the mouse
        /// </summary>
        private void MouseInput()
        {
            mouse = Mouse.GetState();

            if (mouse.LeftButton == ButtonState.Pressed)
            {
                if (cursor.Hitbox.Intersects(playButton.Hitbox))
                    Game1.gameState = Game1.GameState.Game;
            }

            // Make sure the cursor doesn't leave the screen
            if (mouse.X < 0)
            {
                Mouse.SetPosition(0, mouse.Y);
            }

            else if (mouse.X > screenWidth)
            {
                Mouse.SetPosition(screenWidth, mouse.Y);
            }

            if (mouse.Y < 0)
            {
                Mouse.SetPosition(mouse.X, 0);
            }

            else if (mouse.Y > screenHeight)
            {
                Mouse.SetPosition(mouse.X, screenHeight);
            }

            // Get the current position of the cursor
            cursorPosition.X = mouse.X;
            cursorPosition.Y = mouse.Y;
        }

        /// <summary>
        /// Draws all menu elements
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            playButton.Draw(spriteBatch);
            cursor.Draw(spriteBatch);
            
            spriteBatch.End();
        }
    }
}
