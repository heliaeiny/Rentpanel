namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            int[] numbers = new int[] { 10, 20, 30, 40 };
            CustoomLoop(numbers);



            //ostad=chera onaei ke new drn toosi shdn
            short[] numbersshort = new short[] { 100, 200, 3000, 400 };
            CustoomLoop(numbersshort);

            long[] numberslong = new long[] { 100, 200, 300, 400 };
            CustoomLoop(numberslong);

            void CustoomLoop<T>(T[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);

                }



            }
        }
    }
}
