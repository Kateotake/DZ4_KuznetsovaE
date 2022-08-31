// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int A , int B)
{
    int stepn = 1;

    for (int i = 0; i < B; i++)
    {
        stepn = stepn * A ;
    }
    return stepn;
}

Console.WriteLine("Введите целое число А");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число В");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"{x} в степени {y} равно {Stepen(x,y)}");



//  Console.WriteLine("Введите целое число А");
// double A = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите целое число В");
// double B = Convert.ToDouble(Console.ReadLine());

// double step = Math.Pow(A , B);

// Console.WriteLine(step);

