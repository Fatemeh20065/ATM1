// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
     int mony , x = 10000 , y = 50000 ;
            Console.WriteLine("how much money do you want ?");
            mony = int.Parse(Console.ReadLine());
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    if (i * x + j * y == mony)
                    {
                        Console.WriteLine("number money 10000 : {0} , 50000 : {1}",i,j);
                    }
                }
            }
            Console.ReadKey();
