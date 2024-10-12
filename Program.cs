//Дан двумерный массив.
//732
//496
//185
//Отсортировать данные в нем по возрастанию.
//123
//456
//789
//Вывести результат на печать.


using System.Drawing;

class Program

{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int max = int.MaxValue;
        int istring = a.GetLength(0);
        int jstring = a.GetLength(0);
        int arraysize = istring * jstring;
        int[] b = new int[arraysize];
        //строим массив с отсортированными данными
        for (int g = 0; g < arraysize; g++)
        {
            for (int i = 0; i < istring; i++)
            {
                for (int j = 0; j < jstring; j++)
                {
                    if (a[i, j] < max && !(b.Contains(a[i, j])))
                    {
                        max = a[i, j];

                    }
                }
            }
            b[g] = max;
            max = int.MaxValue;
        }
        //Отсортируем данные в нем по возрастанию.
        int elem = 0;
        for (int i = 0; i < istring; i++)
        {
            for (int j = 0; j < jstring; j++)
            {
                a[i, j] = b[elem];
                elem++;
                // Console.Write($"{a[i, j]} "); ну можно ещё так, но мне не нравится
            }
        }
        //выводим отсортированный массив
        Console.WriteLine(String.Join(" ", a.Cast<int>()));
    }
}