﻿Console.Write("Ingresa un numero: ");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < 2 * num; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}