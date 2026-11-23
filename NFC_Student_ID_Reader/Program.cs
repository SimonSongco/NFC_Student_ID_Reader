using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NFC_Student_ID_Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DatabasePath = ("StudentDatabase.txt");
            string InputUID = Console.ReadLine();
            Console.Clear();

            foreach (string line in File.ReadAllLines(DatabasePath))
            {
                string[] parts = line.Split('\t');

                string UID = parts[0];
                string StudentNO = parts[1];
                string StudentName = parts[2];
                
                if (InputUID == UID)
                {
                    Console.WriteLine($"ID Number: {parts[0]}");
                    Console.WriteLine($"Student Number: {parts[1]}");
                    Console.WriteLine($"Student Name: {parts[2]}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Not in the Database!");
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
