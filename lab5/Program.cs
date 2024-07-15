using lab5.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<HtmlElement> list = new List<HtmlElement>();
            imageElement im = new imageElement("https/images/image1", "jpg");
            list.Add(im);
            textElement txt = new textElement("30", "blue");
            list.Add((txt));
            h1Element hOne = new h1Element();
            h2elemnt hTwo=new h2elemnt();
            list.Add((hTwo));
            list.Add((hOne));

            foreach (HtmlElement e in list)
            {
                e.render();
            }
            Console.ReadKey();

        }
    }
}
