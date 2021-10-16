using System.Collections.Generic;

namespace Builder
{
    //TODO: Napraviti da je IMeal interfejs i onda imam deser i glavno jelo konkretne klase.
    //Vracat onda interfejs u builderu?

    public class Meal
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public ISurprise Surprise { get; set; }
        public bool IsReady { get; set; } = false;
        public Meal()
        {
            Ingredients = new List<string>();
        }
        public void AddIngredients(ICollection<string> ingredients)
        {
            Ingredients.AddRange(ingredients);
        }
        public override string ToString()
        {
            var ingredients_info = "";
            Ingredients.ForEach(x => { ingredients_info += x; });
            return $"Meal: {Name}, Ingredients: {ingredients_info}, Done: {IsReady} , Surprise: {Surprise.GetName()}";
        }

    }
}
