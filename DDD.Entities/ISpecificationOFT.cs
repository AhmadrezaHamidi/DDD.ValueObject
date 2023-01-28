using System;
namespace DDD.Entities
{
	//public interface ISpecification<T>
	//{
	//	//Logic haye If and Else 
	//	bool IsSatisFiedBy(T Entity);
	//}



	public interface IDomainEvent
	{

	}


    public interface IEventHandler<in T> where T : IDomainEvent
    {
		void Handle(T @event);
    }
	public interface IEventDispatcher
	{
		void Dispatcher<T>(params T[] events) where T : IDomainEvent;

    }
}

