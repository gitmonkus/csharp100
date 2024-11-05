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
string viewLockerReturn, lockerContents, lockerContentsReturn;

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

        case 3:
            Console.WriteLine(endALocker());
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
        viewLockerReturn = $"Locker {lockerChoice} is EMPTY.";
    }
    else
    {
        viewLockerReturn = $"Locker {lockerChoice} contents: {lockerStorage[lockerChoice]}";
    }
    
    return viewLockerReturn;
}

/*----------------------
 |  Rent a Locker
 -----------------------*/
string rentALocker()
{
    
    // Prompt for locker number
    promptForLocker();

    if (!string.IsNullOrEmpty(lockerStorage[lockerChoice]))
    {
        lockerContentsReturn = $"Sorry, but locker {lockerChoice} has already been rented!";
    }
    else
    {
        // Prompt user for what to store in the locker
        Console.WriteLine("Enter the item you want to store in the locker: ");
        lockerContents = Console.ReadLine();

        // Add lockerChoice to lockerStorage
        lockerStorage[lockerChoice] = lockerContents;

        lockerContentsReturn = $"Locker {lockerChoice} has been rented for {lockerContents} storage.";
    }
   
    return lockerContentsReturn;
}


/*----------------------
 |  End a Locker Rental
 -----------------------*/
string endALocker()
{

}



/*--------------------------
 |  List all Locker Contents
 ---------------------------*/







