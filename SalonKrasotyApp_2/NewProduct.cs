using SalonKrasotyApp_2.ModelEF;
using System;
using System.Drawing;
using System.Linq;

namespace SalonKrasotyApp_2
{
    internal class NewProduct
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Manufacturer { get; set; }
        public int DopProducts { get; set; }
        public decimal SummaSale { get; set; }
        public Image Picture { get; set; }
        public bool IsActive { get; set; }

        public NewProduct()
        {

        }

        public NewProduct(Product prd)
        {
            ID = prd.ID;
            Title = prd.Title;
            Description = prd.Description;
            DopProducts = prd.Product1.Count;

            Manufacturer = prd.ManufacturerID.HasValue ? prd.Manufacturer.Name : "";

            Cost = prd.Cost;

            Picture = prd.MainImagePath != "" ? Image.FromFile(prd.MainImagePath.Trim()) : Properties.Resources.beauty_logo;

            DateTime today = DateTime.Today;
            DateTime date1 = today.AddDays(-30);

            int nSale = prd.ProductSale
                .Where(s => (s.SaleDate > date1 && s.SaleDate < today))
                .Sum(x => x.Quantity);

            SummaSale = nSale * prd.Cost;
            IsActive = prd.IsActive;
        }
    }
}
