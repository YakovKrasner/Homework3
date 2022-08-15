Console.WriteLine ("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
    for (int count = 1; count <= number; count ++)
        {
            Console.WriteLine (Math.Pow (count,3));
        }
