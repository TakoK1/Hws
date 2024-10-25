using static System.Reflection.Metadata.BlobBuilder;

//1.შექმენით კლასი Book რომელსაც ექნება შემდეგი private field ები:
//*title
//* author
//* isbn
//* copiesAvailable

using System;
using System.Security.Cryptography;
using System.Dynamic;
using System.Reflection;
public class Book
{
    //private fields
    private string title;
    private string author;
    private string isbn;
    private int copiesAvailabe;

    
    

}





//2.დააიმპლემენტირეთ property ები რომლებიც ზემოთ შექმნილ private field ებს ემუშავებიან.ISBN property გახადეთ
//set only
public string Title
{
    get { return title;}
    set { title = value; }
}
public string Author
{
    get { return author; }
    set { author = value; }
}
public string ISBN
{
    set { isbn = value; }
}
public int copiesAvailabe
{
    get { return Copiesavailable;}
    set { if value>0) } { copiesavailable = value;
    }
}


//3. setter ებში დაამატეთ ვალიდაციები. (მინიმუმ 2)
    // ერთი ხო დავამატე უკვე value > 0 ანუ ერთად ეგ ითვლება და მეორეს მოვიფიქრებ ეხა
    public string ISBN
{
    set {if (value.Length == 13)
        
        isbn = value; }
}
// ანუ ეს isbn როგორც ვნახე წიგნის ნომერიაო და ყველა 13 სიმბოლოსგან უნდა შედგებოდესო და იყოს ეს




//4. Book კლასს შეუქმენით კონსტრუქტორი, რომლიდანაც ყველა ველს მიიღებთ და შესაბამის მნიშვნელობებს მიანიჭებთ


   public Book(string title, string author, string isbn, int copiesAvailable)




//5. Book კლასს შეუქმენით მეთოდები:

//*DissplayInfo
//* BorrowBook
//* ReturnBook

public void Dissplayinfo()
{
    Console.WriteLine("Title: {title}, Author: {author}, ISBN: {isbn}, Copies Available: {copiesAvailable}")
}

public bool Bowworbook()
{
    if ( copiesAvailabe)
}







//6.შექმენით Library კლასი, რომელსაც ექნება private field ი books.
    using System;
    public class Library
    //private field 
    private string books

//7.დააიმპლემენტირეთ მეთოდები Library კლასში:

//*AddBook
//* RemoveBook
//* DisplayAllBooks



8.Library კლასს დაამატეთ ძებნის ფუნქციონალი

9. შექმენით ლუპი და კონსოლში მოემსახურეთ კლიენტებს, რომლებსაც ბიბლიოთეკასთან მუშაობა სჭირდებათ.
