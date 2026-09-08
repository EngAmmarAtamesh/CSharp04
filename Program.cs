using System.Text;

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


            #region Question 4

            int index = 0;

            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }

            #endregion

            #region Question 5

            int count = 0;

            do
            {
                Console.WriteLine("Checking book...");
                count++;
            }
            while (count < 3);

            #endregion

            #region Question 6

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            #endregion

            #region Question 7

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }

            #endregion

            #region Question 8

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }

            #endregion


            #region Question 9

            static void PrintFirstBook(string[] books)
            {
                if (books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }

            PrintFirstBook(books);

            #endregion


            #region Question string 1

            string title = "clean code";

            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            #endregion

            #region Question string 2

            string title1 = "Clean Code";
            string title2 = "Clean Code";

            Console.WriteLine(ReferenceEquals(title1, title2));

            #endregion

            #region Question string 3

            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb);

            #endregion

            #region Question string 4

            StringBuilder sb2 = new StringBuilder();

            sb2.Append("Book List");
            sb2.Append(" - Updated");

            sb2.Replace("Book List", "Library");

            Console.WriteLine(sb2);

            #endregion

            #region Question string 5

            string title3 = "Clean Code";
            int pages = 464;

            string sentence = "Book: " + title3 + ", Pages: " + pages;

            Console.WriteLine(sentence);

            #endregion

            #region Question 6

            string title4 = "Clean Code";
            int pages2 = 464;

            string sentence2 = $"Book: {title4}, Pages: {pages2}";

            Console.WriteLine(sentence2);

            #endregion

            #region Question 7

            string title5 = "Clean Code";
            int pages3 = 464;

            string sentence3 = string.Format("Book: {0}, Pages: {1}", title5, pages3);

            Console.WriteLine(sentence3);

            #endregion
        }
    }
}
