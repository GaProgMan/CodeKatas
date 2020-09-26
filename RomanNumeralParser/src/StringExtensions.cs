namespace src
{
    public static class StringExtensions
    {
        public static int ParseRomanNumeral(this string input)
        {
            using (var parser = new Parser())
            {
                return parser.Parse(input);
            }
        }
    }
}