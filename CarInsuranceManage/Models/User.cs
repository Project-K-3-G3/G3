using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CarInsuranceManage.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        [Required]
        [StringLength(100)]
        public string full_name { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [StringLength(15)]
        public string phone_number { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [Required]
        public string user_type { get; set; }  // 'Customer' or 'Employee'

        public DateTime created_at { get; set; } = DateTime.Now;
    }
}
