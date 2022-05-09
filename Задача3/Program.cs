/* программа, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());  // преобразует в натуральное число
int k;
string result = " ";
while (a > 0)
{
    k = a % 2;
    result = k + result;
    a = a / 2;
}
Console.WriteLine($"Вывод: {result}");



//   =======    2-й способ  ============
/*
                 //Console.Write("Введите число: ");
                //a = Int32.Parse(Console.ReadLine());

Console.Clear();

string mass(int a)
{
    int b;
    string result = String.Empty;
    while(a > 0)
    {
        b = a % 2;
        a = a / 2;
        result = b.ToString() + result; // соединяются числа в строку, по очереди - не сумируются
    }
    return result;
}
System.Console.WriteLine(mass(45));

*/




