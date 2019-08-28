    public interface IMessageServer
    {
        bool Send(IMessage message);
    }

    public interface IMessage
    {
        IList<String> ToAddresses { get; set; }
        string MessageBody { get; set; }
    }

    public interface IEmailMessage : IMessage
    {
        string Subject { get; set; }
        IList<String> BccAddresses { get; set; }
    }

    public class SmtpMessage : IEmailMessage
    {
        public IList<String> ToAddresses { get; set; }
        public IList<String> BccAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
    }

    public class SmsMessage : IMessage
    {
        public IList<String> ToAddresses { get; set; }
        public string MessageBody { get; set; }
    }

    public class SmsMessageServer : IMessageServer
    {
        public bool Send(IMessage message)
        {
            //Do the real work here
            return true;
        }
    }

    public class SmtpMessageServer : IMessageServer
    {
        public bool Send(IEmailMessage message)
        {
            //Do the real work here
            return true;
        }
    }