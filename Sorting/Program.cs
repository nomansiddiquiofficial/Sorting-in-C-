using static System.Runtime.InteropServices.JavaScript.JSType;

class Program {
    public static void Main()
    {
        // find the minimum number in array
        int[] arr = {9,1,58,61,34,1,0, 3,4,};
        int min = arr[0];
        foreach(int i in arr)
        {
            if( min > i)
            {
                min = i;

            }

        }
        //Console.WriteLine(min);


        // implement bubble sort
        int[] array = { 9, 1, 58, 61, 34, 1, 0, 3, 4, };

       
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int swap = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swap;
                }
            }
        }
        //foreach (int num in arr)
        //{
        //    Console.Write($"{num} ");
        //}

      

    }
} 
