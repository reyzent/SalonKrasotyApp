namespace SalonKrasotyApp_2.ModelEF
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ProductSale")]
    public partial class ProductSale
    {
        public int ID { get; set; }

        public DateTime SaleDate { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public int? ClientServiceID { get; set; }

        public virtual ClientService ClientService { get; set; }

        public virtual Product Product { get; set; }
    }
}
