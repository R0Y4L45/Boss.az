
namespace Boss.az
{
    public class CustomExceptionClass : ApplicationException
    {
        public string? message;
        public DateTime dateTime { get; }
        public int ErrorLine { get; }
        public string ErrorFilePath { get; }

        public CustomExceptionClass(string? message, DateTime dateTime, int errorLine, string? errorFilePath)
        {
            this.message = message;
            this.dateTime = dateTime;
            ErrorLine = errorLine;
            ErrorFilePath = errorFilePath!;
        }
        public CustomExceptionClass(DateTime dateTime, int errorLine, string errorFilePath)
        {
            this.message = base.Message;
            this.dateTime = dateTime;
            ErrorLine = errorLine;
            ErrorFilePath = errorFilePath;
        }

        public override string ToString()
        {
            return $@"Message : {Message}
Error Line : {ErrorLine}
Error Time : {dateTime}
Erro File Path {ErrorFilePath}";
        }

    }
}
