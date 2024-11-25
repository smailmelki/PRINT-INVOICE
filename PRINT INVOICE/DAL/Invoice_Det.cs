using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PRINT_INVOICE.DAL
{

    public partial class Invoice_Det
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Item_Code { get; set; }
        public int Item_Qty { get; set; }
        public decimal Item_Price { get; set; }
        public decimal total_Price { get; set; }
        [Required]
        public int InvoiceID { get; set; }
        public bool IsIN { get; set; }
    }
}
