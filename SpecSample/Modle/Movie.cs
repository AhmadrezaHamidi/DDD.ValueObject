using System;
namespace SpecSample.Modle
{
	public class Movie
	{
		public Movie()
		{
		}

		public DateTime PublishDate { get; set; }
		public Rate Rate { get; set; }
		public Genre Genre { get; set; }




	}

   



    public class OldAppropiateMovie : ISpecification<Movie>
    {
        public bool isStatisFindBy(Movie value)
        {
            return value.PublishDate < DateTime.Now.AddYears(-10);
        }
    }




    public class ComediMovie : ISpecification<Movie>
    {
        public bool isStatisFindBy(Movie value)
        {
            return value.Rate == Rate.B;
        }
    }



    public enum Genre
    {
		Comedy,Darama,
		Documnerty
	}

    public enum Rate
    {
       A,B,C,D
    }

}

