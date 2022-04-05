using System;

namespace ArrayApplication
{
    class ParamArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            ParamArray app = new ParamArray();
            int sum = app.AddElements(1, 9, 7, 2, 11);

            Console.WriteLine("The sum is: {0}", sum);
            Console.ReadKey();
        }
    }
}

