// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if(numberA > numberB)
//     Console.WriteLine($"{numberA} больше {numberB}");
// else 
//     Console.WriteLine($"{numberB} больше {numberA}");



// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максиальное из этих чисел.

// Console.Write("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int C = Convert.ToInt32(Console.ReadLine());
// if(A > B & A > C)
//     Console.WriteLine($"{A} больше всех");
// else if(A > B & A < C)
//     Console.WriteLine($"{C} больше всех");
// else if(A < B & A > C)
//     Console.WriteLine($"{B} больше всех");
// else if(A < B & A < C & B < C)
//     Console.WriteLine($"{C} больше всех");
// else
//     Console.WriteLine($"{B} больше всех");


// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным.

// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA%2 == 0)
//     Console.WriteLine($"{numberA} четное");
// else 
//     Console.WriteLine($"{numberA} не четное");


// Задача 8. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// while (count <= number)
// {
//         if(count%2 == 0)
//         Console.Write(count+" ");
//         count++;
// }


// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

// int Line(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine($"Ваше число - {num}");
//     int dec = num/10 % 10;
//     return (dec);
// }    
// int res = Line();
// Console.WriteLine(res);


// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void Test(int num){
//     if (num < 100)
//             Console.WriteLine ($"Третьей цифры нет");
//     else
//     {
//         while(num > 999)
//         {
//             num = num / 10;
//         }
//         int res = num % 10;
//         Console.WriteLine ($"Третья цифра в числе {res}");
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);


// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number == 6 || number == 7)
//     Console.WriteLine("Выходной");
//     else if(number < 1 || number > 7)
//     Console.WriteLine("Нет такого дня");
// else 
//     Console.WriteLine("Опять работать");


// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom5(int num)
// {
//     if(num<10000 || num>99999)
//     Console.WriteLine ("Число не пятизначное");
//     int temp = num;
//     int reverse = 0;
//     while (num > 0)
//         {
//             reverse = reverse*10 + num%10;
//             num = num/10;
//         }
//     if (reverse == temp)
//         Console.WriteLine ("Палиндром");
//     else 
//         Console.WriteLine ("Не палиндром");
// }
// 
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Palindrom5(x);


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance (int x1, int y1, int x2, int y2, int z1, int z2)
// {
//     double Dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
//     return Dist;
// }
// 
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double dist = Distance(x1,x2,y1,y2,z1,z2);
// Console.WriteLine(dist);


// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

// void Triple(int number)
// {
//      for (int count = 1; count <= number; count++)
//      {
//      Console.Write(count*count*count + " ");
//      }
// }
// 
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Triple(x);


// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = a;
// for (int i = 1; i < b; i++)
// {
//     result = result*a;
// }
// Console.Write($"{a} в степени {b} равно {result}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SummOfDigit()
// {
//     Console.Write("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int summ = 0;
//     int temp = num;
//     while (temp>0)
//     {
//         summ = summ + temp%10;
//         temp = temp/10;
//     }
//     return (summ);
// }    
// int res = SummOfDigit();
// Console.WriteLine(res);



// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// int[] Array()
// {
//     Console.Write("Введите число элементов массива: ");
//     int [] arr = new int [Convert.ToInt32(Console.ReadLine())];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write("Введите число массива: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void ShowArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// ShowArray(Array());

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// void FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(100,1000);
//     }
// }
// 
// void ShowArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// FillArray(num);
// ShowArray(num);
// int count = 0;
// for (int j = 0; j < num.Length; j++)
// if (num[j] % 2 == 0)
// count++;

// Console.WriteLine($"{count} чётных чисел в массиве");


// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// void FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next();// если не задать разумные границы, то вероятность попадания в нужный отрезок крайне мала. много раз запускал программу и думал, правильно ли она работает, или я накосячил. Попробовал задать отрезок от 10 до 1000 и все нормально.
//     }
// }
// 
// void ShowArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] num = new int[123];
// FillArray(num);
// ShowArray(num); // показывать массив не обязательно, так как весь терминал заполнится цифрами (все-таки 123 числа это много), но это дает наглядность
// int count = 0;
// for (int j = 0; j < num.Length; j++)
// if (num[j] > 9 && num[j] < 100)
// count++;

