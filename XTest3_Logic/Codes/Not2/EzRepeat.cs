namespace XTest3_Logic.Codes.Not2
{
    public class EzRepeat
    {
        public static string Code(string input)
        {
            string output = input + input;
            return output;
        }
        public static string Decode(string input)
        {
            string output = input.Substring(input.Length / 2);
            return output;
        }
    }
}
