using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Painter : IDraw
    {
        public Shape shape { get; set; }
        public void Draw()
        {
            shape.Draw();
        }
    }
}
