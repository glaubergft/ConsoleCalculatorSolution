string executeAnotherCalculation = "n";

do
{
    string menuOption;
    bool validOption;

    do
    {
        Console.WriteLine("CALCULATOR");
        Console.WriteLine("---------");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Exit");
        Console.Write("Please, select an option between 1 and 5: ");
        menuOption = Console.ReadLine();

        validOption = menuOption == "1" || menuOption == "2" || menuOption == "3" || menuOption == "4" || menuOption == "5";

        if (!validOption)
        {
            Console.WriteLine("\n*** Invalid option! ***");
            Console.WriteLine("Press any key to continue...\n");
        }

    } while (!validOption);

    if (menuOption != "5")
    {
        Console.Write("\nEnter the first number: ");
        float number1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float number2 = Convert.ToSingle(Console.ReadLine());

        float result = 0;
        char operation = ' ';

        switch (menuOption)
        {
            case "1":
                result = number1 + number2;
                operation = '+';
                break;
            case "2":
                result = number1 - number2;
                operation = '-';
                break;
            case "3":
                result = number1 * number2;
                operation = '*';
                break;
            case "4":
                result = number1 / number2;
                operation = '/';
                break;
        }

        Console.WriteLine($"{number1} {operation} {number2} = {result}");

        do
        {
            Console.Write("\nDo you want to execute another calculation? (y/n): ");
            executeAnotherCalculation = Console.ReadLine().ToLower();

            validOption = executeAnotherCalculation == "y" || executeAnotherCalculation == "n";
        } while (!validOption);

        Console.WriteLine("");

    }
    else
    {
        executeAnotherCalculation = "n";
    }
} while (executeAnotherCalculation == "y");



Console.WriteLine("Thank you");

Console.ReadKey();