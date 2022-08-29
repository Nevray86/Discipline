using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class Journal
    {
        public static string NameOfStudent = "John Dow", Discipline = "Discipline";
        public static byte Mark = 0;
        public static DateTime DateOfMark = DateTime.Now;
        private static string path = "Journal.txt";
        //private object ClipboardService;
        public void SetDiscipline(string _title)
        {
            Discipline = _title;
        }
        public void PrintDiscipline()
        {
            Console.WriteLine(Discipline);
        }
        public void SetName(string _name)
        {
            NameOfStudent = _name;
        }
        public string GetName()
        {
            return NameOfStudent;
        }
        public void PrintName()
        {
            Console.WriteLine(NameOfStudent);
        }
        public void WriteNameToFile()
        {
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = myDocs + "\\" + path;

            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(NameOfStudent);
           


            Console.WriteLine("Информация добавлена в файл {0}.", path);
            
        }
        public void WriteDisciplineToFile()
        {
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = myDocs + "\\" + path;
            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(Discipline);
           

            Console.WriteLine("Информация добавлена в файл {0}.", path);
        }
        
        /*public void CopyToClipboard()
        {
            //CopyToClipboard.SetText("Hello, clipboard");
            ClipboardService.SetText(NameOfStudent);
            Console.WriteLine("Информация добавлена в буфер обмена.");
        }
        public string GetFromClipboard()
        {
            return ClipboardService.GetText();
        }*/
    }
}
