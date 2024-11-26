namespace Interactors.DTOs
{
    public class ErrorData
    {
        public string Message { get; set; }

        /// <summary>
        /// Действия по предотвращению ошибки
        /// </summary>
        public string PreventActions { get; set; }

        public ErrorData(string message, string preventActions)
        {
            Message = message;
            PreventActions = preventActions;
        }
    }
}
