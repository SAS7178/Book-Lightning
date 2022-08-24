using System;
using System.Collections.Generic;

        //create new instance of book
        Book MyOldMan = new Book()
        {
              Author = "Not Hemmingway",
             Title =  "My old man and the Sea",  
             PublishDate = new DateTime(1987)
        };
        Book MyOld = new Book()
        {
              Author = "Not Khalid",
             Title =  "Kit Running",  
             PublishDate = new DateTime(1999)
        };
        Book My = new Book()
        {
              Author = "Not Stephanie",
             Title =  "Glasses Caste",  
             PublishDate = new DateTime(2000)
        };

        //create new list of books
         List<Book> myBooks = new List<Book>();
         
            myBooks.Add(MyOldMan);
            myBooks.Add(MyOld);
            myBooks.Add(My);
    // iteraet the list and console write 
     foreach (Book book in myBooks)
    {
        Console.WriteLine($"Written by {book.Author} having the title of {book.Title}.");
    }
                                                                                                                                                                                                                                                       
public class Book
{
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        

        //constructor method that allows to create new instances of book with a signature that matches
         public Book() 
        {
             Author = "";
             Title =  "";  
             PublishDate = new DateTime(1989);
        }


}

