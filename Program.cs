
using ShoppingSystem;

string command = Console.ReadLine();
Controller controller = new Controller();

while (command != "End") 
{
    List<string> line = command.Split(" ").ToList();
    string cmd = line[0];
    List<string> prms = line.Skip(1).ToList();

    if (cmd == "Product")
    {
        Console.WriteLine(controller.ProcessProductCommand(prms));
    }
    else if (cmd == "Service")
    {
        Console.WriteLine(controller.ProcessServiceCommand(prms));

    }
    else if (cmd == "Checkout")
    {
        Console.WriteLine(controller.ProcessCheckoutCommand(prms));

    }
    else if (cmd == "Info")
    {
        Console.WriteLine(controller.ProcessInfoCommand(prms));
    }

    command = Console.ReadLine();
}

Console.WriteLine(controller.ProcessEndCommand());

Console.ReadKey();