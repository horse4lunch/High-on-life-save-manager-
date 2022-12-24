

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
        static string tempDataPath = filePath + @"ManagedSaves\Data\tempData";
        static string dataPath = filePath + @"ManagedSaves\Data";


        public static void Main(string[] args)
        {
            
            string cloneDir = filePath;


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ayo horse4lunch made this jawn");
            Console.WriteLine("...");
            Console.WriteLine("High On Life Save Manager 2.0");
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
                try
                {
                    
                    
                        string[] save1 = Directory.GetDirectories(saves[0]);
                        for (int i = 0; i < save1[0].Length; i++)
                        {

                        }
                        if (Directory.Exists(save1[0]))
                        {
                            
                           // Console.WriteLine("first time setup is completed_Debug");
                            
                        }
                        
                    
                }
                catch
                {
                    //this is where code that should only be ran the first time the program should go
                   // Console.WriteLine("First time setup is not complete");
                    FirstTimeSetup();
                }
            
                Console.ForegroundColor = ConsoleColor.Red;
                
                string[] selectFolder = { "Select yo save folder handsome", "Ayo top g select your save folder","Select a save folder or get out", "Select that save folder jawn","Would you please select a save folder"  };
                int randomNumber;
                Random rng = new System.Random();
                randomNumber = rng.Next(0, 4);
                // Console.WriteLine(selectFolder[randomNumber]);
                Console.WriteLine("Type the number of the save you would like to load and press Enter");
                Console.WriteLine("...");
                Console.WriteLine("Type [B] and press to Backup current save");
                Console.WriteLine("...");
                Console.WriteLine("Type [R] and press enter to Load your backup file");
                Console.WriteLine("...");
                Console.WriteLine("Type [S] and press enter to show your managed saves");
                Console.ForegroundColor = ConsoleColor.White;


                DirectoryInfo dirInfo = new DirectoryInfo(delDir);
                string _09Folder = dirInfo.Name;
                var input = Console.ReadLine();

                if (Int32.TryParse(input, out int userInput) && userInput >= 0 && userInput <= 50)
                {
                    
                    DeleteDirectory(delDir, true);
                    CloneDirectory(saves[userInput], cloneDir);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your save has been loaded");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                }

                if (input == "b")
                {
                    DeleteDirectory(saves[42], true);
                    CloneDirectory(dirContents[0], Path.Combine(saves[42] , _09Folder));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your backup has been created");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (input == "r")
                {
                    DeleteDirectory(delDir, true);
                    CloneDirectory(saves[42], cloneDir);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your backup has been loaded");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (input == "s")
                {
                    
                    for (int i = 0; i < saves.Length; i++)
                    {
                        DirectoryInfo saveInfo = new DirectoryInfo(saves[i]);
                        Console.WriteLine(saveInfo.Name);
                    }
                }
               
                if (input == "debug")
                {
                    try
                    {
                        ConvertSaveFiles("*");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: {0}", ex.Message);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }

                



            }
            
            
        }
        public static void CreateDirectory(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (IOException)
            {
                
            }
            catch (UnauthorizedAccessException)
            {
                
            }

        }
        public static void CloneFile(string root, string dest)
        {
            try
            {
                File.Copy(root, dest);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("clone file not found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("auth");
            }
            catch (IOException)
            {
                Console.WriteLine("clone file io");
            }
        }
        private static void CloneDirectory(string root, string dest)
        {
            try
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
            catch
            {
                Console.WriteLine("Cloning a directory failed");
            }
        }
        public static void DeleteFile(string fileName)
        {
            try
            {
                File.Delete(fileName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("delete no file found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("auth");

            }
            catch (IOException)
            {
               Console.WriteLine("delete file io");

            }
        }
        public static void DeleteDirectory(string directoryName, bool checkDirectiryExist)
        {
            try
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



                if (Directory.Exists(directoryName) && isManagedSaves != true)
                {
                    Directory.Delete(directoryName, true);
                }
                else if (checkDirectiryExist)
                {
                    Console.WriteLine("The folder you tried to delete doesnt exist Please restart the application");
                }
            }
            catch { Console.WriteLine("deleting a directory failed"); }
            
        }

        public static void BackUpCurrentSave(string directoryName, bool checkDirectoryExist)
        {
            string[] dirContents = Directory.GetDirectories(filePath);
            for (int i = 0; i < dirContents.Length; i++)
            {

            }
        }
        
        public static void Generate09Folders()
        {
            string[] dirContents = Directory.GetDirectories(filePath);
            for (int i = 0; i < dirContents.Length; i++)
            {

            }
            string delDir = dirContents[0];
            DirectoryInfo dirInfo = new DirectoryInfo(delDir);
            string _09Folder = dirInfo.Name;

            string[] saves = Directory.GetDirectories(filePath + "\\ManagedSaves");
            for (int i = 0; i < saves.Length; i++)
            {
               //DeleteDirectory(Path.Combine(saves[i], _09Folder), true);
                CloneDirectory(delDir, Path.Combine(saves[i], _09Folder));  
                




                

            }
            

            string[] _09Contents = Directory.GetDirectories(Path.Combine(filePath, _09Folder));
            for (int i = 0; i < _09Contents.Length; i++)
            {
                
            }





        }

        



        public static void FirstTimeSetup()
        {








            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It looks like youre doing the first time setup please check the included ReadMe for instructions");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;



            string[] dirContents = Directory.GetDirectories(filePath);
            for (int i = 0; i < dirContents.Length; i++)
            {

            }
            string delDir = dirContents[0];
            DirectoryInfo dirInfo = new DirectoryInfo(delDir);
            string _09Folder = dirInfo.Name;

            string[] saves = Directory.GetDirectories(filePath + "\\ManagedSaves");
            for (int i = 0; i < saves.Length; i++)
            {
                
                

            }
            
            // creating an array of the _09 folder
            string[] _09Contents = Directory.GetDirectories(Path.Combine(filePath, _09Folder));
            
            for (int i = 0; i < _09Contents.Length; i++)
            {
               
            }
            // finding folder sizes to seperate profile.sav from slot0 and slotswap
            DirectoryInfo[] directories = { new DirectoryInfo(_09Contents[0]), new DirectoryInfo(_09Contents[1]), new DirectoryInfo(_09Contents[2]) };

            var sortedDirectories = from d in directories orderby GetDirectorySize(d) descending select d;
            
            long GetDirectorySize(DirectoryInfo directory)
            {
                long size = 0;
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    size += file.Length;
                }
                DirectoryInfo[] subDirectories = directory.GetDirectories();
                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    size += GetDirectorySize(subDirectory);
                }
                return size;
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This is the first time setup this will only need to be done once");
            Console.ForegroundColor = ConsoleColor.White;

            var profileSavDirInfo = sortedDirectories.OrderByDescending(d => GetDirectorySize(d)).Last();

            

            string profileSavDir = profileSavDirInfo.ToString();
            string profileSavDirName = profileSavDirInfo.Name;


            // cloning the profilesavedir to tempdata and deleting the container file
            // CreateDirectory(Path.Combine(tempDataPath + profileSavDirName));
            CloneDirectory(profileSavDir, tempDataPath);
            string[] profileSavDirClone = Directory.GetFiles(tempDataPath);
            
            FileInfo[] files = new DirectoryInfo(tempDataPath).GetFiles();
            FileInfo[] sortedFilesInfo = files.OrderBy(f => f.Length).ToArray();

            var tempContainerFileInfo = sortedFilesInfo.OrderByDescending(f => f.Length).Last();
            var tempProfileFileInfo = sortedFilesInfo.OrderByDescending(f => f.Length).First();

            string tempProfileFileName = tempProfileFileInfo.Name;
            
            string containerFile = tempContainerFileInfo.ToString();

            DeleteFile(containerFile);
            



                //selecting your dodge profile
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Type the number to the left of the key you would like dodge to be bound to and press Enter");
            Console.ForegroundColor = ConsoleColor.White;
            string[] dodgeContents = Directory.GetFiles(dataPath + @"\Dodge_keybind_profiles");
            for (int x = 0; x < dodgeContents.Length; x++)
            {


                DirectoryInfo DodgefileInfo = new DirectoryInfo(dodgeContents[x]);


                Console.WriteLine(DodgefileInfo.Name);



            }
            var input = Console.ReadLine();

            if (Int32.TryParse(input, out int userInput) && userInput >= 0 && userInput <= 16)
            {
                DeleteFile(profileSavDir + @"\" + tempProfileFileName);
                CloneFile(dodgeContents[userInput], profileSavDir + @"\" + tempProfileFileName);
                
            }
            Console.ForegroundColor =ConsoleColor.Red;
            Console.WriteLine("Reopen the game and setup your keybinds you can change any bind except (Slide Bash/Dodge)");
            Console.WriteLine("Once you have them setup correctly change your sensetivity and press apply");
            Console.WriteLine("Please make sure to check the keybinds once they are set you will have to redo the first time setup to change them");
            
            Console.WriteLine("Once your keybinds are set press any key to continue");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The save manager will close when it is finished");
           
            Console.ForegroundColor =ConsoleColor.White;    
            Console.ReadKey();
            
            DeleteFile(tempProfileFileInfo.ToString());
            Generate09Folders();
            DeleteDirectory(dataPath + @"\" + _09Folder, true);
            
            ConvertSaveFiles("*");
            


        }


        public static void ConvertSaveFiles(string profilename)
        {

            string[] dirContents = Directory.GetDirectories(filePath);
            for (int i = 0; i < dirContents.Length; i++)
            {

            }
            string delDir = dirContents[0];
            DirectoryInfo dirInfo = new DirectoryInfo(delDir);
            string _09Folder = dirInfo.Name;


            string[] saves = Directory.GetDirectories(filePath + "\\ManagedSaves");
            for (int i = 0; i < saves.Length; i++)
            {

                // CloneDirectory(Path.Combine(saves[i], _09Folder), Path.Combine(tempDataPath, _09Folder));


                Console.WriteLine("loading");
                // logic for converting saves in temp folders goes here
                //DeleteDirectory(Path.Combine(saves[i], _09Folder, profilename), true);

                string[] _09Contents = Directory.GetDirectories(Path.Combine(saves[i], _09Folder));

                for (int v = 0; v < _09Contents.Length; v++)
                {

                }
                DirectoryInfo[] directories = { new DirectoryInfo(_09Contents[0]), new DirectoryInfo(_09Contents[1]), new DirectoryInfo(_09Contents[2]) };

                var sortedDirectories = from d in directories orderby GetDirectorySize(d) descending select d;

                long GetDirectorySize(DirectoryInfo directory)
                {
                    long size = 0;
                    FileInfo[] files = directory.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        size += file.Length;
                    }
                    DirectoryInfo[] subDirectories = directory.GetDirectories();
                    foreach (DirectoryInfo subDirectory in subDirectories)
                    {
                        size += GetDirectorySize(subDirectory);
                    }
                    return size;
                }
                var profileSavDirInfo = sortedDirectories.OrderByDescending(d => GetDirectorySize(d)).Last();
                Console.WriteLine(profileSavDirInfo);

                string profileSaveDirName = profileSavDirInfo.Name;
                string profileSaveDir = profileSavDirInfo.ToString();
             
                Console.WriteLine("Cloning profile.sav to tempdata and deleting from main");
                Directory.CreateDirectory(Path.Combine(tempDataPath, profileSaveDirName));
                CloneDirectory(profileSaveDir, Path.Combine(tempDataPath, profileSaveDirName));
                DeleteDirectory(profileSaveDir, true);
                

                

                

                string[] saveSlots = Directory.GetDirectories(Path.Combine(saves[i], _09Folder));
                for (int s = 0; s < saveSlots.Length; s++)
                {
                    DirectoryInfo slot0Info = new DirectoryInfo(saveSlots[0]);
                    DirectoryInfo slot1Info = new DirectoryInfo(saveSlots[1]);
                    string slot0Name = slot0Info.Name;
                    string slot1Name = slot1Info.Name;


                }






                string[] slot0 = Directory.GetFiles(Path.Combine(saves[i], _09Folder, saveSlots[0]));
                for (int q = 0; q < slot0.Length; q++)
                {



                }
                FileInfo[] slot0Files = new DirectoryInfo((Path.Combine(saves[i], _09Folder, saveSlots[0]))).GetFiles();
                FileInfo[] sortedSlot0FilesInfo = slot0Files.OrderBy(f => f.Length).ToArray();

                var containerFileInfo = sortedSlot0FilesInfo.OrderByDescending(f => f.Length).Last();
                var saveFileInfo = sortedSlot0FilesInfo.OrderByDescending(f => f.Length).First();

                string saveFileName = saveFileInfo.Name;

                string containerFile = containerFileInfo.ToString();


                CloneFile(saveFileInfo.ToString(), tempDataPath + @"\" + saveFileName);
                Console.WriteLine("Should be deleting the file around now");
                
                DeleteFile(saveFileInfo.ToString());
                DeleteFile(tempDataPath + @"\" + saveFileName);
                



                string[] slot1 = Directory.GetFiles(Path.Combine(saves[i], _09Folder, saveSlots[1]));
                for (int e = 0; e < slot1.Length; e++)
                {

                }
                FileInfo[] slot1Files = new DirectoryInfo((Path.Combine(saves[i], _09Folder, saveSlots[1]))).GetFiles();
                FileInfo[] sortedSlot1FilesInfo = slot1Files.OrderBy(f => f.Length).ToArray();

                var container1FileInfo = sortedSlot1FilesInfo.OrderByDescending(f => f.Length).Last();
                var saveFile1Info = sortedSlot1FilesInfo.OrderByDescending(f => f.Length).First();

                string saveFile1Name = saveFile1Info.Name;

                string container1File = container1FileInfo.ToString();


                CloneFile(saveFile1Info.ToString(), tempDataPath + @"\" + saveFile1Name);

                
                Console.WriteLine("Should be deleting the file around now 2");
                DeleteFile(saveFile1Info.ToString());
                DeleteFile(tempDataPath + @"\" + saveFile1Name);
                
               

                string[] steamSaves = Directory.GetFiles(saves[i]);
                for (int c = 0; c < steamSaves.Length; c++)
                {






                }
                FileInfo[] steamSaveFiles = new DirectoryInfo(saves[i]).GetFiles();
                FileInfo[] sortedSteamSaveFilesInfo = steamSaveFiles.OrderBy(f => f.Length).ToArray();

                var steamSlotFileInfo = sortedSteamSaveFilesInfo.OrderByDescending(f => f.Length).Last();
                var steamSwapFileInfo = sortedSteamSaveFilesInfo.OrderByDescending(f => f.Length).First();

                string steamSlotFileName = steamSlotFileInfo.Name;

                string steamSwapFileName = steamSwapFileInfo.ToString();

                CloneFile(steamSlotFileInfo.ToString(), saveFileInfo.ToString());
                CloneFile(steamSlotFileInfo.ToString(), saveFile1Info.ToString());

                Console.WriteLine("break");

                Console.WriteLine("Recloning Profile.Sav back to main folder from temp");
                Directory.CreateDirectory(profileSaveDir);
                CloneDirectory(tempDataPath + @"\" + profileSaveDirName, profileSaveDir);
                DeleteDirectory(tempDataPath + @"\" + profileSaveDirName, true);
                DeleteFile(steamSwapFileInfo.ToString());
                DeleteFile(steamSlotFileInfo.ToString());
                
                //DeleteFile(tempDataPath + @"\" + saveFileName);
                //DeleteFile(tempDataPath + @"\" + saveFile1Name);


                /*for (int x = 0; x < saves.Length; x++)
                {
                    DeleteDirectory(_09Folder,true);

                    CloneDirectory(Path.Combine(tempDataPath, _09Folder),filePath);


                }*/








            }

        }
    }
}






