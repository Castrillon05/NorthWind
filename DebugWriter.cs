namespace NortWind.Writers;

    public class DebugWriter : IUserActionWriter
  {
    public void Writer(UserAction action) 
    {
        Debug.WriteLine("ConsoleWriter: {0}, {1}, {2}",
            action.createdDateTime, action.User, action.Description);
    }
  }

