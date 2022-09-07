double sum = Convert.ToDouble(Console.ReadLine());
double result = 0;
if (sum < 100) result = sum + sum * 0.05;
if (sum > 100 && sum < 200) result = sum + sum * 0.07;
if (sum > 200) result = sum + sum * 0.1;
Console.WriteLine("Сумма от вклада в размере ");
Console.WriteLine(sum);
Console.WriteLine("равна ");
Console.WriteLine(result);
