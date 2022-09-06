void ThirdNumbers(int a)
{
    int b = a;
    int lenght = 0;
    while (b > 0)
    {
        b = b / 10;
        lenght++;
    }
    //выяснил сколько цифр содержит число
    if (lenght < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    int[] array = new int[lenght];

    while (lenght > 0)  //поместил с помощью цикла все цифры числа в массив
    {
        array[lenght - 1] = a % 10;
        a = a / 10;
        lenght--;

    }
    Console.WriteLine(array[2]);
}
ThirdNumbers(34567);