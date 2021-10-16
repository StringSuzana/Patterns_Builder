namespace Builder
{
    /**
     * Unlike other creational patterns, Builder doesn’t require products to have a common interface. 
     * That makes it possible to produce different products using the same construction process.
     * 
     * The Builder pattern is a well-known pattern in C# world. 
     * It’s especially useful when you need to create an object 
     * with lots of possible configuration options.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director { Builder = new MainCourseBuilder() };
            var kids_meal = d.MakeKidsMeal("Burger");
            var adults_meal = d.MakeAdultsMeal("Burger");
        
        }
    }
}
