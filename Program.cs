using System.IO;
using System;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace deleting_visible
{
    internal class Program
    {
        static void CopyToClipboard(string input)
        {
            
            try
            {
                Clipboard.SetDataObject(input, true);
                //Process.Start(new ProcessStartInfo --- intermediate
                //{
                //    FileName = "cmd",
                //    Arguments = $"/c echo {input} | clip",
                //    UseShellExecute = false,
                //    CreateNoWindow = false,
                //    RedirectStandardOutput = true
                //});
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
        [STAThread]
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                                                                            
  __________________________________________________________________________________________
 /____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"    ___          __  _ _    ___     
   /   |  ____  / /_(_) |  / (_)____                Version: 1.0.0.0
  / /| | / __ \/ __/ /| | / / / ___/                Copyright: @ 2025 Illia Kuchuhurniy
 / ___ |/ / / / /_/ / | |/ / (__  )                 Description: Anti VISUAL indexes.
/_/  |_/_/ /_/\__/_/  |___/_/____/                  OS: Win-x64");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                                                                            
  __________________________________________________________________________________________
 /____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/

");
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  - Hi! Firstly enter the index you want to be removed from the sql/txt file: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string input = Console.ReadLine()!;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  - Enter the full path to the file you want to remove the index from, or just the file name (don't forget to add .sql/.txt) if it's in the same directory with me): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string filepath = Console.ReadLine()!;
                string curdirectory = Directory.GetCurrentDirectory();
                if (!File.Exists(filepath))
                {
                    filepath = Path.Combine(curdirectory, filepath);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(@"                                                                                            
  __________________________________________________________________________________________
 /____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/
 
                                                                                            
  ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" - How would you like to save the edited file (1/2 or 3): ");
                do 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" 1 -   Save to another file \n 2 -   Overwrite the current file\n 3 -   Copy the edited text to my clipboard");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(@"                                                                                            
  __________________________________________________________________________________________
 /____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/____/
 
                                                                                            
  ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    ConsoleKeyInfo decision = Console.ReadKey(true);

                    if (decision.KeyChar == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nEnter filepath or file's name if it's located in the same directory: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        string filepath1 = Console.ReadLine()!;
                        Console.ForegroundColor = ConsoleColor.Green;
                        curdirectory = Directory.GetCurrentDirectory();
                        if (!File.Exists(filepath1))
                        {
                            filepath1 = Path.Combine(curdirectory, filepath1);
                        }
                        File.WriteAllText(filepath1, File.ReadAllText(filepath).Replace(input, ""));
                        Process.Start(new ProcessStartInfo(filepath1) { UseShellExecute = true });
                        Console.WriteLine("-- - - - - -- - -Done! -- -- - - - -- - - -");
                        break;
                    }
                        
                    else if (decision.KeyChar == '2') 
                    {
                               curdirectory = Directory.GetCurrentDirectory();
                               File.WriteAllText(filepath, File.ReadAllText(filepath).Replace(input, ""));
                               Process.Start(new ProcessStartInfo(filepath) { UseShellExecute = true });
                               Console.WriteLine(" - - -- - -- - -- Done! -- - - - - - - - - ");
                               break;
                    }
                    else if (decision.KeyChar == '3')
                    {
                        //Clipboard.SetText(File.ReadAllText(filepath).Replace(input, "")); --- easy
                        CopyToClipboard(File.ReadAllText(filepath).Replace(input, "")); // --- intermediate
                        Console.WriteLine("Done!");
                        break;
                    }
                    else
                    {   
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t - - - You didn't make a choice. I will ask again.");
                    }
                }while (true);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("WARNING! " + ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Im sorry I couldn't help you. Maybe try one more time?");
            }

            Console.WriteLine("Hope I helped you! Press Enter to quit the programm...");
            Console.ReadLine();

        }
    }
}