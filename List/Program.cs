using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Пример 1");
            //List<string> people = new List<string>() { "Tom" };
            //people.Add("Bob");                                
            //people.AddRange(new[] { "Sam", "Alice" });   

            //people.Insert(0, "Eugene"); 

            //people.InsertRange(1, new string[] { "Mike", "Kate" }); 
            // foreach (string p in people)
            //{
            //    Console.WriteLine(p);
            //}

            //Console.WriteLine("#2");
            //var people1 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
            //people.RemoveAt(1); 
            //people.Remove("Tom");           
            //people1.RemoveAll(person => person.Length == 3);                      
            //people1.RemoveRange(1, 2);
            //people1.Clear();
            //foreach (string o in people1)
            //{
            //    Console.WriteLine(o);
            //}

            //Console.WriteLine("Пример 3");
            //var people2 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

            //var containsBob = people2.Contains("Bob");     
            //var containsBill = people2.Contains("Bill");                
            //var existsLength3 = people2.Exists(p => p.Length == 3);             
            //var existsLength7 = people2.Exists(p => p.Length == 7);  
            //var firstWithLength3 = people2.Find(p => p.Length == 3); 
            //var lastWithLength3 = people2.FindLast(p => p.Length == 3);  
            //List<string> peopleWithLength3 = people2.FindAll(p => p.Length == 3);
            //foreach (string a in people2)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("Пример 4");
            //List<string> people3 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            //var range = people3.GetRange(1, 3);
            //string[] partOfPeople = new string[3];
            //people3.CopyTo(0, partOfPeople, 0, 3);
            //foreach (string a in people3)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("Пример 5");
            //var people4 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            //people4.Reverse();
            //var people5 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };           
            //people5.Reverse(1, 3);
            //foreach (string a in people4)
            //{
            //    Console.WriteLine(a);
            //}


            //Console.WriteLine("Задача 1");
            //Console.WriteLine("Введите кол-во покупок: ");
            //int N = int.Parse(Console.ReadLine());
            //List<string> listBuy = new List<string>(N);
            //for(int i = 0; i < N; i++)
            //{
            //    listBuy.Add(Console.ReadLine());
            //}
            ////сортировка по алфавиту
            //listBuy.Sort();
            ////вывод списка
            //Console.WriteLine("От А до Я");
            //PrintList(listBuy);
            //listBuy.Reverse();
            //Console.WriteLine("От Я до А");
            //PrintList(listBuy);
            //Console.WriteLine("Задача 2");
            //Console.WriteLine("Введите кол-во строк с данными ");
            //int B = int.Parse(Console.ReadLine());
            //List<string> data = new List<string>(B);
            //for (int i = 0; i < B; i++)
            //{
            //    string v = Console.ReadLine();
            //    data.Add(v);
            //}
            //Console.WriteLine("Введите искомое слово ");
            //string p = Console.ReadLine();
            //for (int i = 0; i < B; i++)
            //{
            //    if (data[i].Contains(p))
            //    {
            //        Console.WriteLine(data[i]);
            //    }
            //}
            //Console.WriteLine("Задача 3");
            //Console.WriteLine("Введите кол-во строк ");
            //int s = int.Parse(Console.ReadLine());
            //List<string> listStrings = new List<string>(s);
            //for (int i = 0; i < s; i++)
            //{
            //    listStrings.Add(Console.ReadLine());
            //}
            //Console.WriteLine("Введите номер буквы ");
            //int numberSimbol = int.Parse(Console.ReadLine());
            //string abbreviature = "";
            //foreach (string line in listStrings)
            //{
            //    if (line.Length >= numberSimbol)
            //        abbreviature += line[numberSimbol - 1];
            //    else
            //        abbreviature += '_';
            //}
            //Console.WriteLine($"Полученное слово: {abbreviature}");
            //Console.WriteLine("Задача 5");
            //Console.WriteLine("Введите кол-во клиентов банка: ");
            //int K = int.Parse(Console.ReadLine());
            //List<int> listClients = new List<int>(K);
            //for (int i = 0; i < K; i++)
            //{
            //    listClients.Add(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("Исходные вложения");
            //PrintList(listClients);
            //Console.WriteLine(listClients.Sum());
            //Console.WriteLine(listClients.Average());
            //Console.WriteLine(listClients.Min());
            //Console.WriteLine(listClients.Max());
            //Console.WriteLine("Накопления каждого клиента через год");
            //foreach(int l in listClients)
            //{
            //    Console.WriteLine(l * 3);
            //}
            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите кол-во записанных частей объявлений: ");
            int L = int.Parse(Console.ReadLine());
            List<int> Part = new List<int>(L);
            for (int i = 0; i < L; i++)
            {
                Part.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Введите кол-во записанных частей объявлений: ");
            int m = int.Parse(Console.ReadLine());
            List<string> Frazy = new List<string>();
            for (int i = 0; i <m; i++)
            {
                Console.WriteLine("Введите номер фразы");
                int nomer = int.Parse(Console.ReadLine());
                nomer -= 1;
                Frazy.Add(Part[nomer]);
            }
            PrintList(Frazy);

            Console.WriteLine("Задача 6");
            Console.WriteLine("Введите кол-во записанных частей объявлений: ");
            int V = int.Parse(Console.ReadLine());
            List<int> integers = new List<int>(L);
            for (int i = 0; i < V; i++)
            {
                integers.Add(V);
            }
            Console.ReadKey();
        }
        private static void PrintList(List<string> list)
        {
            foreach  (string buy in list)
            {
                Console.WriteLine(buy);
            }
        }
        private static void PrintList(List<int> list)
        {
            foreach (int buy in list)
            {
                Console.WriteLine(buy);
            }
        }
    }
}
