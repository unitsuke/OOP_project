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
        private int width;
        private int height;

        public StatBar(Vector2 position, Rectangle rectangle)
        {

        }
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public Rectangle Rectangle { get; set; }
        public int Width  { get; set; }
        public int Height { get; set; }
        public virtual void LoadContent(ContentManager content,string filePath)
        {
            Texture = content.Load<Texture2D>(filePath);
            Height = Texture.Height;
            Width = Texture.Width;
        }

        public void Update(GameTime gameTime, int updateValue)
        {
            Width += updateValue;
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Rectangle, Color.White);
        }
    }
}
