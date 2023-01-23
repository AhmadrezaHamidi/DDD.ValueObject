namespace DDD.ValueObject.Moneyv1
{
    public  class firstNameISReusired : Exception
    {
        public firstNameISReusired()
        {
        }

        public firstNameISReusired(string message) : base(message)
        {
        }


        public firstNameISReusired(string message, Exception exception) : base(message, exception)
        {
        }
    }
}