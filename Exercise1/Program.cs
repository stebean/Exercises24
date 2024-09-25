using System;

Console.WriteLine("Ingrese el primer numero: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
int number2 = int.Parse(Console.ReadLine());

int diff = Math.Abs(number1 - number2);

if (number1 > number2)
{
    Console.WriteLine(diff * 2);
}
else
{
    Console.WriteLine(diff);
}
