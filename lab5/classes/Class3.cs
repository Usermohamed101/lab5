using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.classes
{
    internal class textElement:HtmlElement
    {

       
        public string font_size;
        public string font_color;
        public void setColor(string type)
        {
            this.type = type;
        }
        public void setSize(string font_size)
        {
            this.font_size = font_size;
         
        }
        public textElement(string font_size, string font_color)
        {
            this.font_size = font_size;
            this.font_color = font_color;
        }

        public override void render()
        {
            Console.WriteLine($"<text color={font_color} size={font_size}></text>");
        }

    }
}
