using System;

//----------------------------------------------------------------------------------------------------------------------------------------------------------

//1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Пользователь вводит значения M и N
//         Console.WriteLine("Введите M:");
//         int M = int.Parse(Console.ReadLine());
        
//         Console.WriteLine("Введите N, которое больше M:");
//         int N = int.Parse(Console.ReadLine());

//         if (M < N)

//         {Console.WriteLine($"Все натуральные числа от {M} до {N}:");
//         PrintNumbers(M, N);}

//         else  Console.WriteLine("Второе число не должно быть больше или равно первому <- условие нарушено!"); 
//     }

//     // Метод для вывода всех натуральных чисел в промежутке от M до N с использованием рекурсии
//     static void PrintNumbers(int M, int N)
//     {
//         if(M > N) return; // Базовый случай рекурсии
//         Console.WriteLine(M); // Вывод текущего значения
//         PrintNumbers(M + 1, N); // Рекурсивный вызов для следующего числа
               
//     }
// }

//----------------------------------------------------------------------------------------------------------------------------------------------------------

//2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите неотрицательное число m:");
//         int m = int.Parse(Console.ReadLine());
//         Console.WriteLine("Введите неотрицательное число n:");
//         int n = int.Parse(Console.ReadLine());

//         int result = AckermannFunction(m, n);
//         Console.WriteLine($"Результат функции Аккермана для A({m}, {n}) = {result}");
//     }

//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0) // Базовый случай 1
//         {
//             return n + 1;
//         }
//         else if (n == 0 && m > 0) // Базовый случай 2
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else // Рекурсивный случай
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }
// }

//----------------------------------------------------------------------------------------------------------------------------------------------------------

//3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите длину массива: ");
//         int length = Convert.ToInt32(Console.ReadLine());
//         int[] array = new int[length]; // Создание массива введенной длины

//         // Заполнение массива числами, введенными пользователем
//         for (int i = 0; i < length; i++)
//         {
//             Console.Write($"Введите элемент массива под индексом {i}: ");
//             array[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.WriteLine("\nВы ввели массив: ");
//         PrintArray(array, 0); // Вывод массива с использованием рекурсии
//         Console.WriteLine("\nЭлементы массива в обратном порядке: ");
//         PrintReverse(array, array.Length - 1); // Вывод элементов массива в обратном порядке с использованием рекурсии
//     }

//     // Рекурсивная функция для печати элементов массива
//     static void PrintArray(int[] array, int index)
//     {
//         if (index < array.Length)
//         {
//             Console.Write(array[index] + " ");
//             PrintArray(array, index + 1);
//         }
//     }

//     // Рекурсивная функция для печати элементов массива в обратном порядке
//     static void PrintReverse(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(array[index] + " ");
//             PrintReverse(array, index - 1);
//         }
//     }
// }

//----------------------------------------------------------------------------------------------------------------------------------------------------------