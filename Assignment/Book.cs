using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[]? Authors { get; set; }
        public DateTime PublicatonDate { get; set; }
        public decimal Price { get; set; }
        public Book(string? iSBN, string? title, string[]? authors, DateTime publicatonDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicatonDate = publicatonDate;
            Price = price;
        }

        public override string ToString()
        {
            string authors = string.Join(", ", Authors);
            return $"ISBN: {ISBN} & Title: {Title} & Authors: {Authors} & PublicatonDate: {PublicatonDate} & Price: {Price}";
        }
    }
}
