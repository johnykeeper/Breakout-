using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Breakout
{
    public class Paddle
{
        private Texture2D _texture;
        private Rectangle _rect;
        private Rectangle _window;

        public Rectangle Rect
        {
            get {  return _rect; }
        }
        public Paddle(Texture2D texture, Rectangle rect, Rectangle window)
        {
            _texture = texture;
            _rect = rect;
            _window = window;
        }
         public void update(KeyboardState keyboardState)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _rect, Color.White);
        }


}
}
