using System;
using System.Collections.Generic;
using FleaMarket; 

namespace Item
{
    public static class ItemFactory
    {
        
        
        /// <summary>
        /// Manufactures and returns a new item
        /// with random decorations 
        /// </summary>
        /// <param name="decorations">The owner of the item</param>
        /// <param name="person">The owner of the item</param>
        /// <returns></returns>
        public static IItem GetRandomItem(Person person, int numberOfDecorations)
        {
            var decorations = GetRandomDecorations(numberOfDecorations);

            return GetItem(decorations, person);
        }

        #region applying decorations 
        /// <summary>
        /// Manufactures and returns a new item 
        /// </summary>
        /// <param name="decorations">The decorations to apply</param>
        /// <param name="person">The owner of the item</param>
        /// <returns></returns>
        private static IItem GetItem(List<Decoration> decorations, Person person)
        {   
            IItem item = new ConcreteItem("Item x", 200 ,person); //FIXME: semi-random name and price 
            foreach(Decoration dec in decorations)
            {
                switch (dec)
                {
                    case Decoration.TerribleCondition:
                        item = new TerribleConditionItemDecorator(item);
                        break;
                    case Decoration.PerfectCondition:
                        item = new PerfectConditionItemDecorator(item);
                        break;
                    case Decoration.DecentCondition:
                        item = new DecentConditionItemDecorator(item);
                        break;
                    case Decoration.WithWheels:
                        item = new WithWheelsItemDecorator(item);
                        break;
                    case Decoration.WithWings:
                        item = new WithWingsItemDecorator(item);
                        break;
                    case Decoration.WithTrumpStickers:
                        item = new WithTrumpStickersItemDecorator(item);
                        break;
                    case Decoration.MultipleDamage:
                        item = new MultipleDamageItemDecorator(item);
                        break;
                    case Decoration.NoDamage:
                        item = new NoDamageItemDecorator(item);
                        break;
                    case Decoration.ModerateDamage:
                        item = new ModerateDamageItemDecorator(item);
                        break;
                    case Decoration.NoDecoration:
                        break;       
                }
            }

            return item;
        }

        /// <summary>
        /// Uses the "decorator-pattern"-structure
        /// to apply different variations (decorations)
        /// on the item. 
        /// </summary>
        /// <param name="numberOfItems">Amount of decorations</param>
        /// <returns>A decorated item</returns>
        private static List<Decoration> GetRandomDecorations(int numberOfItems)
        {    
            
            var random = new Random();
            var decorations = new List<Decoration>();
            var values = Enum.GetValues(typeof(Decoration));

            for (var i = 1; i < values.Length; i += 3)
            {
                var r = random.Next(0, 3) + i;
                decorations.Add((Decoration) values.GetValue(r));
            }

            return decorations;
        }
        #endregion
    }
}