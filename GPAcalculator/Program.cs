int numberOfCourses, creditHours = 0;
double fGPA, sGPA, tGPA, fthGPA = 0;

try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to my GPA Calculator App.\n");
    Console.ResetColor();

    Console.WriteLine("Choose an option:");
    Console.WriteLine("\t\t1: Calculate GPA");
    Console.WriteLine("\t\t2: Calculate CGPA");
    string option = Console.ReadLine();

    
    switch (option)
    {
        case "1":
            int askAgain = 0;
            Console.Write("How many courses did you offer?- ");
            numberOfCourses = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Enter number of credit hour(s) for the course: ");
                creditHours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your grade for this course: ");
                string grade = Console.ReadLine().ToUpper();
                askAgain++;
            } while (askAgain < numberOfCourses);
            

            break;

        case "2":
            Console.Write("What was your GPA for first year: ");
            fGPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your GPA for second year: ");
            sGPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your GPA for third year: ");
            tGPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your GPA for fourth year: ");
            fthGPA = Convert.ToDouble(Console.ReadLine());

            double CGPA = ;
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

