using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Book> BookObject = new List<Book>();

            bool BoolRet = true;

            string bookname;
            string authorname;
            string publicationname;
            int copies;
            int price;

            while (BoolRet)
            {
                Console.WriteLine("1 Book Details:");
                Console.WriteLine("2 Book name and display its Information:");
                Console.WriteLine("3 Book Price Range and display all books between that Range:");
                Console.WriteLine("4 Maximum Price book:");
                Console.WriteLine("5 Minimum Price book:");
                Console.WriteLine("6 Author name and display all Books of that Author:");
                Console.WriteLine("7 Book name and all information of that Book:");
                Console.WriteLine("8 all books whose number of copies less than Five:");
                Console.WriteLine("9 Total Cost of all Books:");
                Console.WriteLine("10 Exit:\n");

                Console.WriteLine("Please Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Book Details:");

                        Console.WriteLine("Enter Book Name:");
                        bookname = Console.ReadLine();
                        Console.WriteLine("Enter Book Author Name:");
                        authorname = Console.ReadLine();
                        Console.WriteLine("Enter Book Publication Name:");
                        publicationname = Console.ReadLine();
                        Console.WriteLine("Enter Number of Copies:");
                        copies = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Price of Book:");
                        price = Convert.ToInt32(Console.ReadLine());

                        Book book1 = new Book(bookname,authorname,publicationname,copies,price);
                        BookObject.Add(book1);

                        foreach (Book b in BookObject)
                        {
                            Console.WriteLine("Book Details are:");
                            Console.WriteLine("Book Name:{0}", bookname);
                            Console.WriteLine("Book  Auther Name:{0}", authorname);
                            Console.WriteLine("Book Publication Name:{0}", publicationname);
                            Console.WriteLine("Number of book Copies:{0}", copies);
                            Console.WriteLine("Book Price:{0}\n", price);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Book Name:");
                        string bookname1 = Console.ReadLine();

                        bool Book_Not_Found = false;

                        foreach (Book b in BookObject)
                        {
                            if (b.Name_Of_Book.Equals(bookname1))
                            {
                                Book_Not_Found = true;

                                Console.WriteLine("Book Details are:");
                                Console.WriteLine("Book Name:{0}", b.Name_Of_Book);
                                Console.WriteLine("Book  Auther Name:{0}", b.Name_Of_Author);
                                Console.WriteLine("Book Publication Name:{0}", b.Name_Of_Publication);
                                Console.WriteLine("Number of book Copies:{0}", b.Number_Of_Book_Copies);
                                Console.WriteLine("Book Price:{0}\n", b.Price_Of_Book);
                            }
                        }

                        if (Book_Not_Found == false)
                        {
                            Console.WriteLine("Book Not Found..");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Book Starting Price:");
                        int bookprice1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book Ending Price:");
                        int bookprice2 = Convert.ToInt32(Console.ReadLine());

                        foreach (Book b in BookObject)
                        {
                            if ((b.Price_Of_Book >= bookprice1) && (b.Price_Of_Book <= bookprice2))
                            {
                                Console.WriteLine("Book Details are:");
                                Console.WriteLine("Book Name:{0}", b.Name_Of_Book);
                                Console.WriteLine("Book  Auther Name:{0}", b.Name_Of_Author);
                                Console.WriteLine("Book Publication Name:{0}", b.Name_Of_Publication);
                                Console.WriteLine("Number of book Copies:{0}\n", b.Number_Of_Book_Copies);
                               // Console.WriteLine("Book Price:{0} ", b.Price_Of_Book);
                            }
                        }
                        break;

                    case 4:
                        int maxprice = int.MinValue;
                        int cnt = 0;
                        int MaxCnt = 0;

                        foreach (Book b in BookObject)
                        {
                            if (b.Price_Of_Book > maxprice)
                            {
                                maxprice = b.Price_Of_Book;
                                MaxCnt = cnt;
                            }
                            cnt++;
                        }

                        Console.WriteLine("Book Details are:");
                        Console.WriteLine("Book Name:{0}", BookObject[MaxCnt].Name_Of_Book);
                        Console.WriteLine("Book  Auther Name:{0}", BookObject[MaxCnt].Name_Of_Author);
                        Console.WriteLine("Book Publication Name:{0}", BookObject[MaxCnt].Name_Of_Publication);
                        Console.WriteLine("Number of book Copies:{0}\n", BookObject[MaxCnt].Number_Of_Book_Copies);
                        //Console.WriteLine("Book Price:{0} ", b.Price_Of_Book);

                        break;

                    case 5:
                        int minprice = int.MaxValue;
                        int cnt1 = 0;
                        int MinCnt = 0;

                        foreach (Book b in BookObject)
                        {
                            if (b.Price_Of_Book < minprice)
                            {
                                minprice = b.Price_Of_Book;
                                MinCnt = cnt1;
                            }
                            cnt1++;
                        }

                        Console.WriteLine("Book Details are:");
                        Console.WriteLine("Book Name:{0}", BookObject[MinCnt].Name_Of_Book);
                        Console.WriteLine("Book  Auther Name:{0}", BookObject[MinCnt].Name_Of_Author);
                        Console.WriteLine("Book Publication Name:{0}", BookObject[MinCnt].Name_Of_Publication);
                        Console.WriteLine("Number of book Copies:{0}\n", BookObject[MinCnt].Number_Of_Book_Copies);
                        //Console.WriteLine("Book Price:{0} ", b.Price_Of_Book);

                        break;

                    case 6:
                        Console.WriteLine("Enter Author Name:");
                        string authoname1 = Console.ReadLine();

                        bool Author_Not_Found = false;

                        foreach (Book b in BookObject)
                        {
                            if (b.Name_Of_Author.Equals(authoname1))
                            {
                                Author_Not_Found = true;

                                Console.WriteLine("Book Details are:");
                                Console.WriteLine("Book Name:{0}", b.Name_Of_Book);
                                Console.WriteLine("Book  Auther Name:{0}", b.Name_Of_Author);
                                Console.WriteLine("Book Publication Name:{0}", b.Name_Of_Publication);
                                Console.WriteLine("Number of book Copies:{0}", b.Number_Of_Book_Copies);
                                Console.WriteLine("Book Price:{0}\n", b.Price_Of_Book);
                            }
                        }

                        if (Author_Not_Found == false)
                        {
                            Console.WriteLine("Author Not Found..");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Enter Book Name:");
                        string bookname3 = Console.ReadLine();

                        int delcnt = 0;
                        int delete = 0;

                        foreach (Book b in BookObject)
                        {
                            if (b.Name_Of_Book.Equals(bookname3))
                            {
                                delete = delcnt;
                            }
                            delcnt++;
                        }

                        BookObject.Remove(BookObject[delcnt]);

                        Console.WriteLine("Book Information Successfully..");

                        break;

                    case 8:
                        foreach (Book b in BookObject)
                        {
                            if (b.Number_Of_Book_Copies < 5)
                            {
                                Console.WriteLine("Book Details are:");
                                Console.WriteLine("Book Name:{0}", b.Name_Of_Book);
                                Console.WriteLine("Book  Auther Name:{0}", b.Name_Of_Author);
                                Console.WriteLine("Book Publication Name:{0}", b.Name_Of_Publication);
                                Console.WriteLine("Number of book Copies:{0}", b.Number_Of_Book_Copies);
                                Console.WriteLine("Book Price:{0}\n", b.Price_Of_Book);
                            }
                        }
                        break;

                    case 9:
                        int totalcost=0; 

                    foreach (Book b in BookObject)
                    {
                        totalcost = totalcost + b.Price_Of_Book * b.Number_Of_Book_Copies;
                    }
                    Console.WriteLine("total cost of Books is:{0}",totalcost);

                    break;

                    case 10:
                        BoolRet = false;
                        break;

                    default:
                        Console.WriteLine("Wrong Choice..Please Enter Valid Choice..\n");
                        break;
                }
            }
        }
    }

    public class Book
    {
        public string Name_Of_Book;
        public string Name_Of_Author;
        public string Name_Of_Publication;
        public int Number_Of_Book_Copies;
        public int Price_Of_Book;

        public Book(string BookName, string NameOfAuthor, string NameOfPublication, int NumberOfBookCopies, int PriceOfBook)
        {
            Name_Of_Book = BookName;
            Name_Of_Author = NameOfAuthor;
            Name_Of_Publication = NameOfPublication;
            Number_Of_Book_Copies = NumberOfBookCopies;
            Price_Of_Book = PriceOfBook;
        }
    }
}
