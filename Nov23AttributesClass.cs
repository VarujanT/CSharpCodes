using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AttributesNov23
{
    [Obsolete("Sa hnacac dase, ogtagorceq Good Book dase")]
    [Serializable]
    public class Book
    {
        public string Author { set; get; }
        public string Title { set; get; }
        public int Page { get => page; set => page = value; }
        public decimal Price { get => price; set => price = value; }

        [NonSerialized]
        private int page;
        private decimal price;

        public override string ToString()
        {
            return Author + "\t" + Title + "\t" + Page + "\t" + Price;
        }
    }
}