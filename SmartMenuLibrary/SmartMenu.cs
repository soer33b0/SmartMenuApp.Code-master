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
        String[] englishArray, danskArray;

        public void LoadMenu(string path)
        {
            danskArray = File.ReadLines(@"..\..\" + path + "").Take(3).ToArray();
            for (int i = 0; danskArray.Length > i; i++)
            {
                Console.WriteLine(danskArray[i]);
            }


             /*int counter = 0;
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
            */
        }
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

                    Console.Write("Indtast rektanglets længde: ");
                    heightString = Console.ReadLine();
                    height = double.Parse(heightString);
                    Console.Write("Indtast rektanglets højde: ");
                    widthString = Console.ReadLine();
                    width = double.Parse(widthString);

                    rectAngle = width * height;
                    Console.WriteLine("Rektanglets areal er: " + rectAngle + " m2");

                    break;

                case 2: //Omregner celsius til fahrenheit

                    Console.WriteLine("Temperaturomregning af celsius til fahrenheit");
                    string celsius = Console.ReadLine();

                    double værdi, resultat;
                    værdi = double.Parse(celsius);
                    resultat = (værdi * 9.0 / 5) + 32;

                    Console.WriteLine("Fahrenheit er: " + resultat);
                    Console.ReadKey();

                    break;// stopper casen 
                    
                case 3: //Omregner fahrenheit til celsius

                    Console.WriteLine("Temperaturomregning af fahrenheit til celsius");
                    string fahrenheit = Console.ReadLine();

                    double tal, resultatet;
                    tal = double.Parse(fahrenheit);
                    resultatet = (tal - 32) *(5.0 / 9.0);

                    Console.WriteLine("Fahrenheit er: " + resultatet);
                    Console.ReadKey();

                    break;
                
                case 4: //Beregner sum, minimum og maximum
                    Console.WriteLine("Indlæs talserie og beregn sum, min og max");
                    Console.WriteLine("Indtast talserie (max 5 tal)");

                    int[] calcSumMinMax = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        string tallet = Console.ReadLine();
                        calcSumMinMax[i] = int.Parse(tallet);
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

                case 0:
                    Environment.Exit(0);

                    break;
                    
            }

        }
    }
}
