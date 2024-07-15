using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.classes
{
    internal class imageElement:HtmlElement
    {

        public string src;
        public void setType(string type)
        {
            this.type = type;
        }
        public void setSrc(string type)
        {
            this.type = type;
        }
        public imageElement(string src,string type)
        {
            this.src = src;
            this.type = type;
        }

        public override void render()
        {
            Console.WriteLine($"<img type={type} src={src}></img>");
        }


    }
}
