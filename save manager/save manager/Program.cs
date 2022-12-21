

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
            Console.WriteLine("Oh yea its a Save Manager for High On Life");
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
                // Random randomNumber = new System.Random();
                string[] selectFolder = { "Select yo save folder handsome", "Ayo top g select your save folder","Select a save folder or get out", "Select that save folder jawn","Would you please select a save folder"  };
                int randomNumber;
                Random rng = new System.Random();
                randomNumber = rng.Next(0, 4);
                Console.WriteLine(selectFolder[randomNumber]);
                Console.ForegroundColor = ConsoleColor.White;
                #region 40 fucking if statements
                /*string userInput = Console.ReadLine();
                if (Console.ReadLine() == "0")
                {
                    DeleteDirectory(delDir, true);
                    CloneDirectory(saves[0], cloneDir);

                }
                else if (userInput == "1")
                {
                    DeleteDirectory(delDir, true);
                    CloneDirectory(saves[1], cloneDir);
                    Console.WriteLine("hello");
                }
                if (Console.ReadLine() == "2")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[2], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "3")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[3], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "4")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[4], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "5")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[5], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "6")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[6], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "7")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[7], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "8")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[8], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "9")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[9], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "10")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[10], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "11")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[11], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "12")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[12], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "13")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[13], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "14")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[14], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\");
                }
                if (Console.ReadLine() == "15")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[15], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "16")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[16], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "17")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[17], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "18")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[18], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "19")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[19], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "20")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[20], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "21")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[21], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "22")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[22], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "23")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[23], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "24")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[24], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "25")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[25], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "26")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[26], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "27")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[27], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "28")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[28], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "29")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[29], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "30")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[30], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "31")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[31], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "32")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[32], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "33")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[33], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "34")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[34], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "35")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[35], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "36")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[36], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "37")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[37], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "38")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[38], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "39")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[39], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "40")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[40], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
                if (Console.ReadLine() == "41")
                {
                    DeleteDirectory(@"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs\000901FB0B4E4F1A_0000000000000000000000006FB5E47F", true);
                    CloneDirectory(saves[41], @"C:\Users\jacob\AppData\Local\Packages\2637SquanchGamesInc.HighonLife_mh7dg3tfmz2cj\SystemAppData\wgs");
                }
             */
                #endregion
                string userInput = Console.ReadLine();
                switch (userInput.ToLower())
                {
                    case "0":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[0], cloneDir);
                        break;
                    case "00":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[0], cloneDir);
                        break;
                    case "1":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[1], cloneDir);
                        break;
                    case "01":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[1], cloneDir);
                        break;
                    case "2":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[2], cloneDir);
                        break;
                    case "02":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[2], cloneDir);
                        break;
                    case "3":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[3], cloneDir);
                        break;
                    case "03":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[3], cloneDir);
                        break;
                    case "4":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[4], cloneDir);
                        break;
                    case "04":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[4], cloneDir);
                        break;
                    case "5":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[5], cloneDir);
                        break;
                    case "05":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[5], cloneDir);
                        break;
                    case "6":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[6], cloneDir);
                        break;
                    case "06":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[6], cloneDir);
                        break;
                    case "7":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[7], cloneDir);
                        break;
                    case "07":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[7], cloneDir);
                        break;
                    case "8":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[8], cloneDir);
                        break;
                    case "08":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[8], cloneDir);
                        break;
                    case "9":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[9], cloneDir);
                        break;
                    case "09":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[9], cloneDir);
                        break;
                    case "10":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[10], cloneDir);
                        break;
                    case "11":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[11], cloneDir);
                        break;
                    case "12":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[12], cloneDir);
                        break;
                    case "13":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[13], cloneDir);
                        break;
                    case "14":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[14], cloneDir);
                        break;
                    case "15":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[15], cloneDir);
                        break;
                    case "16":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[16], cloneDir);
                        break;
                    case "17":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[17], cloneDir);
                        break;
                    case "18":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[18], cloneDir);
                        break;
                    case "19":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[19], cloneDir);
                        break;
                    case "20":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[20], cloneDir);
                        break;
                    case "21":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[21], cloneDir);
                        break;
                    case "22":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[22], cloneDir);
                        break;
                    case "23":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[23], cloneDir);
                        break;
                    case "24":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[24], cloneDir);
                        break;
                    case "25":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[25], cloneDir);
                        break;
                    case "26":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[26], cloneDir);
                        break;
                    case "27":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[27], cloneDir);
                        break;
                    case "28":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[28], cloneDir);
                        break;
                    case "29":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[29], cloneDir);
                        break;
                    case "30":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[30], cloneDir);
                        break;
                    case "31":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[31], cloneDir);
                        break;
                    case "32":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[32], cloneDir);
                        break;
                    case "33":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[33], cloneDir);
                        break;
                    case "34":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[34], cloneDir);
                        break;
                    case "35":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[35], cloneDir);
                        break;
                    case "36":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[36], cloneDir);
                        break;
                    case "37":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[37], cloneDir);
                        break;
                    case "38":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[38], cloneDir);
                        break;
                    case "39":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[39], cloneDir);
                        break;
                    case "40":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[40], cloneDir);
                        break;
                    case "41":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[41], cloneDir);
                        break;
                    case "42":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[42], cloneDir);
                        break;
                    case "43":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[43], cloneDir);
                        break;
                    case "44":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[44], cloneDir);
                        break;
                    case "45":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[45], cloneDir);
                        break;
                    case "46":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[46], cloneDir);
                        break;
                    case "47":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[47], cloneDir);
                        break;
                    case "48":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[48], cloneDir);
                        break;
                    case "49":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[49], cloneDir);
                        break;
                    case "50":
                        DeleteDirectory(delDir, true);
                        CloneDirectory(saves[50], cloneDir);
                        break;
                }
                Console.WriteLine("Save loaded you may now load another save");
            }
            
            
        }
        
        private static void CloneDirectory(string root, string dest)
        {
            foreach (var directory in Directory.GetDirectories(root))
            {
                //Get the path of the new directory
                var newDirectory = Path.Combine(dest, Path.GetFileName(directory));
                //Create the directory if it doesn't already exist
                Directory.CreateDirectory(newDirectory);
                //Recursively clone the directory
                CloneDirectory(directory, newDirectory);


            }

            foreach (var file in Directory.GetFiles(root))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
            }
        }
        public static void DeleteDirectory(string directoryName, bool checkDirectiryExist)
        {
            if (Directory.Exists(directoryName))
                Directory.Delete(directoryName, true);
            else if (checkDirectiryExist)
                throw new SystemException("Directory you want to delete is not exist");
            
        }

        
        

    }
}






