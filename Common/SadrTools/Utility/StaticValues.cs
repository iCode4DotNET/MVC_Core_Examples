namespace SadrTools.Utility
{
    public static class StaticValues
    {
        public static class ViewData
        {
            public static string Title { get; } = "Title";
            public static string FirstName { get; } = "FirstName";
            public static string LastName { get; } = "LastName";
            public static string ID { get; } = "ID";

            public static string Person { get; } = "Person";

            public static string Welcome { get; } = "Welcome";
            public static string Security { get; } = "Security";
            public static string Message { get; } = "Message";
            public static string CssClass { get; } = "CssClass";

        }

        public static class TempData
        {
            public static string Contact { get; } = "Contact";
            public static string Security { get; } = "Security";
        }

        public static class Exception
        {
            /// <summary>
            /// عبارت مورد نظر قابل تبدیل به عدد صحیح نمیباشد
            /// </summary>
            public static string ToInt { get; } = "عبارت مورد نظر قابل تبدیل به عدد صحیح نمیباشد";

            /// <summary>
            /// عبارت مورد نظر قابل تبدیل به عدد اعشاری نمیباشد
            /// </summary>
            public static string ToFloat { get; } = "عبارت مورد نظر قابل تبدیل به عدد اعشاری نمیباشد";

            /// <summary>
            /// آبجکت مورد نظر معتبر نمیباشد
            /// </summary>
            public static string InvalidObject { get; } = "آبجکت مورد نظر معتبر نمیباشد";

            /// <summary>
            /// لیست مورد نظر فقط خواندنی میباشد
            /// </summary>
            public static string ReadOnlyList { get; } = "لیست مورد نظر فقط خواندنی میباشد";

        }


    }
}
