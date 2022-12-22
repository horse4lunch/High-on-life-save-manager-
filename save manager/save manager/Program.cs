

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace SaveManager
{
    
    public class _Directory

    {
        

        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ayo horse4lunch made this jawn");
            Console.WriteLine("...");
            Console.WriteLine("Oh yea its a Save Manager for High On Life 1.3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            
            
            string filePath = AppDomain.CurrentDomain.BaseDirectory;

             
            string cloneDir = filePath;
            string[] dirContents = Directory.GetDirectories(filePath);
            for (int i = 0; i < dirContents.Length; i++)
            {
                
            }
            string delDir = dirContents[0];

            
            
            while (true)
            {
                string[] saves = Directory.GetDirectories(filePath + "\\ManagedSaves");
                for (int i = 0; i < saves.Length; i++)
                {

                }
                
                Console.ForegroundColor = ConsoleColor.Red;
                
                string[] selectFolder = { "Select yo save folder handsome", "Ayo top g select your save folder","Select a save folder or get out", "Select that save folder jawn","Would you please select a save folder"  };
                int randomNumber;
                Random rng = new System.Random();
                randomNumber = rng.Next(0, 4);
                Console.WriteLine(selectFolder[randomNumber]);
                Console.ForegroundColor = ConsoleColor.White;


                
               
                
                int userInput = Convert.ToInt32(Console.ReadLine());


                if (userInput <= 50)
                {
                    if (userInput >= 0)
                    {
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[userInput], cloneDir);
                    }
                    else
                    {
                        Console.WriteLine("poopoo");
                    }
                }
                Console.WriteLine("Save loaded you may now load another save");
            }
            
            
        }
        
        private static void CloneDirectory(string root, string dest)
        {
            foreach (var directory in Directory.GetDirectories(root))
            {
                
                var newDirectory = Path.Combine(dest, Path.GetFileName(directory));
                
                Directory.CreateDirectory(newDirectory);
                
                CloneDirectory(directory, newDirectory);


            }

            foreach (var file in Directory.GetFiles(root))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
            }
        }
        public static void DeleteDirectory(string directoryName, bool checkDirectiryExist)
        {
            bool checkManagedSaves;
            string filePath = AppDomain.CurrentDomain.BaseDirectory;
            if (filePath + "\\ManagedSaves" == directoryName)
            {
                checkManagedSaves = true;
            }
            else { checkManagedSaves = false; }



            if (Directory.Exists(directoryName) && checkManagedSaves != false)
            {
                Directory.Delete(directoryName, true);
            }
            else if (checkDirectiryExist)
            { 
                throw new SystemException("Directory you want to delete is not exist");
            }
            
            
        }

        
        

    }
}






