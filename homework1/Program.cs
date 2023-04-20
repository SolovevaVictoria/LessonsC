// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.WriteLine("Введите два числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2) {
//     Console.WriteLine("max = " + num1);
// }
// else if (num2 > num1){
//     Console.WriteLine("max = " + num2);
// }
// else {
//     Console.WriteLine("equal");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7; 44 5 78 -> 78; 22 3 9 -> 22
// Console.WriteLine("Введите три числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int maxnnum = num1;
// if (num2 > maxnnum) 
//     maxnnum = num2;
// if (num3 > maxnnum) 
//     maxnnum = num3;
// Console.WriteLine(maxnnum);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да; -3 -> нет; 7 -> нет
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0) 
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4; 8 -> 2, 4, 6, 8
// Console.WriteLine("Введите число >1");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while (i <= num ){
//     Console.Write(i + " ");
//     i += 2;
// }



// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
// которая принимает на вход целое число любой разрядности и на выходе 
// показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5; 78 -> 8; 9146548 -> 1; 3 -> нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9) {
    while (num > 99) {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}
else {
    Console.WriteLine("нет");
}

