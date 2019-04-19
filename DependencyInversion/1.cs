public class FileLogger  
{   
    public void Log(string message)
    {
        //File Log
    }
}
 
public class DBLogger  
{   
    public void Log(string message)
    {
        //Database Log
    }
}

public class LogManager  
{
    private FileLogger _file;
    private DBLogger _db;
     
    public LogManager()
    {
        _file = new FileLogger();
        _db = new DBLogger();
    }
 
    public void Log(string message)
    {
        _file.Log(message);
        _db.Log(message);
    }
}