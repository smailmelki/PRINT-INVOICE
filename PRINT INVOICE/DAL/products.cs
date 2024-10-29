namespace PRINT_INVOICE.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class products
    {
        public int id { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(50)]
        public string productName { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsActive { get; set; }
    }
}
