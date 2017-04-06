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

using DungeonStalker0._1.MainGameFolder.GameObjects;

namespace DungeonStalker0._1.MainGameFolder
{
    class MainGame
    {
        Cursor cursor;
        Texture2D objectTexture;
        Vector2 objectPosition = new Vector2(100, 100);
        MouseState mouse;
        KeyboardState keyboard;
        GameObject gameobject;

        Vector2 cursorPosition;

        public MainGame(GraphicsDevice g, ContentManager Content)
        {
            LoadContent(Content);
            
        }

        private void LoadContent(ContentManager Content)
        {
            cursor = new Cursor(Content.Load<Texture2D>("small crosshair"));
            gameobject = new GameObject(Content.Load<Texture2D>("GameResources/Player_temp"), objectPosition);

        }

        public void Update(GameTime gameTime)
        {
            MouseInput();
            KeyboardInput();

            cursor.Update(cursorPosition);
        }

        #region Inputs
        /// <summary>
        /// Handles all mouse inputs
        /// </summary>
        private void MouseInput()
        {
            mouse = Mouse.GetState();

            // Get current position of cursor
            cursorPosition.X = mouse.X;
            cursorPosition.Y = mouse.Y;
        }

        /// <summary>
        /// Handles all keyboard inputs
        /// </summary>
        private void KeyboardInput()
        {

        }
        #endregion

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            cursor.Draw(spriteBatch);
            gameobject.Draw(spriteBatch);

            spriteBatch.End();
        }
    }
}
