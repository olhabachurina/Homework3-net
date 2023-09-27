using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_net
{
    internal class Program
    {
        static void Main()

        {
            Console.WriteLine($"Exercise 1");
            //Создайте пиложение, отражающее количество парных, непарных, уникальных элементов массива.
            int rows = 4;
            int cols = 4;
            int[,]array=new int[rows, cols];
            Random random = new Random();
            for(int i = 0; i < rows; i++) 
            {
                for(int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 51);
                }
            }
            Console.WriteLine("Two-dimensional array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int evenCount = 0;
            int oddCount=0;
            HashSet<int> uniqueElements = new HashSet<int>();
            for(int i = 0;i<rows;i++) 
            {
                for( int j = 0;j < cols; j++)
                {
                    int currentElement= array[i, j];
                    if (currentElement%2==0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                    uniqueElements.Add(currentElement);
                }

            }
            Console.WriteLine($"Number of paired elements: {evenCount}");
            Console.WriteLine($"Number of unpaired elements: {oddCount}");
            Console.WriteLine($"Number of unique elements:{uniqueElements.Count}");

            Console.WriteLine($"Exercise 5");
            //Разработайте приложение, которое будет находить минимальное и
            //максимальное значение в двумерном массиве.
            int rows1 = 6;
            int cols1 = 6;


            int[,] array1 = new int[rows1, cols1];
            Random random1 = new Random();//заполняем массив случайными числами

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    array1[i, j] = random1.Next(1, 101); // Заполняем случайными числами от 1 до 100
                }
            }

            // Выведите массив на экран
            Console.WriteLine("Two-dimensional array:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(array1[i, j] + " ");
                }
                Console.WriteLine();
            }


            int minValue = array1[0, 0]; //  минимальное значение в массиве
            int maxValue = array1[0, 0]; // максимальное значение в массиве

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    if (array1[i, j] < minValue)
                    {
                        minValue = array1[i, j];
                    }
                    if (array1[i, j] > maxValue)
                    {
                        maxValue = array1[i, j];
                    }
                }
            }

            Console.WriteLine($"Minimum value: {minValue}");//  минимальное  значение
            Console.WriteLine($"Maximum value: {maxValue}");//  максимальное значение
            Console.WriteLine($"Exercise 8");
            //Пользователь вводит предложение с клавиатурой. Приложение содержит подсчет количества гласных букв в предложении.
            Console.WriteLine($"Enter an offer:");
            string inputSentence=Console.ReadLine();
            int vowelCount = CountVowels(inputSentence);
            Console.WriteLine($"Number of vowels in a sentence: {vowelCount}");
        }
        static int CountVowels(string sentence) // Функция для подсчета гласных в строке
        {
            string vowels = "aeiouAEIOU";//определяем строку,содержащую гласные буквы
            int count = 0;
            foreach (char c in sentence)
            {
                if (vowels.Contains(c))// Проверяем, является ли текущий символ гласной буквой
                {
                    count++; 
                }
            }
            return count;// Возвращаем общее количество гласных букв
        }
    }
}
  