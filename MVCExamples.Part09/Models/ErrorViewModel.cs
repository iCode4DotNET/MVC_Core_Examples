namespace MVCExamples.Part09.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        /// <summary>
        /// Added by Me !!
        /// </summary>
        public int ErrorNumber { get; set; }

        /// <summary>
        /// اضافه شده توسط اینجانب
        /// </summary>
        public IFormFile ErrorFile { get; set; }
    }
}
