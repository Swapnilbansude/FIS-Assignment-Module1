using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime CreatedOn { get; set; }

        public Product()
        {

        }

        public Product(int id,string name,double price, string category,DateTime createdOn)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.CreatedOn = createdOn;
        }

        public override string ToString()
        {
            return $"ID={this.ID}, Name={this.Name}, Price={this.Price}, Category={this.Category}, Created On={this.CreatedOn.ToShortDateString()}";
        }

    }
}
