namespace SpecSample;
public class Class1
{
    

    //Composite Pattern



    //Age >> 18 or (country == iran and Age > 15 )
    /// --perdicate Or (perdicate and perdicatre )  


}

public class AndSpecification<T> : CompositeSpecifaction<T>
{
    public AndSpecification(ISpecification<T> right, ISpecification<T> left) : base(right, left)
    {
    }

    public override bool isStatisFindBy(T value)
    {

        return _right.isStatisFindBy(value) && _left.isStatisFindBy(value);

    }
}


public abstract class CompositeSpecifaction<T> : ISpecification<T>
{

    protected ISpecification<T> _right;
    protected ISpecification<T> _left;

    protected CompositeSpecifaction(ISpecification<T> right, ISpecification<T> left)
    {
        _right = right;
        _left = left;
    }

    public abstract bool isStatisFindBy(T value);
    
}


public interface ISpecification<T> {
    bool isStatisFindBy(T value);
}


public class PosetiveSpcification : ISpecification<int>
{
    public bool isStatisFindBy(int value)
    {
        return value > 0;
    }
    //Re-Use ==> validation -selection

}


