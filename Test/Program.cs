// Написать программу, которая из имеющегося массива строк 
// сформирует массив из строк, длина которых меньше или равна 3 символам. 
// Первоначальный массив можно задать с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Examples:
// ["hello", "2", "world", ":-)"]  => ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"]  => ["-2"]
// ["Russia", "Denmark", "-Kazan"]  => []

// * * * * * * * * * * * * * * * * * *
// For testing - please uncomment:
// string[] array1 = new string[] { "hello", "2", "world", ":-)" };
// string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
// string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };

string[] names = new string[] { "Tom", "Ellis", "Joe", "Eve", "Billy-Bob", "Lu", "Craig", "Olga" };

int HowManyAreThere(string[] array, int withWhatCompare)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int x = array[i].Length;
        if (x <= withWhatCompare) counter++;
    }
    return counter;
}

void TheNeededOnes(string[] array, int newArrayLength, int withWhatCompare)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int x = array[i].Length;
        if (x <= withWhatCompare)
        {
            string[] chosenElements = new string[newArrayLength];
            chosenElements[pos] = array[i];
            if (pos == 0) Console.Write($"{chosenElements[pos]}");
            else Console.Write($", {chosenElements[pos]}");
            pos++;
        }
    }
}

TheNeededOnes(names, HowManyAreThere(names, 3), 3);

