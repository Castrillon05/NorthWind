namespace NorthWind.Entities.ValueObjects;
public class UserAction(string user, string description)
{
    public DateTime CreatedDataTime { get; } = DateTime.Now;
    public string User => User;
    public string Description => Description;

}
