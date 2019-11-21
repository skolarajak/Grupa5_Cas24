using System;
using System.Collections.Generic;
using System.IO;

namespace Cas24
{
    class FileManagement
    {

        private static string fileName = @"C:\Kurs\imenik.txt";

        public static void Store(string ime, string prezime, string adresa, string telefon)
        {
            using (StreamWriter fileHandle = new StreamWriter(fileName, true))
            {
                fileHandle.WriteLine("{0};{1};{2};{3}", ime, prezime, adresa, telefon);
            }
        }

        public static string[] Read()
        {
            List<string> listOfNames = new List<string>();
            using (StreamReader fileHandle = new StreamReader(fileName))
            {
                string fileContents = "";
                while((fileContents = fileHandle.ReadLine()) != null)
                {
                    listOfNames.Add(fileContents);
                }
            }
            return listOfNames.ToArray();
        }

        public static void SetFileName(string filePath)
        {
            fileName = filePath;
        }

        public static string GetFileName()
        {
            return fileName;
        }
    }
}
