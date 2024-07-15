using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.classes
{
    internal class h1Element :textElement
    {

        public h1Element() : base("16", "black") { }


        public override void render()
        {
            Console.WriteLine($"<h1 color={font_color} size={font_size}></h1>");
        }

    }
}
