using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarMenago.Models
{
    public class CarViewModel
    {
        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        /// <param name="photo"></param>
        public CarViewModel(string model,string manufacturer, decimal price, string photo)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Photo = photo;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }

    }
}
