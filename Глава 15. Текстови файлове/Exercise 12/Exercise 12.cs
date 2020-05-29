using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleAppGlava15Exercises12

//Даден е текстов файл words.txt, съдържащ списък от думи, по една на ред. Напишете програма, която изтрива от файла text.txt всички
//думи, които се срещат в другия файл. Прихванете всички възможни изключения (Exceptions).

{
    class RemoveBlackListWords
    {
        static List<string> blackList = new List<string>();

        static void Main()
        {
            try
            {
                string pathText = @"C:\.........\text.txt";
                string pathBlackList = @"C:\......\blacklist.txt";
                string pathResult = @"C:\.........\result.txt";

                GetBlackWords(pathBlackList);
                ExtractTextWithoutTags(pathText, pathResult);
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
        }
        static void PrintErrorMessage(Exception error)
        {
            Console.Error.WriteLine("-> Error! {0}\n", error.Message);
        }

        static void GetBlackWords(string pathBlackList)
        {
            using (StreamReader reader = new StreamReader(pathBlackList))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(new char[] { ' ', ',', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < tokens.Length; i++)
                        if (!blackList.Contains(tokens[i])) blackList.Add(tokens[i]);
                }
            }
        }

        static void ExtractTextWithoutTags(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        for (int i = 0; i < blackList.Count; i++)
                            line = Regex.Replace(line, "\\b" + blackList[i] + "\\b", String.Empty);

                        result.WriteLine(line);
                    }
                }
            }
        }
    }
}
