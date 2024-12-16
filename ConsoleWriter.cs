using Northwind.Entities.Interfaces;
using Northwind.Entities.ValueObjects;

namespace NortWind.Writers;

public class ConsoleWriter : IUserActionWriter
{
    public void write(UserAction action)
    {
        Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
            action.createdDateTime, action.User, action.Description);
    }
}

