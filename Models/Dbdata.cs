using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data
{
    public class Dbdata
    {
        [Key]
        public string name { get; set; }
        public string phone { get; set; }
        public string message { get; set; }
    }
}
