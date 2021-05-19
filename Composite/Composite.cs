using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : IDrawable
    {
        List<IDrawable> drawableList;

        public Composite()
        {
            drawableList = new List<IDrawable>();
        }

        public void Add(IDrawable member)
        {
            drawableList.Add(member);
        }

        public void Remove(IDrawable member)
        {
            drawableList.Remove(member);
        }

        public List<IDrawable> GetChildren()
        {
            return drawableList;
        }

        public void Draw()
        {
            foreach(IDrawable d in drawableList)
            {
                d.Draw();
            }
        }
    }
}
