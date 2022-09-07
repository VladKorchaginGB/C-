//Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве
int x1 = 3;
int y1 = 6;
int z1 = 8;

int x2 = 2;
int y2 = 1;
int z2 = -7;

double result = 0;
double result1 = 0;
double result2 = 0;
double result3 = 0;
double result4 = 0;
double result5 = 0;
double result6 = 0;
double result7 = 0;
result1 = x2 - x1;
result2 = y2 - y1;
result3 = z2 - z1;
result4 = Math.Pow(result1, 2);
result5 = Math.Pow(result2, 2);
result6 = Math.Pow(result3, 2);
result7 = result4 + result5 + result6;
result = Math.Sqrt(result7);
Console.WriteLine(result);