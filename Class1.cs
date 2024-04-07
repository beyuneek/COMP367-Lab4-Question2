namespace ClassLibrary
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            char firstChar = str[0];
            return char.IsUpper(firstChar);
        }
    }
}
