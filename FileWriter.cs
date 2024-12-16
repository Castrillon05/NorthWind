namespace NortWind.Writers;

public class FileWriter : IUserActionWriter
{
    public void Write(UserAction action)
    {
        File.AppendAllText(action"AppLogs.txt",
            string.Format("FileWriter: {0}, {1}, {2}",
            action.CreatedDateTime, action.User.Description));
    }
}


