using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_6
{
    struct Assignment1book
    {
        private string title;
        Booktype booktype;
        private float price;
        private int book_id;

        public void getValues(string t, Booktype a, float s, int id)
        {
            title = t;
            booktype = a;
            price = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Booktype : {0}", booktype);
            Console.WriteLine("Price : {0}", price);
            Console.WriteLine("Book_id :{0}", book_id);
            Console.WriteLine("---------------------------------------");
        }
    }



    public enum Booktype
    {
        Magazine = 1, Novel, ReferenceBook, Miscellaneous
    }

    public class testStructure
    {

        public static void Main()
        {
            Assignment1book Book1 = new Assignment1book();   /* Declare Book1 of type Book */
            Assignment1book Book2 = new Assignment1book();   /* Declare Book2 of type Book */

            /* book 1 specification */
            Book1.getValues("Programming edition2", Booktype.ReferenceBook, 1510, 176);

            /* book 2 specification */
            Book2.getValues("Good Housekeeping", Booktype.Magazine, 51015, 1999);

            /* print Book1 info */
            Book1.display();

            /* print Book2 info */
            Book2.display();

            Console.ReadKey();
        }
    }
}
