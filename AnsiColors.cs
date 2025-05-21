using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_dados
{
    public static class AnsiColors
    {
        // Reset
        public const string Reset = "\u001b[0m";
        // Text colors
        public const string Black = "\u001b[30m";
        public const string Red = "\u001b[31m";
        public const string Green = "\u001b[32m";
        public const string Yellow = "\u001b[33m";
        public const string Blue = "\u001b[34m";
        public const string Magenta = "\u001b[35m";
        public const string Cyan = "\u001b[36m";
        public const string White = "\u001b[37m";

        public static void WriteLine(string text, string color = null)
        {
            string output = "";

            if (!string.IsNullOrEmpty(color))
                output += color;

            output += text + Reset;

            Console.WriteLine(output);
        }

        public static void Write(string text, string color = null)
        {
            string output = "";
            if (!string.IsNullOrEmpty(color))
                output += color;
            output += text + Reset;
            Console.Write(output);
        }
    }

}
