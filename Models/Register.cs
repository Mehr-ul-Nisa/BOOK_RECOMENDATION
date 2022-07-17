using System.ComponentModel.DataAnnotations;

namespace bookshop.Models
{
    public class Register
    {
        [Key]
        public string uname { get; set; }
        public string pswd { get; set; }
    }
}
