using System;

namespace PasswordGen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Options op = new MainClass.Options();
            Console.Write("How long is the password: ");

            op.Long = Convert.ToInt32(Console.ReadLine());

            Console.Write("Capital Letters: [Y/N]: ");

            op.CapitalLetters = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Small Letters? [Y/N]: ");

            op.SmallLetters = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Numbers? [Y/N]: ");
            op.Numbers = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Special Characters? [Y/N]: ");
            op.SpecialCharacters = Console.ReadLine().ToUpper() == "Y";
        }

        class PasswordGeneretor
        {
            PasswordGeneretor(Options op)
            {

            }
        }

        class Options
        {
            public Int32 Long { set; get; }
            public bool CapitalLetters { set; get; }
            public bool SmallLetters { set; get; }
            public bool Numbers { set; get; }
            public bool SpecialCharacters { set; get; }
        }
    }
}
