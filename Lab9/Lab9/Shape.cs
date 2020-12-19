using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    abstract class Shape
    {
        public abstract string Color { get; set; }
        public abstract int NumOfAngles { get; set; }
        public abstract string Name { get; set; }
        public abstract void S();
        public abstract void P();
        public abstract void Draw();
    }
}
