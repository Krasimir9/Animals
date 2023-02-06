namespace Nemetscheck.Helpers.ConsoleHelpers
{
    public class ConsoleWriter
    {
        public void Clear()
        {
            Console.Clear();
        }

        public string Write(string output)
        {
            Console.Write(output);
            return output;
        }

        public string WriteLine(string output)
        {
            Console.WriteLine(output);
            return $"{output}{Environment.NewLine}";
        }

        public string WriteLine()
        {
            Console.WriteLine();
            return Environment.NewLine;
        }

    }
}
