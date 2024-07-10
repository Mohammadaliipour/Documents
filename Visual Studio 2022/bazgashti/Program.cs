namespace bazgashti
{
    internal class Program
    {

        public static int dynamicfactiril(int n)
        {
            //hj
            int[] array = new int[n];
            array[0] = 1;

            if (n == 1)
                return 1;
            else
            {
                for (int i = 1; i < n; i++)
                {
                    array[i] = (i + 1) * array[i - 1];
                }
                return array[n - 1];

            }
        }

        public static int recurefactoril(int n)
        {
            if (n == 1)
                return 1;

            else
            {
                int x = n * recurefactoril(n - 1);
                return x;
            }
        }
        public static void Main(string[] args)
        {            
                Console.Write("adad khod ra vared konid : ");

                int vorodi = int.Parse(Console.ReadLine());
                Console.WriteLine(" with recursive method my answer is :  " + recurefactoril(vorodi));
                Console.WriteLine(" with  dynamic  method my answer is :  " + dynamicfactiril(vorodi));

            
        }
    }
}
