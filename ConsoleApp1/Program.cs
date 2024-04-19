namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<int[]> result = FoundSumOfNumbers(15, arr);
            PrintListArray(result);
        }
        static List<int[]> FoundSumOfNumbers(int num, int[] array)
        {
            Array.Sort(array);
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < array.Length - 2; i++)
            {
                int leftI = i + 1;
                int rightI = array.Length - 1;
                while (leftI < rightI)
                {
                    int sum = array[i] + array[leftI] + array[rightI];
                    if (sum == num)
                    {
                        int[] arrNums = { array[i], array[leftI], array[rightI] };
                        result.Add(arrNums);
                        leftI++;
                        rightI--;
                    }
                    else if (sum < num)
                    {
                        leftI++;
                    }
                    else
                    {
                        rightI--;
                    }
                }
            }
            return result;
        }
        static void PrintListArray(List<int[]> list) 
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Комбинация не найдена");
            }
            else 
            {
                int step = 1;
                foreach (int[] arr in list)
                {
                    Console.Write($"Вариант {step}: ");
                    foreach (var i in arr)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                    step++;
                }
            }
            
        }
    }
}
