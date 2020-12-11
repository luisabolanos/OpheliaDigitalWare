using System.ComponentModel.DataAnnotations;

namespace OpheliaDigitalWare.Api.Client
{
    public class Client
    {
        [Key]
        public int id { get; set; }
        public string identification { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
