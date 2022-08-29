using System;

namespace Assignment
{
    namespace Entities
    {
        class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public double Price { get; set; }
            public short Stock { get; set; }
        }
    }

    namespace Repository
    {
        using Entities;
        class BookRepo
        {
            public BookRepo(int size)
            {
                _books = new Book[size];
            }
            private Book[] _books = null;

            public void AddNewBook(Book book)
            {
                //find the first occurance of null in the array
                for (int i = 0; i < _books.Length; i++)
                {
                    if (_books[i] == null)
                    {
                        _books[i] = new Book
                        {
                            BookId = book.BookId,
                            Title = book.Title,
                            Author = book.Author,
                            Price = book.Price,
                            Stock = book.Stock,
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("No further books can be added here!!!");
            }

            public void UpdateBook(int id, Book book)
            {
                
                for (int i = 0; i < _books.Length; i++)
                {
                    if (_books[i] != null && _books[i].BookId == id)
                    {
                        _books[i] = new Book
                        {
                            BookId = book.BookId,
                            Title = book.Title,
                            Author = book.Author,
                            Price = book.Price,
                            Stock = book.Stock,
                        };
                        return;
                    }
                    else continue;
                }
                throw new Exception("No book was found to Update!!!");
            }

            public void DeleteBook(int id)
            {
                
                for (int i = 0; i < _books.Length; i++)
                {
                   
                    if (_books[i] != null && _books[i].BookId == id)
                    {
                       
                        _books[i] = null;
                        
                        return;
                    }
                }
            }

            public Book FindBook(int id)
            {
                foreach (Book book in _books)
                {
                    if (book.BookId == id)
                        return book;
                }
                throw new Exception("No book was found by id " + id);
            }

            public Book[] FindBook(string title)
            {
                throw new Exception("to be implemented by U");
            }

        }
    }

    namespace UserInterface
    {
        using Entities;
       
        class Util
        {
            public static string GetString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            public static int GetNumber(string question)
            {
                return int.Parse(GetString(question));
            }
            public static short GetShortNumber(string question) => short.Parse(GetString(question));

            public static double GetDoubleNumber(string question) => double.Parse(GetString(question));
        }

        class UIClass
        {
            private static Repository.BookRepo repo = null;
            const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~BOOK REPOSTORE MANAGER~~~~~~~~~~~~~~~~~~~~~~~\nTO ADD NEW BOOK------------>PRESS N\nTO UPDATE BOOK------------->PRESS U\nTO DELETE A BOOK----------->PRESS D\nTO FIND BY TITLE----------->PRESS T\nTO FIND BY ID-------------->PRESS F\nPS: ANY OTHER KEY IS EXIT.............................................";
            static void Main(string[] args)
            {
                int size = Util.GetNumber("Enter the no of Books in your store");
                repo = new Repository.BookRepo(size);
                var processing = true;
                do
                {
                    string choice = Util.GetString(menu);
                    processing = processMenu(choice);
                } while (processing);
            }

            private static bool processMenu(string choice)
            {
                switch (choice)
                {
                    case "N":
                        addingBookFeature();
                        break;
                    case "D":
                        deletingBookFeature();
                        break;
                    case "U":
                        updatingBookFeature();
                        break;
                    case "F":
                        findingByIdFeature();
                        break;
                    case "T":
                        Console.WriteLine("Do it URSELF!!!!!!");
                        return true;
                    default:
                        return false;
                }
                return true;
            }

            private static void findingByIdFeature()
            {
               
                int id = Util.GetNumber("Enter the Id of the book to find");
                
                var foundBook = repo.FindBook(id);
                if (foundBook != null)
                {
                    
                    Console.WriteLine($"The Title of the Book is {foundBook.Title} written by {foundBook.Author} that costs {foundBook.Price} and available at ISBN {foundBook.BookId}");
                }
                else
                {
                    Console.WriteLine("Book not found to display!!!!");
                }
            }

            private static void updatingBookFeature()
            {
                
                var bk = createBook();
                 
                repo.UpdateBook(bk.BookId, bk);
                
                Console.WriteLine("Book updated successfully");
            }

            private static Book createBook()
            {
                int id = Util.GetNumber("Enter the Id of the book ");
                string title = Util.GetString("Enter the title ");
                string author = Util.GetString("Enter the Author Name ");
                double price = Util.GetDoubleNumber("Enter the Price of the book ");
                short stock = Util.GetShortNumber("Enter the stock count ");
                
                Book bk = new Book
                {
                    BookId = id,
                    Author = author,
                    Stock = stock,
                    Title = title,
                    Price = price,
                };
                return bk;
            }
            private static void deletingBookFeature()
            {
                
                int id = Util.GetNumber("Enter the Id of the book to delete");
                
                repo.DeleteBook(id);
               
                Console.WriteLine("Book deleted Successfully");
            }

            private static void addingBookFeature()
            {
      
                Book bk = createBook();
                 
                repo.AddNewBook(bk);
                
                Console.WriteLine("Book added successfully");
            }
        }
    }
}