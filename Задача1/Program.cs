/* Программа, которая перевернет одномерный массив (последний элемент
будет на первом, а первый на последнем и т.д.)  */

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

//функция Swap
void Swap(int[]mass, int i, int j)
{
    int temp = mass[i];  //
    mass[i] = mass[j];
    mass[j] = temp;
}


//функция замены элементов массива, как и Array.Reverse(array);
void Reverse(int[]mass)
{
    for (int i = 0; i < mass.Length/2; i++) // идем до середины массива
    {
       // int temp = mass[i];  //  можно также использовать для переворота массива
      //  mass[i] = mass[^(i+1)];  //  можно также использовать для переворота массива
      //  mass[^(i+1)] = temp;   //  можно также использовать для переворота массива
      Swap(mass, i, mass.Length  - 1 - i); // где "mass.Length  - 1 - i" - число первое с конца
    }
}


int[] array = new int[5];

RandomArray(array);
PrintArray(array);
Reverse(array);
// Array.Reverse(array); // данная команда переворачивает массив
PrintArray(array);







