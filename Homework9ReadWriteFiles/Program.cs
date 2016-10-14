using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9ReadWriteFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read and print the first line from the file only.
            // Read and print the entire text file.
            // Read and print the entire text file and capitalize all lowercase vowels.

            //Program will ask the use to choose which of the above criteria to run.

            //Menu of the program
            Console.WriteLine("1. Read and Print the first line from the File to Console.");
            Console.WriteLine("2. Read and Print the entire text file to Console. ");
            Console.WriteLine("3. Read and Print the entire text file with all lowercase vowels Captilized.");
            Console.WriteLine("Please choose the option you'd like to run.");
            int userChoice = int.Parse(Console.ReadLine());
            int lineNumber = 0;

            //Setup of the read and write
            StreamReader reader = new StreamReader("..\\..\\Shakespeare.txt");


            //First Choice 

            if (userChoice <= 0)
            {

                Console.WriteLine("Please enter a number in the menu.");
            }
            else if (userChoice == 1)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
                Console.ReadLine();
                reader.Close();
            }
            else if (userChoice == 2) //Second Choice
            {
                string line = reader.ReadLine();
                while (line != null)
                {

                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();

                }//end while
                reader.Close();

            }
            else if (userChoice == 3)  // choice
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    //converts vowels
                    string output = line.Replace('a', 'A').Replace("e", "E").Replace('i', 'I').Replace("o", "O").Replace("u", "U");
                    Console.WriteLine(output);
                    line = reader.ReadLine();
                }
                reader.Close();

            }
            Console.ReadLine();
}//end main method
      }//end Homework9ReadWriteFilesclass
}//end namespace