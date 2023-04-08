// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] initialArr = { "Mo", "Wednesday", "Th", "Fri", "S" };

string[] ChangeArr(string[] someArr)
{
    int count = 0;

    for (int i = 0; i < someArr.Length; i++)
    {
        if (someArr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArr = new string[count];

    return FillResultArr(resultArr);
};

string[] FillResultArr(string[] someArr)
{
    int j = 0;

    for (int i = 0; i < initialArr.Length; i++)
    {
        if (initialArr[i].Length <= 3)
        {
            someArr[j] = initialArr[i];
            j++;
        }
    }

    return someArr;
}

string[] changeArr = ChangeArr(initialArr);

System.Console.Write($"Update array: [{string.Join(", ", changeArr)}]");