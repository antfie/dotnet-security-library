public static class Cleanse
{
    public static string CRLF(string? untrusted)
    {
        if (untrusted == null)
        {
            return "";
        }

        return untrusted.Replace("\n", "\\n").Replace("\r", "\\r");
    }
}