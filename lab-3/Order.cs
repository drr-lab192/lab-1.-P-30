using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Order
    {
        public int[] Quantities;

        public Order(int productCount)  //создаёт пустой заказ 
        {
            Quantities = new int[productCount];
        }

        public void Add(int productIndex, int quantity) ///прибавляет количество к позиции заказа
        {
            Quantities[productIndex] += quantity;
        }
    }
}
