/* Задача 40 Программа, которая принимает на вход три числа и проверяет,
может ли существовать треугольник со сторонами такой длины.
**Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон */


bool Play(int x, int y, int z)
{
    bool r = true;
    if (x >= y + z || y >= x + z || z >= y + x)
    {
        r = false;
        return r;
    }
    else return true;
}
System.Console.WriteLine(Play(20, 10, 10));












/*
Console.Clear();
//заполняем массим рандом числами
void RandomArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(100);
    }
}
// выводим на экран
void PrintArray(int[]mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        System.Console.Write(mass[i] + " ");
    }
    System.Console.WriteLine(); System.Console.WriteLine();
}





int[] array = new int[3];

*/


