using System.ComponentModel.DataAnnotations;
namespace PRINT_INVOICE.DAL
{

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
