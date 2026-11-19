
using System;
using System.Text;

class Program
{
    // Shared array used by questions 12-18
    static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

    static void Main()
    {
        Q1(); Q2(); Q3_4(); Q5(); Q6(); Q7(); Q8(); Q9(); Q10(); Q11();
        Q12(); Q13(); Q14(); Q15(); Q16(); Q17(); Q18();
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
    /* Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
      to check if they point to the same object in memory.*/


    #endregion

    // Q2: identical literals are interned by the CLR, so both point to the same object
    static void Q2()
    {
        Console.WriteLine("--- Q2 ---");
        string a = "Clean Code";
        string b = "Clean Code";
        Console.WriteLine(ReferenceEquals(a, b)); // True
    }

    // Q3 + Q4: StringBuilder is mutable
    static void Q3_4()
    {
        Console.WriteLine("--- Q3 ---");
        StringBuilder sb = new StringBuilder();
        sb.Append("Book List");
        sb.Append(" - Updated");
        Console.WriteLine(sb); // Book List - Updated

        Console.WriteLine("--- Q4 ---");
        sb.Replace("Book List", "Library");
        Console.WriteLine(sb); // Library - Updated
    }

    // Q5: + operator
    static void Q5()
    {
        Console.WriteLine("--- Q5 ---");
        string title = "Clean Code";
        int pages = 464;
        string sentence = "Book: " + title + ", Pages: " + pages;
        Console.WriteLine(sentence);
    }

    // Q6: string interpolation
    static void Q6()
    {
        Console.WriteLine("--- Q6 ---");
        string title = "Clean Code";
        int pages = 464;
        string sentence = $"Book: {title}, Pages: {pages}";
        Console.WriteLine(sentence);
    }

    // Q7: string.Format
    static void Q7()
    {
        Console.WriteLine("--- Q7 ---");
        string title = "Clean Code";
        int pages = 464;
        string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
        Console.WriteLine(sentence);
    }

    // Q8: if / else
    static void Q8()
    {
        Console.WriteLine("--- Q8 ---");
        int pages = 464;
        if (pages > 300)
            Console.WriteLine("Long Book");
        else
            Console.WriteLine("Short Book");
    }

    // Q9: && operator
    static void Q9()
    {
        Console.WriteLine("--- Q9 ---");
        int pages = 464;
        bool isAvailable = true;
        if (pages > 300 && isAvailable)
            Console.WriteLine("You can borrow this book");
    }

    // Q10: switch
    static void Q10()
    {
        Console.WriteLine("--- Q10 ---");
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

    // Q11: ternary operator
    static void Q11()
    {
        Console.WriteLine("--- Q11 ---");
        int pages = 464;
        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
        Console.WriteLine(sizeLabel);
    }

    // Q12: for loop with position number
    static void Q12()
    {
        Console.WriteLine("--- Q12 ---");
        for (int i = 0; i < books.Length; i++)
            Console.WriteLine($"{i + 1}. {books[i]}");
    }

    // Q13: while loop
    static void Q13()
    {
        Console.WriteLine("--- Q13 ---");
        int i = 0;
        while (i < books.Length)
        {
            Console.WriteLine(books[i]);
            i++;
        }
    }

    // Q14: do-while loop (runs exactly 3 times)
    static void Q14()
    {
        Console.WriteLine("--- Q14 ---");
        int count = 0;
        do
        {
            Console.WriteLine("Checking book...");
            count++;
        } while (count < 3);
    }

    // Q15: foreach loop
    static void Q15()
    {
        Console.WriteLine("--- Q15 ---");
        foreach (string book in books)
            Console.WriteLine(book);
    }

    // Q16: break once "Refactoring" is reached
    // (As written, "Refactoring" is the last item, so it is not printed.)
    static void Q16()
    {
        Console.WriteLine("--- Q16 ---");
        foreach (string book in books)
        {
            if (book == "Refactoring")
                break;
            Console.WriteLine(book);
        }
    }

    // Q17: continue to skip "The Pragmatic Programmer"
    static void Q17()
    {
        Console.WriteLine("--- Q17 ---");
        foreach (string book in books)
        {
            if (book == "The Pragmatic Programmer")
                continue;
            Console.WriteLine(book);
        }
    }

    // Q18: method with early return
    static void PrintFirstBook()
    {
        if (books.Length == 0)
            return; // exit early, print nothing

        Console.WriteLine(books[0]);
    }

    static void Q18()
    {
        Console.WriteLine("--- Q18 ---");
        PrintFirstBook();                 // Clean Code

        string[] original = books;
        books = new string[0];            // empty array
        PrintFirstBook();                 // prints nothing
        books = original;
    }
}