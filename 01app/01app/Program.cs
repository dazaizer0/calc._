Random random = new Random();

int los_numer()
{

    int los = 1;

    los = random.Next(0, 10);
    return los;
}

void get_los()
{

    while (true)
    {

        switch (Console.ReadKey(true).Key)
        {

            case ConsoleKey.L:
                Console.WriteLine(los_numer());
                break;
        }
    }
}

Console.ForegroundColor = ConsoleColor.Green;

Thread reader = new(get_los);
reader.Start();