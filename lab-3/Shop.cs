using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Shop
    {
        private Product[] Products;

        private Shop(Product[] products)
        {
            Products = products;
        }

        private void ShowProducts() ////выводит ассортимент с номерами позиций 
        {
            Console.WriteLine("Ассортимент:");
            for (int i = 0; i < Products.Length; i++)
                Console.WriteLine($"{i + 1}. {Products[i].name} — {Products[i].price} руб., {Products[i].stock} шт.");
        }

        private int FindMissingProduct(Order order) ///проходит по всем товарам и возвращает индекс первого, которого не хватает
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (order.Quantities[i] > Products[i].stock)
                    return i;
            }
            return -1;
        }

        private int CalculateTotal(Order order) //// сумма произведений «заказанное количество × цена» по всем позициям
        {
            int total = 0;
            for (int i = 0; i < Products.Length; i++)
                total += order.Quantities[i] * Products[i].price;
            return total;
        }

        public void WriteOff(Order order) ////списывает остатки
        {
            for (int i = 0; i < Products.Length; i++)
                Products[i].WriteOff(order.Quantities[i]);
        }

        public void ShowStock() //// выводит финальные остатки по каждой позиции в порядке прайс-листа
        {
            Console.WriteLine("Остатки:");
            for (int i = 0; i < Products.Length; i++)
                Console.WriteLine($"{Products[i].name} — {Products[i].stock} шт.");
        }
    }
}
