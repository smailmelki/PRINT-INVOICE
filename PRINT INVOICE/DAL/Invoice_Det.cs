using System.ComponentModel.DataAnnotations;
namespace PRINT_INVOICE.DAL
{

    public partial class Invoice_Det
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Item_Code { get; set; }

        public int Item_Qty { get; set; }

        public decimal Item_Price { get; set; }

        public decimal total_Price { get; set; }

        [Required]
        public int InvoiceID { get; set; }
        public bool IsIN { get; set; }
    }
}
