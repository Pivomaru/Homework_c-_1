// Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.
int a = 44;
int b = 5;
int c = 78;
int max = a;
if(b > a) max = b;
if(c > b) max = c;
Console.WriteLine(max);