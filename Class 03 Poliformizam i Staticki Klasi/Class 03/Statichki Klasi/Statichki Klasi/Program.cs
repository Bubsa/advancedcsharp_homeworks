using Statichki_Klasi;
using Statichki_Klasi.Entities.Helpers;
using Statichki_Klasi.Entities.Models;

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("======== Order Management App ========");
//Console.ResetColor();

//ConsoleHelper consoleHelper = new ConsoleHelper();
//consoleHelper.WriteInColor("======== Order Management App ========", ConsoleColor.Cyan);


// PRICHINATA ZASHO NE PRAVIME OVAKA POGORE E BIDEJKI KE MORA SEGDE DA JA INSTANCIRAME KLASATA AKO SAKAME PROMENI BILO KADE VO BILO KOJ TEXT, ZATOA SME SO STATICHKI KLASI VO
// CONSOLE HELPER KLASATA SO TOA SHO JA PRAVIME STATIC. STATICHKA KLASA NE MOZE DA BIDE INSTANCIRANA.

bool isRunning = true;

while (!isRunning)
{
    Console.Clear();
    ConsoleHelper.WriteInColor("======== Order Management App ========", ConsoleColor.Cyan);

    //Console.WriteLine(OrdersStaticDB.Users.Count);
    Console.WriteLine("\nPlease choose an option:");
    Console.WriteLine("1) List all users");
    Console.WriteLine("2) Add new order to user");
    Console.WriteLine("3) Exit");
    
    string input = Console.ReadLine();

    int option = ValidationHelper.ValidateNumberInput(input);
    if (option == -1)
    {
        ConsoleHelper.WriteInColor("Invalid option. Try again!", ConsoleColor.Red);
        Console.ReadLine();
        continue;
    }

    switch (option)
    {
        case 1:
            break;
        case 2:
            ConsoleHelper.WriteInColor("\nEnter User Id", ConsoleColor.Magenta);
            int userId = Convert.ToInt32(Console.ReadLine());
            ConsoleHelper.WriteInColor("\nEnter Order Title", ConsoleColor.Magenta);
            string title = Console.ReadLine();
            ConsoleHelper.WriteInColor("\nEnter Order Description", ConsoleColor.Magenta);
            string description = Console.ReadLine();

            Order newOrder = new Order(0, title, description);
            OrdersStaticDB.InsertOrder(userId, newOrder);
            break;
        case 3:
            isRunning = false;
            break;
        default:
            break;
    }

    Console.ReadLine();
}
