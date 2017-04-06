using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonStalker0._1
{
    class Cursor
    {
        #region Variables and properties
        Texture2D texture;

        Rectangle sourceRectangle;
        Rectangle hitbox;

        Vector2 position;
        Vector2 origin;

        float scale = 0.5f;
        float rotation = 0;

        public Rectangle Hitbox
        {
            get
            {
                hitbox.X = (int)position.X - (hitbox.Width / 2);
                hitbox.Y = (int)position.Y - (hitbox.Height / 2);

                return hitbox;
            }
        }
        #endregion

        public Cursor(Texture2D texture)
        {
            this.texture = texture;

            sourceRectangle = new Rectangle(0, 0,
                (int)(texture.Width), (int)(texture.Height));

            hitbox = new Rectangle(0, 0, 2, 2);

            // Calculate center of texture
            origin.X = texture.Width / 2;
            origin.Y = texture.Height / 2;
        }

        /// <summary>
        /// Update current position of the cursor
        /// </summary>
        /// <param name="cursorPosition">Coordinates for cursor</param>
        public void Update(Vector2 cursorPosition)
        {
            position = cursorPosition;
        }

        /// <summary>
        /// Draws the cursor on screen
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, Color.White, rotation, origin, scale, SpriteEffects.None, 0);
        }
    }
}
