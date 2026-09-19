namespace Assiment4.String_And_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // FUNCTION PARAMETER PASSING
            // ==========================================


            #region Function Parameter Passing - Question 1
            // Write a method:
            // bool TryGetPrice(string title, out double price)
            //
            // If title is "Clean Code":
            // - Set price to 25.5
            // - Return true
            //
            // Otherwise:
            // - Set price to 0
            // - Return false
            //
            // Call the method and print the price if found.
            double price;
            string title=Console.ReadLine();
            if (TryGetPrice(title, out price))
            { 
                Console.WriteLine(price);
            } 
            else 
            { 
                Console.WriteLine("the price is not found");
            }


            #endregion


            #region Function Parameter Passing - Question 2
            // Write a method:
            // PrintBookInfo(string title, int pages = 300)
            //
            // pages should be an optional parameter.
            //
            // Call the method once with only a title.
            //
            // Call it again passing both:
            // - title
            // - pages
            PrintBookInfo("Clean Code");
            PrintBookInfo("Refactoring", 450);



            #endregion


            #region Function Parameter Passing - Question 3
            // Using the PrintBookInfo method from Question 2,
            // call it using named parameters.
            //
            // Pass pages BEFORE title.

            PrintBookInfo(pages: 450, title: "Clean Code");


            #endregion


            #region Function Parameter Passing - Question 4
            // Write a method:
            // PrintAllTitles(params string[] titles)
            //
            // It should print each title on its own line.
            //
            // Call it with three book titles.

            string[] Titles = { "Clean Code", "Refactoring", "The Pragmatic Programmer" };

            PrintAllTitles(Titles);
            #endregion



            // ==========================================
            // ACCESS MODIFIERS
            // ==========================================


            #region Access Modifiers - Question 1
            // Add this field to the Book class:
            //
            // private string password = "secret";
            //
            // Try to print it from Main (outside the Book class).
            //
            // Questions:
            // What happens?
            // Why?

            Book book = new Book();
            //Console.WriteLine(book.password);
            //error:'Book.password' is inaccessible due to its protection level
            //because the password field is private and cannot be accessed from outside the Book class.

            #endregion


            #region Access Modifiers - Question 2
            // Add this field to the Book class:
            //
            // internal int copiesInStock = 5;
            //
            // Print it from Main.
            //
            // Questions:
            // Does it compile?
            // Why?

            Console.WriteLine($"copiesInStock is : {book.copiesInStock}");
            //yes , it compiles because the copiesInStock field is marked as internal,
            //which means it can be accessed from any code within the same assembly(project)

            #endregion


            #region Access Modifiers - Question 3
            // Add this field to the Book class:
            //
            // public string Title;
            //
            // Set its value from Main.
            // Then print it.

            book.Title = "Software Engineering";
            Console.WriteLine($"This title of book is: {book.Title}");

            #endregion


            #region Access Modifiers - Question 4
            // Declare an enum:
            // Genre
            // Assign:
            // Genre.Science
            //
            // Then print it.
            Console.WriteLine(book.genre);



            #endregion


            #region Access Modifiers - Question 5
            // Using the Genre enum from Question 4,
            // print the underlying int value of:
            //
            // Genre.Fiction
            // Genre.NonFiction
            // Genre.Science
            //
            // Cast each one to int.
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);



            #endregion


            #region Access Modifiers - Question 6
            // Given:
            //
            // int genreNumber = 1;
            //
            // Cast genreNumber into a Genre value.
            // Print the result.

            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);

            #endregion


            #region Access Modifiers - Question 7
            // Given:
            //
            // string genreText = "Science";
            //
            // Convert it into a Genre value
            // using:
            //
            // Enum.Parse()
            //
            // Print the result.

            string genreText = "Science";
            Genre generValue=Enum.Parse<Genre>(genreText);
            Console.WriteLine(genreText);


            #endregion


            #region Access Modifiers - Question 8
            // Given:
            //
            // string genreText = "Mystery";
            //
            // "Mystery" is NOT a valid Genre value.
            //
            // Use:
            // Enum.TryParse()
            //
            // to attempt the conversion.
            //
            // If it fails, print:
            // "Unknown genre"
            string genreText2 = "Mystery";
            bool Flag;
            Flag = Enum.TryParse(genreText2, out generValue);
            Console.WriteLine(Flag ? generValue : "Unknown genre");



            #endregion
        }



        // ==========================================
        // METHODS
        // ==========================================

        #region Methods


        // Function Parameter Passing - Question 1
        // TryGetPrice method
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }



        // Function Parameter Passing - Question 2 & 3
        // PrintBookInfo method
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }



        // Function Parameter Passing - Question 4
        // PrintAllTitles method

        public static void PrintAllTitles(params string[] titles)
        {
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"Title {i + 1} : {titles[i]}");
            }
        }


        #endregion
    }



    // ==========================================
    // BOOK CLASS
    // ==========================================

    #region Book Class

    class Book
    {
        // Access Modifiers - Question 1
        // private password field
         private string password = "secret";
        // Access Modifiers - Question 2
        // internal copiesInStock field
        internal int copiesInStock = 5;
        // Access Modifiers - Question 3
        // public Title field
        public string Title;


        // Access Modifiers - Question 4
        // Genre property
        public Genre genre = Genre.Science;

    }

    #endregion



    // ==========================================
    // ENUM
    // ==========================================

    #region Genre Enum

    // Declare Genre enum here
    internal enum Genre
    {
        Fiction=1,
        NonFiction,
        Science
    }

    #endregion
}
