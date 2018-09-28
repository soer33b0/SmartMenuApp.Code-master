using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SmartMenuLibrary;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"..\..\MenuSpec.txt");
            //Loads MenuSpec.txt
            
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                doesit.Add(line);
                counter++;
            }

            file.Close();
            
        }
        
        //foreach loop, readline, 

            List<string> doesit = new List<string>();
            


        public void Activate()
        {
            
            foreach (var item in doesit) //sletter alt efter ";"
            {
                Console.WriteLine(item.Substring(0, item.IndexOf(';')));
            }
            
            int switchCase = Convert.ToInt32(Console.ReadLine());

            switch(switchCase)

            {
                case 1: //beregner arealet af en rektangel
                    string heightString, widthString;
                    double width, height, rectAngle;

                    Console.WriteLine("Indtast første variabel");
                    heightString = Console.ReadLine();
                    height = double.Parse(heightString);

                    Console.WriteLine("Indtast anden variabel");
                    widthString = Console.ReadLine();
                    width = double.Parse(widthString);

                    rectAngle = width * height;
                    Console.WriteLine("Rektanglets areal er: " + rectAngle + "m2");

                    break;

                case 2:
                    Console.WriteLine("Temperaturomregning af celsius til fahrenheit");
                    string celsius = Console.ReadLine();
                    double værdi, resultat;
                    værdi = double.Parse(celsius);
                    resultat = (værdi * 9.0 / 5) + 32;
                    Console.WriteLine("Fahrenheit er: " + resultat);
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Temperaturomregning af fahrenheit til celsius");
                    string fahrenheit = Console.ReadLine();
                    double tal, resultatet;
                    tal = double.Parse(fahrenheit);
                    resultatet = (tal - 32) *(5.0 / 9.0);
                    Console.WriteLine("Fahrenheit er: " + resultatet);
                    Console.ReadKey();


                    break;
                
                case 4:

                    break;
            }
              


        }
    }
}
