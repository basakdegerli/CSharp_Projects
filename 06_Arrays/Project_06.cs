using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Project_06
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] my_array = { 5, 125, 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxnumber = my_array[0];

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    if (my_array[i] > maxnumber)
            //    {
            //        maxnumber = my_array[i];
            //    }
            //}

            //Console.WriteLine(maxnumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "başak", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = {45, 85, 52, 41, 86, 10, 22, 35, 120, 78 };

            // Dizideki sayıları küçükten -> büyüğe sıralama  
            //Array.Sort(numbers); 
            //for (int i = 0; i < numbers.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = {45, 85, 52, 41, 86, 10, 22, 35, 120, 78 };

            // Dizideki sayıları tersten sıralama 
            //Array.Reverse(numbers);  
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodları

            //string[] customers = { "ali", "başak", "ayşegül", "merve", "çınar", "kaya" };

            //  Dizi içerisinde aranan değerin index sırasını döndürme   
            //int index = Array.IndexOf(customers, "başak"); 
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "Dizinin en küçük elemanı: " +  numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine((i+1) + "- "+ cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine("Dizideki sayıların toplamı: " + sum);

            //int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //Console.WriteLine("----Çift Sayılar----");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();

            //Console.WriteLine("----Tek Sayılar----");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();

        }
    }
}
