using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Doughs;
using UML.Ingredients;
using UML.Sauces;

namespace UML
{
    /// <summary>
    /// Пицца
    /// </summary>
    internal class Pizza
    {
        public IDough Dough { get; set; }

        public List<IIngredient> Ingredient { get; set; }

        public ISauce Sauce { get; set; }
    }
}
