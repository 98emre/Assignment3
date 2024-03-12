using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra.Inheritance.Problem2
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;

        public Book() { }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }


        public string Title
        {
            get { return title; }

            set
            {
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                title = value;
            }
           
        }


        public string Author
        {
            get { return author; }

            set
            {
                string[] parts = value.Split(' ');

                if(parts.Length >= 2 && char.IsDigit(parts[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }

               author = value;
            }
        }

        public virtual double Price
        {
            get { return price; }

            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                price = value;
            }
        }

        public string FormattedPrice
        {
            get { return Price.ToString("0.00");  }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {this.GetType().Name}")
              .AppendLine($"Title: {this.Title}")
              .AppendLine($"Author: {this.Author}")
              .AppendLine($"Price: {this.Price:f2}");
          
            return sb.ToString();
        }
    }
}
