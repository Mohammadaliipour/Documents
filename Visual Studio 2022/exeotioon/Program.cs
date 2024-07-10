namespace exeotioon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int doobl = 0;
            while (true)
            {
                Console.WriteLine("adad khod ra vared konid : ");

                try
                {
                    string str = Console.ReadLine();
                    doobl = (int.Parse(str)) * 2;
                    Console.WriteLine("do barabar adad : " + doobl + "\n \n");


                }

                catch (Exception ex)
                {
                    Console.WriteLine("lotfan meqdar adadi vared konid "+"\n");

                }


            }
        }
    }
}
