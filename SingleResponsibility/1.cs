   public interface IMessage
    {
        IList<String> ToAddresses { get; set; }
        string MessageBody { get; set; }
        bool Send();
    }

    public interface IEmailMessage:IMessage
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
        public bool Send()
        {
            //Do the real work here
            return true;
        }
    }

    public class SmsMessage : IMessage
    {
        public IList<String> ToAddresses { get; set; }
        public string MessageBody { get; set; }
        public bool Send()
        {
            //Do the real work here
            return true;
        }
    }