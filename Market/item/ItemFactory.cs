using System;
using FleaMarket; 

namespace Item
{
    public static class ItemFactory
    {
        
        #region getting a random-decorated item 
        public static IItem GetRandomItem(Person person, int numberOfDecorations)
        {
            Decoration[] decorations = GetRandomDecorations(numberOfDecorations);

            return GetItem(decorations, person);
        }
        
        private static IItem GetItem(Decoration[] decorations, Person person)
        {    
            IItem item = new ConcreteItem("Item x", 200 , person);
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
                        item = new DecentConditionItemDecorator(item);
                        break;
                }
                
            }


            return item;
        }

        private static Decoration[] GetRandomDecorations(int numberOfItems)
        {    
            
            Random random = new Random();
            
            Array values = Enum.GetValues(typeof(Decoration));
            Decoration[] decorations = new Decoration[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                decorations[i] = (Decoration) values.GetValue(random.Next(values.Length));
            }

            return decorations;
        }
        #endregion
    }
    
    public enum Decoration
    {
        ModerateDamage,
        MultipleDamage,
        NoDamage,
        DecentCondition,
        PerfectCondition,
        TerribleCondition,
        WithTrumpStickers,
        WithWheels,
        WithWings
    }
}