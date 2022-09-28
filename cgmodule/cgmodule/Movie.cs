using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Movie
{
    class Movie
    {
        private string name;
        private string movieid;
        private string director;
        private int rating;
        private DateTime releaseDate = new DateTime();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Movieid
        {
            get { return movieid; }
            set { movieid = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public Movie{
            
          public Movie(string name, string movieid, string director, int rating, DateTime releaseDate)
              {
            this.name = name;
            this.movieid = movieid;
            this.director = director;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }
        public override string ToString()
        {
            return "Name:" + name + "\n" +
                "Movieid:" + movieid + "\n" +
                "Director:" + director + "\n" +
                "Rating:" + rating + "\n" +
                "ReleaseDate:" + releaseDate;
        }
      
    }
}

                
        
    


