namespace Interactors.DTOs
{
    public class ErrorData
    {
        public string Message { get; set; }
        public string PreventActions { get; set; }

        public ErrorData(string message, string preventActions)
        {
            Message = message;
            PreventActions = preventActions;
        }
    }
}
