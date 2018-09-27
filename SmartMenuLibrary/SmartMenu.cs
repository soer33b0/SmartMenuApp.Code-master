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
            
            foreach (var item in doesit)
            {
                Console.WriteLine(item.Substring(0, item.IndexOf(';')));
            }
            string userinput = System.Console.ReadLine();
        }
    }
}
