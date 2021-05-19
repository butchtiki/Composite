using System;
namespace Composite
{
    public class Mountain : IDrawable
    {
        public Mountain()
        {

        }

        public void Draw()
        {
            Console.WriteLine("Mountain Drawn");
        }
    }
}
