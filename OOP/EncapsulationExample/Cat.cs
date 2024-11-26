using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    /// <summary>
    /// Кот
    /// </summary>
    class Cat
    {
        private string name;

        /// <summary>
        /// Кличка кота
        /// </summary>
        public string Name
        {
            get { return this.name; }
        }

        public Cat(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Накормить кота
        /// </summary>
        /// <param name="food">Еда</param>
        public void Feed(Food food)
        {
            bool isGoodFoodForMe = this.DigestFood(food);
            if(!isGoodFoodForMe)
                Console.WriteLine("Я поражен!");
            else 
                Console.WriteLine($"Я съев {food.GetFoodName()}");
        }

        /// <summary>
        /// Накормить кота
        /// </summary>
        /// <param name="food">Тип еды</param>
        /// <returns>Пригодная ли еда для кота</returns>
        private bool DigestFood(Food food)
        {
            switch(food.GetFoodName()) 
            {
                case "Milk":
                case "Meat":
                case "Fish":
                    return true;
                default:
                    return false;
            }
        }
    }
}
