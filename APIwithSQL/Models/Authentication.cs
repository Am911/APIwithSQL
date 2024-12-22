using System.ComponentModel.DataAnnotations;

namespace APIwithSQL.Models
{
    public class Authentication
    {
        [Key]
        public int UserAuthId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
