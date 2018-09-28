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
                    Console.WriteLine("nej");
                    break;

                case 3:
                    

                    break;
                
                case 4:
                    Console.WriteLine("== Indlæs talserie og beregn sum, min og max =====================");
                    Console.WriteLine("Indtast talserie (max 5 tal)");

                    int[] calcSumMinMax = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        string tal = Console.ReadLine();
                        calcSumMinMax[i] = int.Parse(tal);
                    }

                    int sum = 0;
                    for (int i = 0; i < calcSumMinMax.Length; ++i)
                    {
                        sum = calcSumMinMax[i] + sum;
                    }

                    Console.WriteLine("Sum af talserie: " + sum);
                    Console.WriteLine("Minimum af talserie: " + calcSumMinMax.Min());
                    Console.WriteLine("Maximum af talserie: " + calcSumMinMax.Max());

                    break;
            }
              


        }
    }
}
