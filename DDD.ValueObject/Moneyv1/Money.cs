using System;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DDD.ValueObject.Moneyv1
{
	public class Money : ValueObject
    {
		protected readonly decimal _dollar;
		protected readonly decimal _reial;

		public Money() { }
        public Money(decimal dollar) {
            _dollar = dollar;
            _reial = dollar * 50;
        }




        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _dollar;
            yield return _reial;
        }
    }


 
}

