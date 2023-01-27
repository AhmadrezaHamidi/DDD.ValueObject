using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace DDD.ValueObjectData;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}



public class FullName
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public override string ToString()
    {
        return $"{FirstName}:{LastName}";
    }
    public static FullName GetFullName(string fullName)
    {
        var spilit = fullName.Split(":");
        return new FullName
        {
            FirstName = spilit[0],
            LastName = spilit[1]
        };
    }

}


public class Person
{
    public FullName fullName { get; set; }
    public int Id { get; set; }
}

public class PersonContext : DbContext
{
    public PersonContext() : base()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ggg.Db;Uid=sa;Pwd=yourStrong(!)Password");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .OwnsOne(x => x.fullName);
        //.Property(c => c.fullName).HasConversion(x => x.ToString(), d => FullName.GetFullName(d));
    }


    public DbSet<Person> Persons { get; set; }
}
