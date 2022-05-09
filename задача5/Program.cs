/* Программа, которая будет создавать копию заданного массива
с помощью поэлементного копирования */

Console.Clear();

int[]CopyArray(int[]mass)
{
    int[] newMass = new int[mass.Length]; // создается массив внутри ф-ции и выделяется
    // память ровно столько сколько пришло из массива
    for (int i = 0; i < mass.Length; i++)
    {
        newMass[i] = mass[i];
    }
    return newMass;
}
// Явное поэлементное копирование 
int[] massiv = {1, 2, 3, 4, 5};
int[] newMass1 = CopyArray(massiv);
newMass1[2] = 1000;
System.Console.WriteLine(massiv[2]);
// Копирование ссылки (не копирование)
int[] newMass2 = newMass1;
newMass2[1] = 12345;
System.Console.WriteLine(newMass1[1]);




/*
int[]massiv = {1, 2, 3};

int[]newMassiv = massiv;

newMassiv[2] = 100;
System.Console.WriteLine(newMassiv[2]);

*/


