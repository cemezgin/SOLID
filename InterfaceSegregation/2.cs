public interface ILog
{
    void Log(string message);
}
 
public interface IDBLog: ILog
{
    void OpenConnection();
 
    void CloseConnection();
}
 
public interface IFileLog: ILog
{
    void CheckFileSize();
 
    void GenerateFileName();
}

public class FileLogger : IFileLog
{
    public void CheckFileSize()
    {
           //Code to check log file size
    }
 
    public void GenerateFileName()
    {
          //Code to generate a new file name
    }
        
    public void Log(string message)
    {
           //Code to log data to the log file
    }
}
 
   public class DBLogger : IDBLog
   {
       public void Log(string message)
       {
           //Code to log data to the database
       }
 
       public void OpenConnection()
       {
           //Code to open database connection
       }
 
        public void CloseConnection()
        {
           //Code to close database connection
        }
   }