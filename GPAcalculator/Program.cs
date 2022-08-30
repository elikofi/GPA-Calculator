int numberOfCourses, creditHours = 0;
double GPA, fGPA, sGPA, tGPA, fthGPA, finalGPA = 0;

try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to my GPA Calculator App.\n");
    Console.ResetColor();

    Console.WriteLine("Choose an option:");
    Console.WriteLine("\t\t1: Calculate GPA");
    Console.WriteLine("\t\t2: Calculate FGPA");
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
            Console.Write("What was your GPA for level 100 first semester: ");
            double levHunFGPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("What was your GPA for level 100 second semester: ");
            double levHunSGPA = Convert.ToDouble(Console.ReadLine());
            GPA = levHunFGPA + levHunSGPA;

            fGPA = (GPA * 1) / 6;

            Console.Write("What was your GPA for level 200 first semester: ");
            double levTwoFGPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("What was your GPA for level 200 second semester: ");
            double levTwoSGPA = Convert.ToDouble(Console.ReadLine());
            GPA = levTwoFGPA + levTwoSGPA;

            sGPA = (GPA * 1) / 6;

            Console.Write("What was your GPA for level 300 first semester: ");
            double levThrFGPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("What was your GPA for level 300 second semester: ");
            double levThrSGPA = Convert.ToDouble(Console.ReadLine());
            GPA = levThrFGPA + levThrSGPA;

            tGPA = (GPA * 2) / 6;

            Console.Write("What was your GPA for level 400 first semester: ");
            double levFourFGPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("What was your GPA for level 400 second semester: ");
            double levFourSGPA = Convert.ToDouble(Console.ReadLine());
            GPA = levFourFGPA + levFourSGPA;

            fthGPA = (GPA * 2) / 6;

            finalGPA = (fGPA + sGPA + tGPA + fthGPA)/8;
            Console.WriteLine($"\nYour graduating GPA is: {finalGPA}");
            break;
        default:
            Console.WriteLine("Enter a valid input!");
            break;

    }

}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Enter a valid input.");
}

Console.ReadLine();