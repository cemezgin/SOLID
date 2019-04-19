public interface ILogger
{
    void Log(string message);
}
public class FileLogger: ILogger 
{   
    public void Log(string message)
    {
        //File Log
    }
}
 
public class DBLogger: ILogger
{   
    public void Log(string message)
    {
        //Database Log
    }
}

public class LogManager  
{
    private ILogger logger;
     
    public LogManager(ILogger logger)
    {
        this.logger = logger;
    }
 
    public void Log(string message)
    {
        logger.Log(message);
    }
}