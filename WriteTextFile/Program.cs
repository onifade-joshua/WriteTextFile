using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteTextFile
{
    internal class Program
    {
        private const string filePath = @"C:\Users\joshua\Documents\sample2.txt";
        static void Main(string[] args)
        {
            //string userInput = "Hey!, Hope you're good?";
            //string responseInput = "Yeah am going to be fine by the grace of God.";

            //Getting input from the user via the console;
            Console.WriteLine("What's the latest update about the work?");
            string userInput2 = Console.ReadLine();

            Console.WriteLine("Can you outline the various plans we need to carry out.");
            string responseInput2 = Console.ReadLine();
           
            try
            {
                StreamWriter sw = new StreamWriter(filePath);
               // sw.WriteLine(userInput);
                //sw.WriteLine(responseInput);

                sw.WriteLine(userInput2);
                sw.WriteLine(responseInput2);
                sw.Close();
            }catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing the final block.");
            }
        }
    }
}
