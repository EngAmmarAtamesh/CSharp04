namespace C_Basic04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion
        }
    }
}
