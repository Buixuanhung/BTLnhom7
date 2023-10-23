using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLnhom07.Models
{
    [Table("Khoss")]
    public class Kho
    {
        [Key]
        
        public string SanPhamName {get; set; }
        public string SoLuongTong {get; set; }
        
        public string SoluongXuat {get; set; }
        public string SoLuongTon {get; set; }
        
     
    }
}