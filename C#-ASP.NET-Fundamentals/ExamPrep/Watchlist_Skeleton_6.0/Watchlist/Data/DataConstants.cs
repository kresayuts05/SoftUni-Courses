namespace Watchlist.Data
{
    public class DataConstants
    {
        public class Movie
        {
            public const int MaxMovieTitle = 50;
            public const int MinMovieTitle = 10;

            public const int MaxMovieDirector = 50;
            public const int MinMovieDirector = 5;

            public const decimal MaxMovieRating = 10;
            public const decimal MinMovieRating = 0;
        }

        public class Genre
        {
            public const int MaxGenereName = 50;
            public const int MinGenereName = 5;
        }

        public class User
        {
            public const int MaxUserName = 20;
            public const int MinUserName = 5;

            public const int MaxUserEmail = 60;
            public const int MinUserEmail = 10;

            public const int MaxUserPassword = 20;
            public const int MinUserPassword = 5;
        }
    }
}
