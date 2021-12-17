        int n = int.Parse(Console.ReadLine());
        long r;
        for (int p = 2; p <= n; p++)
        {
            r = (p * p);
            Console.WriteLine($"{p}^2 = {r}");
            p++;
        }
