using System;
namespace Composite
{
    public class Player : IDrawable
    {
        public Player()
        {
        }

        public void Draw()
        {
            Console.WriteLine("Player Drawn");
        }
    }
}
