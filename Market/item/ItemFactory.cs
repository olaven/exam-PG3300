using System;
using System.Collections;
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
        /// <param name="person">The owner of the item</param>
        /// <returns></returns>
        public static IItem GetRandomItem(Salesman person)
        {
            var decorations = GetRandomDecorations();

            return GetItem(decorations, person);
        }

        #region applying decorations 
        /// <summary>
        /// Manufactures and returns a new item
        /// with decorations
        /// </summary>
        /// <param name="decorations">The decorations to apply</param>
        /// <param name="person">The owner of the item</param>
        /// <returns></returns>
        private static IItem GetItem(IEnumerable<Decoration> decorations, Salesman person)
        {   
            IItem item = new ConcreteItem(200 ,person); //FIXME: semi-random name and price 
            foreach(var dec in decorations)
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
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return item;
        }

        /// <summary>
        /// Gets a list of decorations, chosen at random 
        /// on the item. 
        /// </summary>
        /// <returns>A list of decorations</returns>
        private static IEnumerable<Decoration> GetRandomDecorations()
        {    

            var conditions = new List<Decoration>
            {
                Decoration.DecentCondition, Decoration.TerribleCondition, 
                Decoration.PerfectCondition, Decoration.NoDecoration
            };

            var damageLevels = new List<Decoration>
            {
                Decoration.NoDamage, Decoration.MultipleDamage,
                Decoration.ModerateDamage, Decoration.NoDecoration
            };

            var modifications = new List<Decoration>
            {
                Decoration.WithWheels, Decoration.WithWings,
                Decoration.WithTrumpStickers, Decoration.NoDecoration
            }; 
            
            var decorations = new List<Decoration>();
            var random = new Random();


            var index = random.Next(conditions.Count);
            decorations.Add(conditions[index]);
            
            index = random.Next(damageLevels.Count);
            decorations.Add(damageLevels[index]);
            
            index = random.Next(modifications.Count);
            decorations.Add(modifications[index]);

            return decorations; 
        }
        #endregion
    }
}