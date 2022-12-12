// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

// int SummNumbers(int num){
//     int summ = 0;
//     for( int i = 1; i <= num; i++)
//         summ += i;
//     return summ;
// }

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumbers(num);
// Console.WriteLine($"Summ of numbers from 1 to {num} is {summ}");


// Напишите программу, которая принимает число и выводит сколько в нем цифр

// int Counter(int num)
// {
//     if (num==0)
//     {
//        return 1;
//     }
//     else 
//     {
//         int digit = 0;
//         while (num>0)
//         {
//         num = num/10;
//         digit ++;
//         }
//     return digit;
//     }
// }
// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = Counter(num);
// Console.WriteLine($"{summ} digit in number {num}");


// Напишите программу, которая принимает число N и выдает произведение чисел от 1 до N

// int MultNumbers(int num)
// {
//     if (num <= 0)
//         return 0;
//     int summ = 1;
//     for( int i = 2; i <= num; i++)
//         summ = summ * i;
//     return summ;
// }

// Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = MultNumbers(num);
// Console.WriteLine($"Product of numbers from 1 to {num} is {summ}");


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] Array()
// {
//     int [] arr = new int [8];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,2);
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
