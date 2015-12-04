using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWRPG.HUD.StatBars
{
    class StatBar
    {
        public StatBar(Vector2 position, Texture2D texture, Rectangle rectangle)
        {
            Width = texture.Width;
            Height = texture.Height;
        }
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public Rectangle Rectangle { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void LoadContent(ContentManager content,string filePath)
        {
            Texture = content.Load<Texture2D>(filePath);
        }

        public void Update(GameTime gameTime)
        {
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Rectangle, Color.White);
        }
    }
}
