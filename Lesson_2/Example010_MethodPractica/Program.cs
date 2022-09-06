int[] array = { 17, 21, 132, 43, 547, 65, 47, 381 };

int n = array.Length;
int find = 132;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
