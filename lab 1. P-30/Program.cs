using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.P_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double orderCost = ReadPositiveDouble("Введите стоимость заказа (руб.): ");
            double distance = ReadPositiveDouble("Введите расстояние доставки (км): ");
            int hour = ReadHour("Введите время заказа (час, 0-23): ");

            double deliveryPrice = CalculateDeliveryPrice(orderCost, distance, hour);
            double total = orderCost + deliveryPrice;

            Console.WriteLine($"Стоимость доставки: {deliveryPrice} руб.");
            Console.WriteLine($"Итого к оплате: {total} руб.");
        }

        static double ReadPositiveDouble(string message)
        {
            double value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (double.TryParse(input, out value) && value >= 0)
                {
                    return value;
                }
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }

        
