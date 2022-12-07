Console.Write("Введите нужное количество строк в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    string[] sourceArray = new string[number];
    for (int i = 0; i < sourceArray.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку: ");
        sourceArray[i] = Console.ReadLine();
    }

    Console.WriteLine();
    Console.WriteLine("Результат:");
    Console.Write("[");
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (i < sourceArray.Length - 1) Console.Write(sourceArray[i] + "," + " ");
        else Console.Write(sourceArray[i] + "] ");
    }

    void ArrayThreeSymbols(string[] array)
    {
        Console.Write("-> [");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                Console.Write(array[i] + ", ");
            }
        }
        Console.WriteLine("]");
    }

    ArrayThreeSymbols(sourceArray);
}
else Console.WriteLine("Введено некорректное значение!");

