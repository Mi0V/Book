using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using static System.Console;

namespace Book
{
    [Serializable]
    class Book
    {
        
        public string russianWord { get; set; }
        public string englishWord { get; set; }
        int _id;
        public Book() { }

        public Book(int id)
        {
           _id = id;
        }
        public override string ToString()
        {
            return $"Русский перевод: {russianWord}, Английский перевод: {englishWord}, Id: {_id}.";
        }
    }

    class Metods
    {
        public void CreateFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    WriteLine("Файл создан");
                }
            }
        }
        
        public void WriteFile(string filePath, string rusWord, string englishWord)
        {
            using(FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                using(StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    
                    sw.Write($"Слово: {rusWord}| перевод: {englishWord}");

                }
            }
        }
        public void DeleteFile(string filePath, string[] rusWord)
        {
            using(FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                using(StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {

                    sw.Write("Все слова:");

                }
            }
        }

        public void ReadWord(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    WriteLine($"последняя запись: {sr.ReadToEnd()}");
                }
            }
        }

        public void Search()
        {
            Write("Ведите слово, перевод которого хотите найти: ");
            string word = ReadLine();
            ReadWord("Book.txt");
            if(word == "Book.txt")
            {
                
                List<string> list = new List<string>();
                list.Add(word);
                foreach(string i in list)
                {
                    Write
                }
                WriteLine($"Все слова - {list}"); // Как Из файла достать занчения?

                Write(" "); //Вывод слова и перевода
            }
            else
            {
                WriteLine("Такого слова в словаре нет");

            }
            

        }
        public void AddWord()
        {
            WriteLine("Введите слово, которое хотите добавить: ");
            WriteLine("Введите русcкое слово для добавления в словарь");
            string rusWord = ReadLine();
            WriteLine("Введите английской слово для добавления перевода в словарь");
            string englishWord = ReadLine();
            WriteFile("Book.txt", rusWord, englishWord);
            WriteLine("Слово записано в словарь");

        }

        public void DeleteWord()
        {
            WriteLine("Введите слово которое хотите удалить?");
            string rusWord = ReadLine();
            List<string> list = new List<string>;                      ///Как можно Значения из файла записать List?
            foreach
            {

            }


            //DeleteFile("Book");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Metods metods = new Metods();
            string filePath = "Book.txt";
            //metods.CreateFile(filePath);
            metods.AddWord();
            metods.ReadWord(filePath);
            metods.Search();
            ReadKey();
        }
    }
}
