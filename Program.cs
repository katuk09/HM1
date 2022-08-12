//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
int num1, num2;

Console.Write("Please input number 1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input number 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)

    Console.WriteLine($"{num1} equals {num2}");

else
{
    if (num1 > num2)

        Console.WriteLine($"{num1} is more than {num2}");

    else 

        Console.WriteLine($"{num2} is more than {num1}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*int num1, num2, num3, max;

Console.Write("Please input Number 1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input Number 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input Number 3: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    
    max = num1;

else 

    max = num2;

if (num3 > max)

    Console.WriteLine($"{num3} is maximum of {num1}, {num2}, {num3}");
else

    Console.WriteLine($"{max} is maximum of {num1}, {num2}, {num3}");
*/

///*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
int num;

Console.Write("Please input your Number: ");
num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)
    Console.WriteLine($"Number {num} is even");
else
    Console.WriteLine($"Number {num} is not even");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*

int num, i;

Console.Write("Please input your brilliant Number: ");
num = Convert.ToInt32(Console.ReadLine());

i = 1;

Console.Write($"Even numbers from {i} to {num} are: ");

while (i <= num)
{
    if ((i % 2) == 0)
       
        Console.Write(i + " ");
    
i = i + 1;
}
*/ 