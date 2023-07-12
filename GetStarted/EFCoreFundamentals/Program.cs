using EFCoreFundamentals;
using EFCoreFundamentals.Abilities;
using Microsoft.EntityFrameworkCore;
using EFCoreFundamentals.Models;





while (true)
{

    Console.WriteLine("Hello, enter:\n 1 - for list of books.\n 2 - for change Url. \n 3 - for exit;\n");
    var enteredValue = Console.ReadLine();
    int operation;
    while (!Int32.TryParse(enteredValue, out operation))
    {
        Console.WriteLine("Input is invalid. Please try again: \n");
        enteredValue = Console.ReadLine();
    }
    switch (operation)
    {
        case 1:
            Abilities.ListAll();
            break;
        case 2:
            Abilities.ChangeWebUrl();
            break;
        case 3:
            Console.WriteLine("exiting ...");
            Thread.Sleep(1000);
            return;
        default:
            Console.WriteLine("Invalid operation, Please try again");
            break;
    }
}