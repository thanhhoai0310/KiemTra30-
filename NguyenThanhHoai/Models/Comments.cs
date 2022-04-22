using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThanhHoai.Models {
    public class Comments {
        public int ID { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }
    }
}