using System;
using System.Threading;
using Item; 

namespace FleaMarket
{
    static class Program
    {
        private static void Main(string[] args)
        {
            //IItem item1 = ItemFactory.GetRandomItem(new Salesman("kjell"), 5);
            // Console.WriteLine(item1.getInformation());
            //Simulation simulation = new Simulation();
           // simulation.Run();
            
            EventTest test = new EventTest();

            test.EventHappening = (sender, eventArgs) => { Console.WriteLine("The counter was above!"); };

            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(100);
                test.Increment();
                Console.WriteLine("Incremented");                
            }
        }
    }

    class EventTest
    {
        private int _counter = 0; 
        /// <summary>
        /// Triggers event when counter > 10
        /// </summary>
        public void Increment()
        {
            if (_counter == 10)
            {
                SomeEvent(EventArgs.Empty);
            }
            else
            {
                _counter++; 
            }
        }
        
        public EventHandler EventHappening; 
        
        protected void SomeEvent(EventArgs e)
        {
            EventHandler handler = EventHappening;
            if (handler != null)
            {
                handler(this, e); 
            }
        }
    }
}