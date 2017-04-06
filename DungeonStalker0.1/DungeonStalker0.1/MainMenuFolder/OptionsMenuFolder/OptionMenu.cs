
/*
 * Author:
 *     Philip .U
 * 
 * Purpose:
 *     
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonStalker0._1.MainMenuFolder
{
    class OptionMenu
    {
        MouseState mouse;

        Cursor cursor;
        Button options;

        public OptionMenu(GraphicsDevice g, ContentManager Content)
        {
            LoadContent(Content);
            
        }

        private void LoadContent(ContentManager Content)
        {
            Button options = new Button(Content.Load<Texture2D>("OptionsMenuResources/OptionsButton_Temp"), new Vector2(100, 100));
        }

        /// <summary>
        /// Updates all option elements
        /// </summary>
        public void Update()
        {

        }

        /// <summary>
        /// Handles all mouse input
        /// </summary>
        private void MouseInput()
        {
            mouse = Mouse.GetState();

            if (mouse.LeftButton == ButtonState.Pressed)
            {

            }
        }

        /// <summary>
        /// Draws all option elements
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            options.Draw(spriteBatch);

            spriteBatch.End();
        }
    }
}
