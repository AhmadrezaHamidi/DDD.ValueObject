// See https://aka.ms/new-console-template for more information
using SpecSample;
using SpecSample.Modle;

Console.WriteLine("Hello, World!");

        var oldKidsMovie = new AndSpecification<Movie>(new ComediMovie(), new OldAppropiateMovie());


        var movieHH = new Movie()
        {
            Rate = Rate.B,
            Genre = Genre.Darama,
            PublishDate = new DateTime(1989, 03, 09)
        };






var movieOld = new Movie()
{
    Rate = Rate.B,
    Genre = Genre.Darama,
    PublishDate = new DateTime(1989, 03, 09)
};


var resultOldMovie = oldKidsMovie.isStatisFindBy(movieOld);
///Result must ne true

Console.WriteLine(resultOldMovie);


var movieNew = new Movie()
{
    Rate = Rate.B,
    Genre = Genre.Darama,
    PublishDate = new DateTime(2023, 03, 09)
};


var resultMovieNew = oldKidsMovie.isStatisFindBy(movieNew);
//Musgt be false 


Console.WriteLine(resultMovieNew);


Console.ReadKey();