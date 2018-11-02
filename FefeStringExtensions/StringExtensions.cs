namespace Fefe.Extensions.Strings
{
    using System;
    using System.IO;
    using System.Linq;

    public static class StringExtensions
    {
        public static string AppendPathSeparator(this string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            input = input.TrimEnd();

            if (IsFinalCharacterPathSeparator())
            {
                return input;
            }

            return input + GetPathSeparatorForThisPath();

            bool IsFinalCharacterPathSeparator()
            {
                if (input.Length == 0)
                {
                    return false;
                } else
                {
                    char final = input[input.Length - 1];
                    return final == Path.DirectorySeparatorChar || final == Path.AltDirectorySeparatorChar;
                }
            }

            char GetPathSeparatorForThisPath()
            {
                if (input.Contains(Path.AltDirectorySeparatorChar))
                {
                    return Path.AltDirectorySeparatorChar;
                }

                return Path.DirectorySeparatorChar;
            }
        }
    }
}
