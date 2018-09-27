using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuApp
{
    class Binding
    {
        public static double DoThis()
        {
            string heightString, widthString;
            double width, height, rectAngle;

            Console.WriteLine("Indtast første variabel");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            Console.WriteLine("Indtast anden variabel");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            rectAngle = width * height;
            Console.WriteLine("Rektangel er lig med" + rectAngle);

            return width * height;
        }
        /*Koble menuvalg fra SmartMenu 
        til det udleverede softwarebibliotek 
        FunctionLibrary*/
        /* fx. tast 4 target menu 4 dosomething */
    }
}
