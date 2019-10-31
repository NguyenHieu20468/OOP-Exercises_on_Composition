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
        private Author[] Authors;
        private double Price;
        private int Qty =0;

        public Book(string name, Author [] authors, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Authors = authors;
        }

        public Book(string name, Author[]authors, double price, int qty)
            :this(name,authors,price)
        {
            this.Qty = qty;
        }

        public string getName()
        {
            return this.Name;
        }
        public Author[] getAuthors()
        {
            return this.Authors;
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
            string[] strAuthors = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                strAuthors[i] = this.Authors[i].ToString();
            }
            return String.Format("Book [ name = {0}, Authors = {{{1}}}, price = {2}, qty = {3} ", Name, String.Join(",", strAuthors), Price, Qty);
        }



        public string getAuthorNames()
        {
            string[] strNames = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                strNames[i] = this.Authors[i].getName();
            }
            return String.Join(",", strNames);
        }

        //public string getAuthorEmail()
        //{
        //    return this.Authors.getEmail();
        //}

        //public string getAuthorGender()
        //{
        //    return this.Authors.getGender();
        //}
    }
}
