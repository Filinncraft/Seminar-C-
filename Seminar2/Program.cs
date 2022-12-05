// Невозвратный метод

// void Test(int a, int b){
//     if (a>b){
//         Console.WriteLine ($"{a} больше {b}");
//     }
//     else{
//         Console.WriteLine ($"{b} больше {a}");
//     }    
// }
// int num1 = 4;
// int num2 = 5;
// Test(num1, num2);


// Возвратный метод

// int Test (int a, int b){
//     if (a>b)
//         return a;
//     else
//         return b;
// }
// int num1 = 5;
// int num2 = 4;
// int result = Test(num1, num2);
// Console.WriteLine($"Результат - {result}");


// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

// int Line(){
//     int num = new Random().Next(10,100);
//     Console.WriteLine($"Ваше число - {num}");
//     int dec = num/10;
//     int ed = num%10;
//     if (dec > ed)
//         return dec;
//     else if (dec == ed)
//         return ed;
//     else
//         return ed;
// }

// int res = Line();
// Console.WriteLine($"Большее число - {res}");


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа.

// int Line(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine($"Ваше число - {num}");
//     int dec = num/100;
//     int ed = num%10;
//     return ((dec*10) + ed);
// }    
// int res = Line();
// Console.WriteLine(res);



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе чмсло кратным первому.
// Если второе число не кратно первому, то программа выводит остаток от деления.

// void Test(int num1, int num2){
//     if (num2 % num1 == 0)
//     { 
//         Console.WriteLine ($"Число {num2} кратно числу {num1}");
//     }
//     else
//     {
//         int res = num2 % num1;
//         Console.WriteLine ($"Число {num2} не кратно числу {num1}. Остаток от деления {res}");
//     }
// }
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Test(num1, num2);


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом второго

// void Test(int num1, int num2){
//     if (num2 == num1 * num1)
//     { 
//         Console.WriteLine ($"Является");
//     }
//     else if (num1 == num2 * num2)
//     { 
//         Console.WriteLine ($"Является");
//     }
//     else
//     {
//        Console.WriteLine ($"Не является");
//     }
// }
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Test(num1, num2);