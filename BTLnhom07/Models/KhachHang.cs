using System.ComponentModel.DataAnnotations;


namespace BTLnhom07.Models
{
    
    public class KhachHang
    {
        [Key]
        public string KhachHangCode {get; set; }
        
        public string KhachHangName {get; set; }
        
        public string PhoneNumber {get; set; }
        public string Address {get; set; }
        
        
        
        
        
    }
}