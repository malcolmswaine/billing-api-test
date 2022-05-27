namespace Task_Billing_API.Infrastructure
{
    public static class StringMaxLenExtension
    {
        public static bool IsGreaterThan(this string s, int maxLength)
        {
            return s.Length > maxLength;
        }
    }
}
