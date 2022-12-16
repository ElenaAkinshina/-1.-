//Односторочный комментарий
/*Большой многострочный комментарий */

//Задача 1: Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//Console.WriteLine("Введи число: ");
//int number = int.Parse(Console.ReadLine()!);

// Математический
//int sqr = number * number;
// С библиотекой
//int sqr1 = Convert.ToInt32(Math.Pow(number, 2));


//Console.WriteLine($"Квадрат числа {number} является число: математический {sqr}, с библиотекой {sqr1}");

// Задача 2: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

//Console.WriteLine("Введи число: ");
//int num = int.Parse(Console.ReadLine()!);
//int num1 = -num;

//while(num1 <= num){
   // Console.Write($"{num1} ");
   // num1++;
//}
//1. Напишите программу, которая на вход принимает два числа 
//и проверяет, является ли первое число квадратом второго.

//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

/*Console.Write("Введи первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введи второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.Clear();
if(num_1 == Convert.ToInt32(Math.Pow(num_2, 2))){
    Console.WriteLine($"Число {num_1} является квадратом {num_2}");
}
else{
    Console.WriteLine($"Число {num_1} не является квадратом {num_2}");
}*/

//2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

//3 -> Среда
//5 ->  Пятница

/*Console.Write("Введите номер дня от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if(num == 1){
    Console.WriteLine("Понедельник");
}
else if(num == 2){
    Console.WriteLine("Вторник");
}
else if(num == 3){
    Console.WriteLine("Среда");
}
else if(num == 4){
    Console.WriteLine("Четверг");
}
else if(num == 5){
    Console.WriteLine("Пятница");
}
else if(num == 6){
    Console.WriteLine("Суббота");
}
else if(num == 7){
    Console.WriteLine("Воскресенье");
}
else{
    Console.WriteLine("Введите число от 1 до 7!!!");
}*/


//3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
    
//   456 -> 6
    
// 782 -> 2
    
//  918 -> 8


Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int result = num % 10;
Console.Write($"Последняя цифра числа {num}: {result}");
