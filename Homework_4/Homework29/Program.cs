﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Изначально не понял задание. Сказанно"программа, котрая задает массив", не до конца понятно, буду считать,
//что задает массив рандомно.
Random rand = new Random();
int[] myArray = new int[8];
for (int x = 0; x < myArray.Length; x++)
{
    myArray[x] = rand.Next(20);
    Console.WriteLine(myArray[x]);
}