namespace UML.Ingredients
{
    /// <summary>
    /// Ингридиент
    /// </summary>
    internal interface IIngredient
    {
        /// <summary>
        /// Овощ
        /// </summary>
        /// <returns>Является ли продукт овощем</returns>
        public bool GetIsVegetable();
    }
}