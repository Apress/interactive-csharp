using System;
using System.IO;//For FileStream

//FileHandlingEx1

/* SPECIAL NOTE:
 * use the command: csc /t:exe /out:AnalyzingLeaksWithFileHandlingEx1.exe Program.cs to compile
 * Rule: csc /out:My.exe File.cs  <- compiles Files.cs and creates My.exe
 */
namespace AnalyzingLeaksWithFileHandlingEx1
{
  class Program
        {
            class FileOps
            {
                public void readWrite()
                {

                    for (int i = 0; i < 2000; i++)
                    {
                        String fileName = "Myfile" + i + ".txt";
                        String path = @"c:\MyFile\" + fileName;
                        {
                            FileStream fileStreamName;
                            try
                            {
                                //fileStreamName = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                using (fileStreamName = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                                {
                                    Console.WriteLine("Created file no : {0}", i);
                                    //Forcefully throwing an exception , so that we cannot close the file
                                    if (i < 2000)
                                    {
                                        throw new Exception("Forceful Exception");
                                    }
                                }
                                fileStreamName.Close();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Caught exception" + e);

                            }
                        }
                    }                   
                }
            }
            static void Main(string[] args)
            {
                #region To change console color
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;

                Console.Clear();
                #endregion

                FileOps filePtr = new FileOps();
                {
                    filePtr.readWrite();
                    Console.ReadKey();
                }
            }
        }
    }

