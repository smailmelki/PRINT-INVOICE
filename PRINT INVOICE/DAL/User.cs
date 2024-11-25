using System.ComponentModel.DataAnnotations;

namespace PRINT_INVOICE.DAL
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Roles { get; set; }
    }
}
