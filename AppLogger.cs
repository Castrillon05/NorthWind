using Northwind.Entities.Interfaces;
using Northwind.Entities.ValueObjects;


namespace Northwind.ConsoleApp.Services;

internal class AppLogger(IUserActionWriter writer)
{
    public void WriteLog(string message)
    {
        UserAction Log = new UserAction("System", message);
        writer.Write(Log);
    }
}

