namespace PRINT_INVOICE.DAL
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Invoice_Header
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Invoice_Nu { get; set; }

        public DateTime Invoice_Date { get; set; }

        [Required]
        public int Customer_ID { get; set; }

        public decimal Invoice_Total { get; set; }

        public decimal Invoice_Discount { get; set; }

        public decimal Invoice_Tax { get; set; }

        public decimal Invoice_Net { get; set; }

        public decimal Invoice_Paid { get; set; }

        public decimal Invoice_remain { get; set; }

        [Required]
        public InvoiceType Invoice_Type { get; set; }

        public string invoice_Note { get; set; }
    }
}