// Console.WriteLine($"{count} чисел массива лежат в отрезке [10,99]");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(); 
//     }
// }

// void ShowArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива:");// преподаватель советовал не более 10
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// FillArray(num);
// ShowArray(num); 
// int sum = 0;
// for (int j = 1; j < num.Length; j+=2)
// sum = sum + num[j];

// Console.WriteLine($"{sum} - сумма элементов на нечетных позициях");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Результат запишите в новом массиве.

// Console.WriteLine("Введите размер массива:");// преподаватель советовал не более 10
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// int[] arr = new int[Convert.ToInt32((size+1)/2)];
// void FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,100); 
//     }
// }

// void ShowArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Array()
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Convert.ToInt32((num[i]*num[size-i-1]));
//     }
//     return arr;
// }

// void ShowNewArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// FillArray(num);
// ShowArray(num); 
// ShowNewArray(Array());


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// void FillArray(double[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Convert.ToDouble(new Random().Next()); 
//     }
// }

// void ShowArray(double[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива:");// преподаватель советовал не более 10
// int size = Convert.ToInt32(Console.ReadLine());
// double[] num = new double[size];
// FillArray(num);
// ShowArray(num); 
// double min = num[0];
// double max = num[0];
// for (int j = 0; j < num.Length; j++)
//     {
//     if (num[j] < min)
//     min = num[j];
//     else if (num[j] > max)
//     max = num[j];
//     }

// Console.WriteLine($"{max - min} - разница максимального и минимального элемента");


// Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

// void FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write("Введите число: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// // void ShowArray(int[] arr)
// // {
// //     for(int i = 0; i < arr.Length; i++)
// //     {
// //         Console.Write(arr[i] + " ");
// //     }
// //     Console.WriteLine();
// // }

// Console.WriteLine("Введите M:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// FillArray(num);
// // ShowArray(num);
// int count = 0;
// for (int j = 0; j < num.Length; j++)
// if (num[j] > 0)
// count++;

// Console.WriteLine($"{count} элемент(а/ов) больше 0"); 
// для сокращения количества строк можно удалить метод ShowArray, он нужен только для наглядности


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите k1:");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b1:");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2:");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2:");
// int b2 = Convert.ToInt32(Console.ReadLine());
// if (k1 == k2 && b1 == b2)
//     Console.WriteLine("Прямые идентичны. Точек пересечения бесконечно");
// else if (k1 == k2)
//     Console.WriteLine("Прямые паралельны. Точек пересечения нет");
// else
//     {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * (b2 - b1) / (k1 - k2) + b1;
//     Console.WriteLine($"Координаты точки пересечения - {x},{y}");
// }


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] Create2dArray(int rows, int cols)
// {
//     double [,] array = new double [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().NextDouble()*100;
//         }
//     }
//     return array;
// }

// void Show2dArray(double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double [,] array = Create2dArray(m,n);
// Show2dArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int [,] Create2dArray(int rows, int cols)
// {
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(1,10);//границы задал, чтобы не было больших чисел. для задачи это не важно
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)//весь этот метод для решения необязателен, нужен только для наглядности
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter first position: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second position: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n);
// Show2dArray(array);
// if (x >= m || y >= n)
//     Console.Write("Нет такого значения");
// else
//     Console.Write($"{array[y,x]}");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int [,] Create2dArray(int rows, int cols)
// {
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(1,10);//границы задал, чтобы не было больших чисел. для задачи это не важно
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)//весь этот метод для решения необязателен, нужен только для наглядности
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n);
// Show2dArray(array);
// for(int j = 0; j < array.GetLength(1); j++)
//     {
//         double temp = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             temp = array[i,j] + temp;
//         }
//         Console.Write($"{temp/array.GetLength(0)} ");
//     }
