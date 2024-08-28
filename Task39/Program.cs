// Задача 39: Напишите программу, которая перевернет одномерный массиы (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
      int[] array = new int[length];
      for(int i = 0; i < array.Length; i++)
    {
       array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

return array;
}

void ReverseArray(int[] sourseArray)
{
    for(int i = 0; i < sourseArray.Length / 2; i++)
    {
        int temp = sourseArray[i];
        sourseArray[i] = sourseArray[sourseArray.Length - i -1];
        sourseArray[sourseArray.Length - i - 1] = temp;
    }
}

int[] myArray = GetRandomArray(5, -9, 10);
Console.WriteLine(string.Join(", ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));