using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleAppGlava15Exercises10

//Напишете програма, която извлича от XML файл всичкия текст без таговете. Примерен входен файл:

{
    class WordOccurrences
    {
        static Dictionary<string, int> wordOccurs = new Dictionary<string, int>();

        static void Main()
        {
            try
            {
                string pathText = @"C:\.....\test.txt";
                string pathSearchedWords = @"C:\.......\words.txt";
                string pathResult = @"C:\.........\result.txt";

                GetSearchedWords(pathSearchedWords);
                GetWordOccurs(pathText, pathResult);
            }
            catch (DriveNotFoundException driveError)
            {
                PrintErrorMessage(driveError);
            }
            catch (DirectoryNotFoundException directoryError)
            {
                PrintErrorMessage(directoryError);
            }
            catch (EndOfStreamException eose)
            {
                PrintErrorMessage(eose);
            }
            catch (FileNotFoundException fnfe)
            {
                PrintErrorMessage(fnfe);
            }
            catch (FileLoadException fle)
            {
                PrintErrorMessage(fle);
            }
            catch (PathTooLongException ptle)
            {
                PrintErrorMessage(ptle);
            }
            catch (InvalidOperationException ioe)
            {
                PrintErrorMessage(ioe);
            }
        }

        static void PrintErrorMessage(Exception error)
        {
            Console.Error.WriteLine("-> Error! {0}\n", error.Message);
        }

        static void GetSearchedWords(string pathSearchedWords)
        {
            using (StreamReader reader = new StreamReader(pathSearchedWords))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(new char[] { ' ', ',', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < tokens.Length; i++)
                        if (!wordOccurs.ContainsKey(tokens[i])) wordOccurs.Add(tokens[i], 0);
                }
            }
        }

        static void GetWordOccurs(string pathText, string pathResult)
        {
            string allContent = string.Empty;

            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    allContent = reader.ReadToEnd();

                    for (int i = 0; i < wordOccurs.Count; i++)
                    {
                        KeyValuePair<string, int> word = wordOccurs.ElementAt(i);
                        int index = allContent.IndexOf(word.Key);

                        while (index != -1)
                        {
                            wordOccurs[word.Key]++;
                            index = allContent.IndexOf(word.Key, index + 1);
                        }
                    }
                }

                WriteWordOccursToFile(result);
            }
        }

        static void WriteWordOccursToFile(StreamWriter result)
        {
            foreach (KeyValuePair<string, int> word in wordOccurs.OrderByDescending(key => key.Value))
                result.WriteLine(word.Key + " -> " + word.Value + " time(s).");
        }
    }
}