/* не используя рекрсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8   */


Console.Clear();

void Fib(int N)
{
    int x = 0, y = 1, z = 0;
    if(N <= 0)return;  // если заданное число отриц или 0 то выходим - ничего не произойдет
    System.Console.Write(("0 "));
    if(N >= 2)
    System.Console.Write(("1 "));
    for (int i = 0; i < N-2; i++)
    {
        z = x + y;
        System.Console.Write(z + " ");
        x = y;
        y = z;
    }
}
Fib(5);


/*
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());  // преобразует в натуральное число

int a = 0;
int b = 0;
while (n > 0)
{ 

}
*/


