/*----------------------------------------------------------------------------------------------------------
 | Name: Airport Locker Rental Menu  
 | Description: A menu of five options to view, rent, end a locker rental, list all locker contents, or quit.
 | Author: Steven Palfreyman
 | Dependencies: N/A
 | Version: 1.0
 -----------------------------------------------------------------------------------------------------------*/


/*----------------------
 |  Declare variables
 -----------------------*/
int menuChoice = 0, lockerChoice;
string viewLockerResult;

/*--------------------------
 |  Array for locker storage
 ---------------------------*/
string[] lockerStorage = new string[100];


/*----------------------------
 |  Start -- Display main menu
 -----------------------------*/
while (menuChoice != 5)
{
    // Clear console before displaying the menu
    Console.Clear();

    // Menu Options
    Console.WriteLine("Airport Locker Rental Menu");
    Console.WriteLine("===========================");
    Console.WriteLine("1. View a locker");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit");
    Console.WriteLine();

    // Input validation
    do
    {
        Console.Write("Enter your choice (1-5): ");
        if (int.TryParse(Console.ReadLine(), out menuChoice))
        {
            if (menuChoice > 0 && menuChoice <=5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.  Please enter a number from 1 to 5.");
            }
        }
        else
        {
            Console.WriteLine("Not a number!");
        }
    }
    while (true);

    switch (menuChoice)
    {
        case 1:
            Console.WriteLine(viewALocker());
            break;

        case 2:
            Console.WriteLine(rentALocker());
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

/*--------------------------
 |  Prompt for locker number
 ---------------------------*/
int promptForLocker()
{
    do
    {
        Console.Write("Enter locker number (1-100): ");
        if(int.TryParse(Console.ReadLine(),out lockerChoice))
        {
            if (lockerChoice > 0 && lockerChoice <= 100)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid choice.  Please enter a number from 1 to 100");
            }
        }
        else
        {
            Console.WriteLine("Not a number!");
        }
    }
    while (true);

    return lockerChoice;
}


/*----------------------
 |  View a Locker
 -----------------------*/
string viewALocker()
{
    // Prompt for locker number
    promptForLocker();

    // Display the contents of the locker
    if (string.IsNullOrEmpty(lockerStorage[lockerChoice]))
    {
        viewLockerResult = $"Locker {lockerChoice} is EMPTY.";
    }
    else
    {
        viewLockerResult = $"Locker {lockerChoice} contents: {lockerStorage[lockerChoice]}";
    }
    
    return viewLockerResult;
}

/*----------------------
 |  Rent a Locker
 -----------------------*/
string rentALocker()
{
    string fish = "";
    // Prompt for locker number
    promptForLocker();

    return fish;
}


/*----------------------
 |  End a Locker Rental
 -----------------------*/

/*--------------------------
 |  List all Locker Contents
 ---------------------------*/







