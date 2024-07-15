using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.classes
{
    internal class h2elemnt:textElement
    {

        public h2elemnt() : base("10", "black") { }


        public override void render()
        {
            Console.WriteLine($"<h2 color={font_color} size={font_size}></h2>");
        }

    }
}
