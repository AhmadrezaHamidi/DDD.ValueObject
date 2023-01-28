namespace DDD.Entities;



public class CarFactory
{
    public static int id = 0;
    public static Car CreateCar()
    {
        return new Car(id++);
    }

}
public class Car
{
    public Car(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public void changeNmae(string newName)
    {
        if (string.IsNullOrEmpty(newName))
            throw new Exception();
        else
            this.Name = newName;
    }

}
public interface ICarReposetory
{
    Car GetCar(int id);
}
public class FakeCarRepository : ICarReposetory
{
    public Car GetCar(int id)
    {
        return new Car(2);
    }
}

