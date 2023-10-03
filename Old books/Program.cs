using System;

namespace Old_books
{
    class Program
    {
        static void Main(string[] args)
        {
            string wanted_book = Console.ReadLine();
            int checked_books = 0;
            string book_searched = Console.ReadLine();
            while ( book_searched != "No More Books")
            {
                if (wanted_book == book_searched)
                {
                    Console.WriteLine($"You checked {checked_books} books and found it.");
                    break;
                }
                else
                {
                    checked_books++;
                    book_searched = Console.ReadLine();
                }
            }
            if (book_searched == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checked_books} books.");
            }
            
        }
    }
}
