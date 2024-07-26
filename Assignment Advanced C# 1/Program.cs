using System;

class Program
{

    #region Part 1

    static void OptimizedBubbleSort<T>(T[] array) where T : IComparable<T>
    {
        bool swapped;
        for (int i = 0; i < array.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    // Swap elements
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped, the array is sorted
            if (!swapped)
                break;
        }
    }

    #endregion


    #region Part 2
    

    public class Range<T> where T : IComparable<T>
    {
        public T Minimum { get; }
        public T Maximum { get; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
             throw new ArgumentException("Minimum should be less than or equal to Maximum");
            }

            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public double Length()
        {
             dynamic min = Minimum;
             dynamic max = Maximum;
             return max - min;
        }

        #endregion
}


static void Main()
{
        #region Program Part 1
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array: " + string.Join(", ", array));

        OptimizedBubbleSort(array);

        Console.WriteLine("Sorted array: " + string.Join(", ", array));
        #endregion

        #region Program Part 2

      var intRange = new Range<int>(1, 10);
      Console.WriteLine($"Is 5 in range: {intRange.IsInRange(5)}");  
      Console.WriteLine($"Range length: {intRange.Length()}");      

      var doubleRange = new Range<double>(1.5, 3.5);
      Console.WriteLine($"Is 2.5 in range: {doubleRange.IsInRange(2.5)}");
      Console.WriteLine($"Range length: {doubleRange.Length()}");         

      var charRange = new Range<char>('a', 'z');
      Console.WriteLine($"Is 'm' in range: {charRange.IsInRange('m')}"); 
      Console.WriteLine($"Range length: {charRange.Length()}");          
   
    
    #endregion


    }
}
