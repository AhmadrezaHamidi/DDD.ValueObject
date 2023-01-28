namespace DDD.Entities;



public class CarFactory
{
    public static int id = 0;
    public static Car CreateCar() {
        return new Car(id++)
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

