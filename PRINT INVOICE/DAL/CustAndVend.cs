using System.ComponentModel.DataAnnotations;

namespace PRINT_INVOICE.DAL
{
    public class CustAndVend
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public PartType PartType { get; set; }
    }
}
