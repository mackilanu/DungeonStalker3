using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonStalker0._1.MainGameFolder.GameObjects
{
    class GameObject
    {
        #region Variables
        protected Texture2D texture;
        protected Rectangle sourceRectangle;
        protected Rectangle hitbox;
        protected Vector2 position;
        protected Vector2 origin;

        float scale = 1;
        float rotation;


        #endregion

        #region Initializing process
        public GameObject(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;

            Initialize();
        }

        public GameObject(Vector2 position)
        {
            this.position = position;
        }

        private void Initialize()
        {
            hitbox = new Rectangle(0, 0,
                texture.Width, texture.Height);

            sourceRectangle = new Rectangle(0, 0,
                texture.Width, texture.Height);

            // Find origin of texture
            origin.X = texture.Width / 2;
            origin.Y = texture.Height / 2;

            rotation = 1.5f;
        }
        #endregion

        #region Drawing
        /// <summary>
        /// Draws an object with a stored texture
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, Color.White, rotation, origin, scale, SpriteEffects.None, 0);
        }

       /// <summary>
       /// Draws an object with a given texture
       /// </summary>
       /// <param name="spriteBatch"></param>
       /// <param name="texture"></param>

        public void Draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, Color.White, rotation, origin, scale, SpriteEffects.None, 0);
        }
        #endregion

    }
}
