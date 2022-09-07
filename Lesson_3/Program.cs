// string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// string Replace(string text, char OldValue, char NewValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == OldValue)
//         {
//             result = result + $"{NewValue}";
//         }
//         else
//         {
//             result = result + $"{text[i]}";
//         }
//     }
//     return result;
// }
// string NewText = Replace(text, ' ', '|');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'к', 'К');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'С', 'с');
// Console.WriteLine(NewText);

int[] arr = { 1, 3, 8, 5, 7, 9, 4, 2 };
int length = arr.Length;
for (int i = 0; i < length - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < length; j++)
    {
        if (arr[j] > arr[min]) min = j;
    }
    int k = arr[i];
    arr[i] = arr[min];
    arr[min] = k;
}
for (int i = 0; i < length; i++)
{
    Console.WriteLine(arr[i]);
}