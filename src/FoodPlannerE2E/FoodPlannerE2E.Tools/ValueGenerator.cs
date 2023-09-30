using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FoodPlannerE2E.Tools
{
    public static class ValueGenerator
    {
        private static readonly string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string GenerateString(int length)
        {
            var random = new Random();
            var stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                stringBuilder.Append(chars[index]);
            }

            return stringBuilder.ToString();
        }

        public static string Repeat(string valueToRepeat, int repetitions)
            => new StringBuilder(valueToRepeat.Length * repetitions).Insert(0, valueToRepeat, repetitions).ToString();
    }
}