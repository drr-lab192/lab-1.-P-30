using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                string[] names = { "ручка", "тетрадь", "карандаш", "акварель", "папка" };
                int[] prices = { 35, 120, 25, 450, 180 };
                int[] stock = { 40, 25, 30, 12, 15 };
                int[] order = new int[5];

                ShowProducts(names, prices, stock);
                ReadOrder(order, names.Length);

                int missing = FindMissingProduct(order, stock);

                if (missing == -1)
                {
                    int total = CalculateTotal(order, prices);

                    for (int i = 0; i < stock.Length; i++)
                        stock[i] -= order[i];

                    Console.WriteLine($"Стоимость заказа: {total} руб.");
                }
                else
                {
                    Console.WriteLine($"Не хватает товара: {names[missing]}");
                }

                ShowStock(names, stock);
            }

         
            static void ShowProducts(string[] names, int[] prices, int[] stock)
            {
                Console.WriteLine("Ассортимент:");

                for (int i = 0; i < names.Length; i++)
                    Console.WriteLine($"{i + 1}. {names[i]} — {prices[i]} руб., {stock[i]} шт.");
            }

            static void ReadOrder(int[] order, int productCount)
            {
                while (true)
                {
                    int number = ReadNumber("Введите номер товара (0 — конец заказа): ", 0, productCount);

                    if (number == 0)
                        break;

                    int quantity = ReadNumber("Введите количество: ", 0, int.MaxValue);
                    order[number - 1] += quantity;
                }
            }

            static int ReadNumber(string message, int min, int max)
            {
                int number;

                while (true)
                {
                    Console.Write(message);

                    if (int.TryParse(Console.ReadLine(), out number) &&
                        number >= min && number <= max)
                    {
                        return number;
                    }

                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
                }
            }

            
            static int FindMissingProduct(int[] order, int[] stock)
            {
                for (int i = 0; i < order.Length; i++)
                {
                    if (order[i] > stock[i])
                        return i;
                }

                return -1;
            }
