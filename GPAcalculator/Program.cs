try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to my GPA Calculator App.\n");
    Console.ResetColor();

    Console.WriteLine("Choose an option:");
    Console.WriteLine("\t\t1: Calculate GPA");
    Console.WriteLine("\t\t2: Calculate CGPA");
    string option = Console.ReadLine();

    int rounds = 0;
    switch (option)
    {
        case "1":
            int numberOfCourses;
            do
            {
                
                Console.Write("How many courses did you offer?- ");
                numberOfCourses = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of credit hour(s) for the course: ");
                string creditHours = Console.ReadLine();

                Console.Write("Enter your grade for this course: ");
                string grade = Console.ReadLine();
                rounds++;
            } while (rounds < numberOfCourses);
            

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

