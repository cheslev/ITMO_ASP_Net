using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPNet_Lab1_WebAppCoreProduct.Models;

namespace ASPNet_Lab1_WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        public string MessageRezult;
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Product { get; set; }
        public void OnGet()
        {
            MessageRezult = "Для товара можно определить скидку";
        }


        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "Переданы некорректные данные. Повторите ввод";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageRezult = $"Для товара {name} с ценой {price} скидкаполучится { result}";
            Product.Price = price;
            Product.Name = name;
        }

        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();
            var result = price * (decimal?)discont / 100;
            MessageRezult = $"Для товара {name} с ценой {price} и скидкой {discont} получится { result}";
            Product.Price = price;
            Product.Name = name;
        }

        public void OnPostRandom(string name, decimal? price)
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.RandomNumber(1, 99);
            Product = new Product();
            var result = price * (100 - randomNumber) / 100;
            MessageRezult = $"Для товара {name} с ценой {price} случайное число {randomNumber} получится {result}";
            Product.Price = price;
            Product.Name = name;
        }

        public class RandomGenerator
        {
            private readonly Random _random = new Random();
            public int RandomNumber(int min, int max)
            {
                return _random.Next(min, max);
            }
        }
    }
}
