namespace Market
{
    public class Customer : Person
    {
        public Customer(string name) : base(name)
        {

        }

        protected override void Act()
        {
            throw new System.NotImplementedException();
        }
    }
}