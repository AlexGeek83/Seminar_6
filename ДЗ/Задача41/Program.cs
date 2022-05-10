/* Пользователь вводит с клавиатуры М чисел. Посчитать, сколько
чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223 -> 3    */


Console.Write("Введите числа через пробел): ");
int[] mass = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Вы ввели количество чисел больше 0: {count}");


/*
Console.Write("Введите числа через пробел: ");

int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

int Numbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine($"Кол-во чисел больше 0 равно: {Numbers(array)}");

*/



// считывает со строки и преобразует в числа
/*  string line = "1 2 3 4 5";

string[]massString = line.Split();
int[]mass = new int[massString.Length];

for (int i = 0; i < mass.Length; i++)
    mass[i] = Convert.ToInt32(massString[i]);
for (int i = 0; i < mass.Length; i++)
    System.Console.WriteLine(mass[i]);
*/
