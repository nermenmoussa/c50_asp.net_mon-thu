using System;
using System.Text;

class Program
{
    static void Main()
    {
        q1(); q2(); q3(); q4(); q5(); q6(); q7(); q8(); q9();
        q10(); q11(); q12(); q13(); q14(); q15(); q16(); q17(); q18();
    }

    #region q1
    /*Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
    both title and upperTitle to show that title did not change.*/


    static void q1()
    {
        string title = "clean code";
        string upperTitle = title.ToUpper();

        Console.WriteLine(title);      
        Console.WriteLine(upperTitle);  
    }
    #endregion

    #region q2
    /*Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
    to check if they point to the same object in memory.*/


    static void q2()
    {
        string a = "Clean Code";
        string b = "Clean Code";

        Console.WriteLine(ReferenceEquals(a, b));
    }
    #endregion

    #region q3
    /*Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
    object. Print the final result.*/

    static StringBuilder sb = new StringBuilder();

    static void q3()
    {
        sb.Append("Book List");
        sb.Append(" - Updated");

        Console.WriteLine(sb); 
    }
    #endregion

    #region q4
    /*Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
    Print the result.*/


    static void q4()
    {
        sb.Replace("Book List", "Library");

        Console.WriteLine(sb); 
    }
    #endregion

    #region q5
    /*Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
    Pages: 464" using the + operator.*/


    static void q5()
    {
        string title = "Clean Code";
        int pages = 464;

        string sentence = "Book: " + title + ", Pages: " + pages;
        Console.WriteLine(sentence);
    }
    #endregion

    #region q6
    /*Build the same sentence as above, but using string interpolation ($"...").*/


    static void q6()
    {
        string title = "Clean Code";
        int pages = 464;

        string sentence = $"Book: {title}, Pages: {pages}";
        Console.WriteLine(sentence);
    }
    #endregion

    #region q7
    /*Build the same sentence again, but using string.Format().*/


    static void q7()
    {
        string title = "Clean Code";
        int pages = 464;

        string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
        Console.WriteLine(sentence);
    }
    #endregion

    #region q8
    /*Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
    300, otherwise prints "Short Book".*/


    static void q8()
    {
        int pages = 464;

        if (pages > 300)
            Console.WriteLine("Long Book");
        else
            Console.WriteLine("Short Book");
    }
    #endregion

    #region q9
    /*Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
    greater than 300 and isAvailable is true. Use the && operator.*/


    static void q9()
    {
        int pages = 464;
        bool isAvailable = true;

        if (pages > 300 && isAvailable)
            Console.WriteLine("You can borrow this book");
    }
    #endregion

    #region q10
    /*Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
    "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.*/


    static void q10()
    {
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
    }
    #endregion

    #region q11
    /*Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
    variable sizeLabel (same rule as question 8: long if pages > 300).*/


    static void q11()
    {
        int pages = 464;

        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
        Console.WriteLine(sizeLabel);
    }
    #endregion

    #region q12
    /*Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
    to print each book with its position number, like 1. Clean Code.*/

    static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" }; // shared with q13-q18

    static void q12()
    {
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]}");
        }
    }
    #endregion

    #region q13
    /*Using the same books array, use a while loop to print every book title.*/


    static void q13()
    {
        int i = 0;
        while (i < books.Length)
        {
            Console.WriteLine(books[i]);
            i++;
        }
    }
    #endregion

    #region q14
    /*Write a do-while loop that prints "Checking book..." exactly 3 times.*/


    static void q14()
    {
        int count = 0;
        do
        {
            Console.WriteLine("Checking book...");
            count++;
        } while (count < 3);
    }
    #endregion

    #region q15
    /*Using the same books array, use a foreach loop to print every book title.*/


    static void q15()
    {
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
    }
    #endregion

    #region q16
    /*Using the same books array, loop through it and print each title, but stop completely (break) once
    you reach "Refactoring".*/


    static void q16()
    {
        foreach (string book in books)
        {
            if (book == "Refactoring")
                break;

            Console.WriteLine(book);
        }
    }
    #endregion

    #region q17
    /*Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
    continue, don't stop the loop).*/


    static void q17()
    {
        foreach (string book in books)
        {
            if (book == "The Pragmatic Programmer")
                continue;

            Console.WriteLine(book);
        }
    }
    #endregion

    #region q18
    /*Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
    use return to exit the method early instead of printing anything.*/


    static void PrintFirstBook()
    {
        if (books.Length == 0)
            return; 

        Console.WriteLine(books[0]);
    }

    static void q18()
    {
        PrintFirstBook();                

        string[] original = books;
        books = new string[0];           
        PrintFirstBook();                 
        books = original;
    }
    #endregion
}