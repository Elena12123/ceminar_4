void FillArray (int[] collection)
{
    int length = collection.Length;
    int i = 0;

    while (i < length)
    {
        collection[i] = new Random().Next(1, 100);
        i++;
    }


}

void PrintArray (int[] numbers)
{
    int count = numbers.Length;
    int index = 0;
    
    while (index < count)
    {
        Console.WriteLine(numbers[index]);
        index++;
    }
    
}
int [] array = new int[8];

FillArray(array);
PrintArray(array);