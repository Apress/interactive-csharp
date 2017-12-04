using System;

namespace IndexerEx1
    {
        class Program
        {
            class MySentence
            {
                string[] wordsArray;
                public MySentence(string mySentence)
                {
                    wordsArray = mySentence.Split();
                }
                public string this[int index]
                {
                    get
                    {
                        return wordsArray[index];
                    }
                    set
                    {
                        wordsArray[index] = value;
                    }
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("***Exploring Indexers.Example-1***\n");
                string mySentence = "This is a nice day.";
                MySentence sentenceObject = new MySentence(mySentence);
                for (int i = 0; i < mySentence.Split().Length; i++)
                {
                    Console.WriteLine("\t sentenceObject[{0}]={1}", i, sentenceObject[i]);
                }
                Console.ReadKey();
            }
        }
    }

