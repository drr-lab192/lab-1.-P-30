using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Product
    {
        private string Name_;
        private int Price_;
        private int Stock_;

        public Product(string name, int price, int stock)
        {
            Name_ = name;
            Price_ = price;
            Stock_ = stock;
        }
    }
}