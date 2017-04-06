using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonStalker0._1.MainMenuFolder
{
    class Button
    {
        #region Variables and properties
        Texture2D texture;

        Rectangle hitbox;
        Rectangle sourceRectangle;

        Vector2 position;
        Vector2 origin;

        float scale = 1;
        float rotation = 0;

        public Rectangle Hitbox { get { return hitbox; } }
        #endregion

        /// <summary>
        /// Standard initialization of button
        /// </summary>
        /// <param name="texture">Texture for the button</param>
        /// <param name="position">Position where button should be located (center of texture)</param>
        public Button(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;

            Initialize();
        }

        /// <summary>
        /// Initializes the button and let's you change the scale of the button
        /// </summary>
        /// <param name="texture">Texture of button</param>
        /// <param name="position">Position where button should be located (center of texture)</param>
        /// <param name="scale">The scale in wich the button should be drawn</param>
        public Button(Texture2D texture, Vector2 position, float scale)
        {
            this.texture = texture;
            this.position = position;
            this.scale = scale;

            Initialize();
        }

        /// <summary>
        /// Initialize some base values
        /// </summary>
        private void Initialize()
        {
            // Find center of texture
            origin.X = texture.Width / 2;
            origin.Y = texture.Height / 2;

            sourceRectangle = new Rectangle(0, 0,
                texture.Width, texture.Height);

            hitbox = new Rectangle((int)(position.X - origin.X), (int)(position.Y - origin.Y),
                (int)(texture.Width * scale), (int)(texture.Height * scale));
        }
        
        /// <summary>
        /// Draw button on screen
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, Color.White, rotation, origin, scale, SpriteEffects.None, 0);
        }
    }
}
