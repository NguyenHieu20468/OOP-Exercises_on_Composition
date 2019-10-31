using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Author_and_Book_Classes
{
    public class Book
    {
        private string Name;
        private Author Author;
        private double Price;
        private int Qty =0;

        public Book(string name, Author author, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Author = author;
        }

        public Book(string name, Author author, double price, int qty)
            :this(name,author,price)
        {
            this.Qty = qty;
        }

        public string getName()
        {
            return this.Name;
        }
        public Author getAuthor()
        {
            return this.Author;
        }

        public double getPrice()
        {
            return this.Price;
        }

        public void setPrice(double price)
        {
            this.Price = price;
        }

        public int getQty()
        {
            return this.Qty;
        }

        public void setQty(int qty)
        {
            this.Qty = qty;
        }

        public override string ToString()
        {
            return String.Format("Book [ name = {0}, Author [{1}], price = {2}, qty = {3} ", Name, Author, Price, Qty);
        }

        public string getAuthorName()
        {
            return this.Author.getName();
        }

        public string getAuthorEmail()
        {
            return this.Author.getEmail();
        }

        public string getAuthorGender()
        {
            return this.Author.getGender();
        }
    }
}
