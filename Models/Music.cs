using System.ComponentModel.DataAnnotations;
namespace MusicShopApplication.Models
{
    public class Music
    {
        public required int MusicId { get; set; }

        public required string Genre { get; set; }

        public required string Performer { get; set; }

        public decimal Price { get; set; }
    }
}
