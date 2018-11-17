using System.Collections.Generic;

namespace FleaMarket
{
    public class CompositeSalesman : Salesman
    {
        private readonly List<Salesman> _salesmen; 
        
        /// <summary>
        /// Constructs a composite salesman.
        /// The salesman passed in constructor is
        /// the first one to be added.  
        /// </summary>
        /// <param name="salesman"></param>
        public CompositeSalesman(Salesman salesman) : base(salesman.Name)
        {
            _salesmen = new List<Salesman> {salesman};
        }

        public override void SellItem()
        {
            foreach (var salesman in _salesmen)
            {
                salesman.SellItem(); 
            }
        }

        public void Add(Salesman salesman)
        {
           _salesmen.Add(salesman); 
        }

        public void Remove(Salesman salesman)
        {
            _salesmen.Remove(salesman); 
        }
    }
}