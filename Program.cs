// __________Задача 2__________________________________________ 
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Введите первое число");
// int a=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b=Convert.ToInt32(Console.ReadLine());

// int max= a;

// if(max>b)
// {
//    Console.Write("a=");
//    Console.WriteLine(a);
//    Console.Write("b=");
//     Console.WriteLine(b);
//    Console.Write("max=");
//    Console.WriteLine(max);
// }   
// else if(a==b)
//    {
//     Console.WriteLine("Числа равны"); 
//    }
// else
// {
//    Console.Write("a=");
//    Console.WriteLine(a);
//    Console.Write("b=");
//     Console.WriteLine(b);
//    Console.Write("max=");
//    Console.WriteLine(b);
// }



// _______________________Задача 4__________________________ 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Введите первое число");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int num3=Convert.ToInt32(Console.ReadLine());

// int max= num1;

// if(num2>max) max= num2;
// {
// }
// if(num3>max) max= num3;
// {
// }

// Console.Write("max=");
// Console.WriteLine(max);



// _______________Задача 6_______________________________________ 
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// int num2=num%2;
// if(num2==0)
// {
//     Console.WriteLine("Да, число четное");
// }

// else
// {
//     Console.WriteLine("Нет, число нечетное");
// }



// ________________Задача 8__________________________
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());

int result= num/num;

while(result<=num)
if (result%2==0)
{
  Console.Write(result+" "); 
  result=result+1;
}
else if (result%2>0)
{
    result=result+1;
}
