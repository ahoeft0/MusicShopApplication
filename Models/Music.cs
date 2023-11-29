using System.ComponentModel.DataAnnotations;
namespace MusicShopApplication.Models
{
    public class Music
    {
        public required int MusicId { get; set; }

        public required string Genre { get; set; }

        public required string Performer { get; set; }

        public required string Song { get; set; }

        public required int Year { get; set; }

        public required string MusicOn { get; set; }

        public decimal Price { get; set; }
    }
}
