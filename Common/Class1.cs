namespace Common;
public static class Helper
{


    public static int[] GenerateRandomArray (int min, int max, int length)
    {
        int[] array = new int [length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
        return array;
    }

    public static void PrintArray(int[] arr)
    {
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }

}
