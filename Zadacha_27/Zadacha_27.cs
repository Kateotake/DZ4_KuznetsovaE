// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine ("Введите целое число");
string N = Console.ReadLine();
int NN = Convert.ToInt32(N);
int sum =  0;

for (int i = 0; i <= N.Length; i++)
{
    int ost = NN % 10;
    NN = NN /10;
    sum = sum + ost;
}
Console.WriteLine(sum);