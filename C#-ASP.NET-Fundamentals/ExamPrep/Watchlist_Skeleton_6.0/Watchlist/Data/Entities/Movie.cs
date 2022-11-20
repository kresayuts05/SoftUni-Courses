using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Watchlist.Data.DataConstants.Movie;

namespace Watchlist.Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxMovieTitle)]
        public string Title { get; set; }

        [Required]
        [MaxLength(MaxMovieDirector)]
        public string Director { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Rating { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; }

        public IEnumerable<UserMovie> UsersMovies { get; set; }
    }
}
//•	Has Id – a unique integer, Primary Key
//•	Has Title – a string with min length 10 and max length 50 (required)
//•	Has Director – a string with min length 5 and max length 50 (required)
//•	Has ImageUrl – a string (required)
//•	Has Rating – a decimal with min value 0.00 and max value 10.00 (required)
//•	Has GenreId – an integer (required)
//•	Has Genre – a Genre (required)
//•	Has UsersMovies – a collection of type UserMovie
