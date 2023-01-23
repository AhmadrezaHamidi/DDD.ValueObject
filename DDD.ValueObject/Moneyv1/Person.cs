using System;
namespace DDD.ValueObject.Moneyv1
{
	public class Person
	{
		public Person(uniqName uniqName , Birthadte Birthadte ,
			MarrDate MarrDate)
		{
			this.uniqName = uniqName;
			this.Birthadte = Birthadte;
			this.MarrDate = MarrDate;
        }

		public uniqName uniqName { get; private set; }
		public Birthadte Birthadte { get;private set; }
		public MarrDate MarrDate { get; private set; }
	}

	public class uniqName
	{


		public static uniqName uNiqNamwCreate(string firstName, string lastName)
		{
			if (string.IsNullOrEmpty(firstName))
				throw new firstNameISReusired();

            if (string.IsNullOrEmpty(lastName))
                throw new firstNameISReusired();

            return new uniqName(firstName, lastName);
		}

		private uniqName(string firstName , string lastName)
		{
			this._firstName = firstName;
			this._lastName = lastName;
        }

        public string _firstName { get; private set; }
        public string _lastName { get; private set; }

    }

    public class MarrDate
	{

		private readonly DateTime MarrDateAt;
		public MarrDate(DateTime marrigeDate)
		{
			MarrDateAt = marrigeDate;
		}

	}



    public class Birthadte
    {

        private readonly DateTime MarrDateAt;
        public Birthadte(DateTime marrigeDate)
        {
            MarrDateAt = marrigeDate;
        }

    }
}

