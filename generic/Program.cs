
internal class Program
{
    private static void Main(string[] args)
    {

       // int numbersint = new int[] { 10, 20, 30, 40 }
        //for (int i = 0; ; i < numbersint.lenght ; int++)
          //  {
          //
            //Console.WriteLine(numbersint[i]);
        //}


        int[] numbers = new int[] { 10, 20, 30 };
        CustomLoop(numbers);

        
        void CustomLoop<T>(T[] numbers)
        {

            for (int i = 0 ; i <numbers.Length ; i++)
            {
                Console.WriteLine(numbers[i]);

            }



        }
    }
}