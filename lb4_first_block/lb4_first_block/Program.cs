using lb4_zaichyk_block1;
using lb4_popilevych_block1;
using lb4_krasilnikov_block1;
using System;
using System.Runtime.InteropServices;

namespace Lab4
{
    internal class example1
    {
        public static void Choose_The_Way_To_Fill(int countOfElements, ref int[] array)
        {
            Console.WriteLine("Натиснiть 1, якщо бажаєте заповнити масив випадковим чином");
            Console.WriteLine("Натиснiть 2, якщо бажаєте заповнити масив вручну в одному рядку");
            int choiceOfInput = Convert.ToInt32(Console.ReadLine());
            switch (choiceOfInput)
            {
                case 1:
                    InputRandom(countOfElements, ref array);
                    Console.Write("Початковий масив: ");
                    for (int i = 0; i < countOfElements; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Введiть масив:");
                    Input_ByHand(countOfElements, ref array);
                    break;
            }
        }
        static void InputRandom(int countOfElements, ref int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < countOfElements; i++)
            {
                array[i] = random.Next(-100, 100);
            }
        }
        static void Input_ByHand(int countOfElements, ref int[] array)
        {
            string[] rowOfArray = Console.ReadLine().Trim().Split();
            for (int i = 0; i < countOfElements; i++)
            {
                array[i] = Convert.ToInt32(rowOfArray[i]);
            }
        }

        static void PrintArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Знищено всi елементи масиву");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Block_1()
        {
            Console.WriteLine("Введiть прiзвище студента, варiант якого хочете виконати. Для завершення виконання варiанту програми введiть 0. ");
            string choiceOfStudent = Console.ReadLine().ToLower();
            Console.Write("Введiть к-сть елементiв масиву: ");
            int countOfElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[countOfElements];
            Choose_The_Way_To_Fill(countOfElements, ref array);
            do
            {
                switch (choiceOfStudent)
                {
                    case "красільніков":
                        Krasilnikov.ExtremeMinMax(ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(array);
                        break;
                    case "попілевич":
                        Popilevych.DeleteOddElem(ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(array);
                        break;
                    case "зайчук":
                        Lilia.Rishennya(ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(array);
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
                Console.WriteLine("Введiть прiзвище студента, варiант якого хочете виконати. Для завершення виконання варiанту програми введiть 0. ");
                choiceOfStudent = Console.ReadLine().ToLower();
                if (choiceOfStudent == "красільніков" || choiceOfStudent == "попілевич" || choiceOfStudent == "зайчук")
                {
                    Console.WriteLine("Бажаєте створити новий масив?(Так/Нi)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.Write("Введiть к-сть елементiв: ");
                        countOfElements = Convert.ToInt32(Console.ReadLine());
                        array = new int[countOfElements];
                        Choose_The_Way_To_Fill(countOfElements, ref array);
                    }
                }
            } while (choiceOfStudent != "0");
        }

        public static void Main(string[] args)
        {
            Block_1();
        }
    }
}
