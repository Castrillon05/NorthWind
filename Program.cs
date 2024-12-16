
using Northwind.ConsoleApp.Services;
using Northwind.Entities.Interfaces;
using Northwind.Writers;

IUserActionWriter writer = new ConsoleWriter();

AppLogger Logger = new AppLogger(writer);
Logger.WriteLog("Application started");

ProductService  Service = new ProductService(writer);
Service.Add("Demo", "Azucar refinada");