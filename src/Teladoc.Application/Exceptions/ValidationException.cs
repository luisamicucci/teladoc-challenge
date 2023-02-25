namespace Teladoc.Application.Exceptions
{
    public class ValidationException : FluentValidation.ValidationException
    {
        public Dictionary<string, string[]> Errors { get; set; }

        public ValidationException(Dictionary<string, string[]> errors) : base("One or more validation failures have occurred.")
        {
            Errors = errors;
        }
    }
}
