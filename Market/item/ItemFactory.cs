using System;
using System.Collections.Generic;
using FleaMarket; 

namespace Item
{
    public static class ItemFactory
    {
        
        public enum Decoration
        {    
            NoDecoration,
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

        
        
        /*public void getNew(string name, double price, Person person)
        {
            IItem item  = new ConcreteItem(name, price, person);
            
            
        }*/

        public static IItem getItem(List<Decoration> decorations, Person person)
        {    
            IItem item = new ConcreteItem("Item x", 200 ,person);
            foreach(Decoration dec in decorations)
            {
                Console.WriteLine(dec);
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


        public static IItem getRandomItem(Person person, int numberOfDecorations)
        {
            List<Decoration> decorations = getRandomDecorations(numberOfDecorations);

            return getItem(decorations, person);
        }

        private static List<Decoration> getRandomDecorations(int numberOfItems)
        {    
            
            Random random = new Random();
            List<Decoration> decorations = new List<Decoration>();
            Array values = Enum.GetValues(typeof(Decoration));

            for (var i = 1; i < values.Length; i += 3)
            {
                var r = random.Next(0, 3) + i;
                decorations.Add((Decoration) values.GetValue(r));
            }
           
            /*Array values = Enum.GetValues(typeof(Decoration));
            Decoration[] decorations = new Decoration[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                decorations[i] = (Decoration) values.GetValue(random.Next(values.Length));
            }*/

            return decorations;
        }
    }
}