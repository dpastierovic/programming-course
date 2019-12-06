namespace Basics
{
    public static class StringExtensionMethods
    {
        public static string Reverse(this string text)
        {
            var reversedText = "";
            for (var i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }

            return reversedText;
        }

        public static string RemoveUseless(this string input)
        {
            var cleared = "";
            for(var i = 0; i < input.Length; i++)
            {
                if (input[i] != '.' && input[i] != ' ' && input[i] != ',') cleared += input[i];
            }
            return cleared;
        }
    }
}