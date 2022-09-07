// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void polindrom_true5(string numbers)
{
    if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
Console.Write("Введите пятизначное число: ");
string numbers_string5 = Console.ReadLine();
polindrom_true5(numbers_string5);
// Это метод для пятизнаных чисел, но он могут быть и не пятизнанчными, но все равно быть полиндромами
// Поэтому следующий метод для все чисел, число цифр которых нечетно
void polindrom_true(string numbers)
{
    int length = numbers.Length;
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = numbers[i];
    }
    int a = 0;
    for (int i = 0; i < length / 2; i++)
    {
        if (arr[i] == arr[length - i])
        {
            a = 0;
        }
        else
        {
            a = 1;
        }
    }
    if (a == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
Console.Write("Введите любое число: ");
string numbers_string = Console.ReadLine();
polindrom_true(numbers_string);

//но она почему-то не работает и я так и не смог понять почему, может у Вас получится)



