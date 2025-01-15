using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data
{
    public class Dbdata
    {
        
        public string name { get; set; }
        [Key]
        public string phone { get; set; }
        public string message { get; set; }
    }
}
