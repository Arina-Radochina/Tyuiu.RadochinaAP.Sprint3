using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadochinaAP.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            char[] chars = value.ToCharArray();

            foreach (char c in chars)
            {
                if (c == replaceable)
                {
                    chars[Array.IndexOf(chars, c)] = replacement;
                }
            }

            return new string(chars);

        }
    }
}
