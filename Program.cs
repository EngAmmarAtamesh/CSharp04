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

            #region Question 2

            int pages = 464;

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            #endregion

            #region Question 3

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }

            #endregion

        }
    }
}
