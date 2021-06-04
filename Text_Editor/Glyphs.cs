using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Text_Editor
{
    public abstract class Glyphs
    {
        public virtual void Draw(Window w)
        {
            char c;
        }

        public virtual bool Intersects(Point P)
        {
            return false;
        }

        public virtual void Insert(Glyphs g, int number)
        {

        }
        

        public virtual void Remove(Glyphs g)
        {

        }
    }
}
