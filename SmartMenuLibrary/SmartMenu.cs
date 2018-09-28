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
                
                    
            }

        }
    }
}
