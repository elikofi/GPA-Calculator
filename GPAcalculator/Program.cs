try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to my GPA Calculator App.");
    Console.ResetColor();

    Console.WriteLine("Choose an option:\n");
    Console.WriteLine("\t1: Calculate GPA");
    Console.WriteLine("\t2: Calculate CGPA");
    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine();

            break;
        default:
            break;
    }
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Enter a valid input.");
}

