// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
int DegreeNumber(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.WriteLine("Введите число, которое хотите возвести в степень");
string AString = Console.ReadLine();
int A = Convert.ToInt32(AString);

Console.WriteLine("Введите степень числа");
string BString = Console.ReadLine();
int B = Convert.ToInt32(BString);

Console.WriteLine(DegreeNumber(A, B));
