

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;


namespace SaveManager
{
    
    public class _Directory
    {
        static string filePath = AppDomain.CurrentDomain.BaseDirectory;

        public static void Main(string[] args)
        {
            
            string cloneDir = filePath;


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ayo horse4lunch made this jawn");
            Console.WriteLine("...");
            Console.WriteLine("Oh yea its a Save Manager for High On Life 1.5");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            
            
            
            

            
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
                Console.WriteLine("Press B to backup current save");
                Console.WriteLine("Press R to load your backup file");
                Console.ForegroundColor = ConsoleColor.White;


                
               
                
               
                if (Int32.TryParse(Console.ReadLine(), out int userInput) && userInput >= 0 && userInput <= 50)
                {
                    DeleteDirectory(delDir, true);
                    CloneDirectory(saves[userInput], cloneDir);

                }
               
                
                if (Console.ReadLine() == "b")
                {
                    DeleteDirectory(saves[0], true);
                    CloneDirectory(delDir, saves[0]);
                }
                
                if (Console.ReadLine() == "r")
                {
                    DeleteDirectory(delDir, true);
                    CloneDirectory(saves[0], cloneDir);
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
            bool isManagedSaves;
            string filePath = AppDomain.CurrentDomain.BaseDirectory;
            string managedSaves = filePath + @"ManagedSaves";
            if (managedSaves == directoryName)
            {
                isManagedSaves = true;
               
                Console.WriteLine("The folder you tried to delete doesnt exist Please restart the application");
            }
            else if (managedSaves != directoryName)
            { 
                isManagedSaves = false;
                
                

            }
            else { return; }

            

            if (Directory.Exists(directoryName)&& isManagedSaves != true)
            {
                Directory.Delete(directoryName, true);
            }
            else if (checkDirectiryExist)
            {
                Console.WriteLine("The folder you tried to delete doesnt exist Please restart the application");
            }
            
            
        }

        public static void BackUpCurrentSave(string directoryName, bool checkDirectoryExist)
        {
            string[] dirContents = Directory.GetDirectories(filePath);
            for (int i = 0; i < dirContents.Length; i++)
            {

            }
        }
        

    }
}






