using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class Program
    {
        delegate void Output();
       // delegate void Output2();
        static void Choice2(Journal myJournal)
        {
            Output _myOutput2;
            Console.WriteLine("Вывести на экран? (Y) На экран и в файл (F)");
            string answer = Console.ReadLine();
            if (answer == "Y" | answer == "y")
            {

                _myOutput2 = myJournal.PrintDiscipline;

            }
            else
            {
                _myOutput2 = myJournal.WriteDisciplineToFile;


            }
            _myOutput2 -= myJournal.PrintDiscipline;
            _myOutput2 += myJournal.PrintDiscipline;
            _myOutput2();
        }
            static void Choice(Journal myJournal)
        {
            Output _myOutput;
            Console.WriteLine("Вывести на экран? (Y) На экран и в файл (F)");
            string answer = Console.ReadLine();
            if (answer == "Y" | answer == "y")
            {
                
                _myOutput = myJournal.PrintName;
                _myOutput += myJournal.PrintDiscipline;
            }
            else
            {
                if (answer == "F" | answer == "f")
                {
                    _myOutput = myJournal.PrintName;
                    _myOutput += myJournal.WriteNameToFile;

                }
                else
                {
                    //_myOutput = myJournal.WriteNameToFile;
                    _myOutput = myJournal.WriteDisciplineToFile;

                }

            }
           
                //_myOutput += myJournal.CopyToClipboard;
                //_myOutput += () => Console.WriteLine("Hello");
           
            _myOutput();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя студента: ");
            Console.WriteLine("Введите предмет: ");
           

            var myJournal = new Journal();
            

            myJournal.SetName(Console.ReadLine());
            myJournal.SetDiscipline(Console.ReadLine());
            Choice(myJournal);
            // var myJournal2 = new Journal();

           
           
            
           // Choice2(myJournal);

           /* Console.WriteLine(myJournal.GetFromClipboard());
            Output func = () =>
            {
                Console.WriteLine("Hello");
                Console.WriteLine("Hello".Length);
            };
            func();
            var func001(string _text) => Console.WriteLine(_text);*/
            Console.ReadKey();
        }
    }
}

