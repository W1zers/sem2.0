// Известны стоимости каждого из восьми предметов в двух наборах. Какой из наборов предметов более дешевый?

Console.WriteLine("Известны стоимости каждого из восьми предметов в двух наборах. Какой из наборов предметов более дешевый? ");
            int N8sets = Input("количество наборов");
            int N8setItems = Input("количество предметов в одном наборе");
            double[,] N8prices = new double[N8sets, N8setItems];
            double[] N8sum = new double[N8sets];
            double N8minPrice = double.MaxValue;
            int N8cheapest=0;
            for (int set = 0; set < N8sets; set++)
            {
                for (int item = 0; item < N8setItems; item++)
                {
                    N8prices[set, item] = Rand.NextDouble() * (100 - 10) + 10;
                    N8sum[set] += N8prices[set, item];
                    Console.Write($"{N8prices[set,item]:f2} ");
                }
                Console.Write($"\tСтоимость набора {N8sum[set]:f2}\n");
                if (N8sum[set] < N8minPrice)
                {
                    N8minPrice = N8sum[set];
                    N8cheapest = set + 1;
                }
            }
            Console.WriteLine(N8cheapest + "-й набор самый дешевый");
            Console.ReadKey();
            Console.Clear();