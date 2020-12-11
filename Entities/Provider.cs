using System.ComponentModel.DataAnnotations;

namespace OpheliaDigitalWare.Entities
{
    public class Provider
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string identification { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
