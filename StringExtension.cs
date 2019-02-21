using System;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            char[] array = source.ToCharArray();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[i] == array[j])
                        && (int)array[i] >= 0
                        && (int)array[i] < 128
                        && (int)array[j] >= 0
                        && (int)array[j] < 128)
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}