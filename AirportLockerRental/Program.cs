/*----------------------------------------------------------------------------------------------------------
 | Project: Airport Locker Rental 
 | Description: A menu of five options to view, rent, end a locker rental, list all locker contents, or quit.
 | Author: SkillFoundry -- coded by Steve
 | Dependencies: Null
 | Version: 1.0
 -----------------------------------------------------------------------------------------------------------*/


/*----------------------
 |  Declare variables
 -----------------------*/
int numberChoice = 0;
string viewLockerReturn, lockerContents, lockerContentsReturn, endLockerReturn, listLockerReturn = "";


/*--------------------------
 |  Array for locker storage
 ---------------------------*/
string[] lockerStorage = new string[100];


/*----------------------------
 |  Start -- Display main menu
 -----------------------------*/
while (numberChoice != 5)
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

    // Prompt for list number
    promptForNumber(5);

  
    switch (numberChoice)
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

        case 4:
            Console.WriteLine();
            Console.WriteLine(listAllLocker());
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}


/*------------------------------------
 |  Return number for menu and lockers
 -------------------------------------*/
int promptForNumber(int num)
{

    do
    {
        if (num == 5)
        {
            Console.Write("Enter your choice (1-5): ");
        }
        else if (num == 100)
        {
            Console.Write("Enter locker number (1-100): ");
        }
        if (int.TryParse(Console.ReadLine(), out numberChoice))
        {
            if (numberChoice > 0 && numberChoice <= num)
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        else
        {
            Console.WriteLine("Not a number!");
        }
    } while (true);

    return numberChoice;
}


/*----------------------
 |  View a Locker
 -----------------------*/
string viewALocker()
{
    // Prompt for locker number
    promptForNumber(100);

    // Display the contents of the locker
    if (string.IsNullOrEmpty(lockerStorage[numberChoice]))
    {
        viewLockerReturn = $"Locker {numberChoice} is EMPTY.";
    }
    else
    {
        viewLockerReturn = $"Locker {numberChoice} contents: {lockerStorage[numberChoice]}";
    }
    
    return viewLockerReturn;
}


/*----------------------
 |  Rent a Locker
 -----------------------*/
string rentALocker()
{
    // Prompt for locker number
    promptForNumber(100);

    if (!string.IsNullOrEmpty(lockerStorage[numberChoice]))
    {
        lockerContentsReturn = $"Sorry, but locker {numberChoice} has already been rented!";
    }
    else
    {
        // Prompt user for what to store in the locker
        Console.Write("Enter the item you want to store in the locker: ");
        lockerContents = Console.ReadLine();

        // Add numberChoice to lockerStorage
        lockerStorage[numberChoice] = lockerContents;

        lockerContentsReturn = $"Locker {numberChoice} has been rented for {lockerContents} storage.";
    }
   
    return lockerContentsReturn;
}


/*----------------------
 |  End a Locker Rental
 -----------------------*/
string endALocker()
{
    // Prompt for locker number
    promptForNumber(100);

    if (string.IsNullOrEmpty(lockerStorage[numberChoice]))
    {
        endLockerReturn = $"Locker {numberChoice} is not currently rented.";
    }
    else
    {
        lockerContents = lockerStorage[numberChoice];
        lockerStorage[numberChoice] = null;
        endLockerReturn = $"Locker {numberChoice} rental has ended, please take your {lockerContents}.";
    }

    return endLockerReturn;
}


/*--------------------------
 |  List all Locker Contents
 ---------------------------*/
string listAllLocker()
{
    listLockerReturn = "";
    for (int i = 0; i < lockerStorage.Length; i++)
    {
        if (!string.IsNullOrEmpty(lockerStorage[i]))
        {
            listLockerReturn += $"Locker {i}: {lockerStorage[i]}\n";
        }
    }

    return listLockerReturn;    
}






