namespace EncapsulationExample
{
    /// <summary>
    /// Пища
    /// </summary>
    public class Food
    {
        private string food;
        
        public Food(string a) 
        {
            this.food = a;
        }

        /// <summary>
        /// Наименование пищи
        /// </summary>
        /// <returns>Возращает наименование пищи</returns>
        public string GetFoodName()
        { return food; }
    }
}