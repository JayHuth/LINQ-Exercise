namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameNames = new List<string>
            {"Zelda", "Horizon", "Spider Man", "Dying Light", "Death Loop"};

            var lengthOf = gameNames.OrderBy(x => x.Length).ToList();

            foreach(string name in lengthOf)
            {
                Console.WriteLine(name);
            }

        }
    }
}
