using System.Collections.Generic;

namespace People
{
    
    /*
    * A remove method is commonly used with this pattern.
    * It is omitted, as we do not need it 
    */
    
    /// <summary>
    /// A salesman that may also be several salesmen,
    /// following the Composite-pattern.
    ///
    /// A remove method is commonly used in composite-
    /// classes like this, but it is omitted here, as
    /// we do not need it.
    /// </summary>
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
        
    }
}