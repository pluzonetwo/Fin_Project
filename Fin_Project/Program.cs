// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] initialArr = { "Sunday", "Monday", "Tusday", "Wednesday", "Thur", "Friday", "Saturday" };

string[] ChangeArr(string[] someArr)
{
    string[] resultArr = new string[someArr.Length];

    for (int i = 0; i < resultArr.Length; i++)
    {
        if (someArr[i].Length <= 3)
        {
            resultArr[i] = someArr[i];
        }
    }

    return resultArr;
};

string[] RemoveNullStr(string[] someArr)
{
    string[] resultArr = new string[someArr.Length];

    for (int i = 0; i < resultArr.Length; i++)
    {
        if (someArr[i].Length != 0)
        {
            resultArr[i] = someArr[i];
        }
    }

    return resultArr;
}

string[] changeArr = ChangeArr(initialArr);
string[] finalArr = RemoveNullStr(changeArr);

System.Console.Write($"Update array: [{string.Join(", ", finalArr)}]");