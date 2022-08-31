int numberOfCourses, creditHours = 0;
double GPA, fGPA, sGPA, tGPA, fthGPA, finalGPA = 0;

try
{
    do
    { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to my GPA Calculator App.\n");
        Console.ResetColor();

        Console.WriteLine("Choose an option:");
        Console.WriteLine("\t\t1: Calculate GPA");
        Console.WriteLine("\t\t2: Find your current class");
        string option = Console.ReadLine();

    
        switch (option)
        {
            case "1":
                int askAgain = 0;
                Console.Write("How many courses did you offer?- ");
                numberOfCourses = Convert.ToInt32(Console.ReadLine());
                double totalGradePoint = 0;
                double totalCreditHours = 0;
                do
                {
                    Console.Write("Enter number of credit hour(s) for the course: ");
                    creditHours = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Choose the grade you had: ");
                    Console.WriteLine("1. A");
                    Console.WriteLine("2. B+");
                    Console.WriteLine("3. B");
                    Console.WriteLine("4. C+");
                    Console.WriteLine("5. C");
                    Console.WriteLine("6. D+");
                    Console.WriteLine("7. D");
                    Console.WriteLine("8. E");
                    Console.WriteLine("9. F");

                    string grade = Console.ReadLine().ToUpper();
                    double gradePoint = 0;
                    double fgradePoint = 0;

                    switch (grade)
                    {
                        case "1":
                            gradePoint = (double)4.0;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "2":
                            gradePoint = (double)3.50;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "3":
                            gradePoint = (double)3.00;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "4":
                            gradePoint = (double)2.50;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "5":
                            gradePoint = (double)2.00;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "6":
                            gradePoint = (double)1.50;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "7":
                            gradePoint = (double)1.00;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "8":
                            gradePoint = (double)0.50;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        case "9":
                            gradePoint = (double)0.00;
                            fgradePoint = gradePoint * creditHours;
                            totalGradePoint += fgradePoint;
                            totalCreditHours += creditHours;
                            break;

                        default:
                            Console.WriteLine("Enter a valid input!");
                            break;
                    }
                    askAgain++;

                    double gPA = totalGradePoint / totalCreditHours;
                    Console.Write($"\t\tTotal credit hours : {totalCreditHours}");
                    Console.Write($"\t\tTotal gradepoint: {totalGradePoint}");
                    Console.WriteLine($"\t\tYour GPA is {gPA}");
                } while (askAgain < numberOfCourses);
                break;


            case "2":
                Console.WriteLine("Enter your GPA: ");
                GPA = Convert.ToDouble(Console.ReadLine());

                if (GPA > 3.60)
                {
                    Console.WriteLine($"You have a First Class Honours.");
                }
                else if (GPA > 3.00)
                {
                    Console.WriteLine("You have a Second Class Honours (Upper Division).");
                }
                else if (GPA > 2.00)
                {
                    Console.WriteLine("You have a Second Class Honours (Lower Division).");
                }
                else if (GPA > 1.50)
                {
                    Console.WriteLine("You have a Third Class.");
                }
                else if (GPA > 1.00)
                {
                    Console.WriteLine("You have a Pass.");
                }
                else if (GPA > 0.00)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You failed Terribly!!");
                    Console.ResetColor();
                    Console.WriteLine("Take your studies seriously.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid input!");
                }
                break;
            default:
                Console.WriteLine("Enter a valid input!");
                break;
        }
        Console.WriteLine("\nWould you like to perform another calculation? - (Yes = Y / No = N).");
        
    } while (Console.ReadLine().ToUpper() == "Y");
}


catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Enter a valid input.");
}
Console.ReadLine();