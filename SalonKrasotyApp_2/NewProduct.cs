using SalonKrasotyApp_2.ModelEF;
using System;
using System.Drawing;
using System.Linq;

namespace SalonKrasotyApp_2
{
    class NewProduct
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Manufacturer { get; set; }
        public int DopProducts { get; set; }
        public decimal SummaSale {  get; set; }
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

            if (prd.ManufacturerID.HasValue)
                Manufacturer = prd.Manufacturer.Name;
            else
                Manufacturer = "";

            Cost = prd.Cost;

            if (prd.MainImagePath != "")
                Picture = Image.FromFile(prd.MainImagePath.Trim());
            else
                Picture = Properties.Resources.beauty_logo;

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
