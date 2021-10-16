using System;
using System.Collections.Generic;

namespace Builder
{
    public class MainCourseBuilder : IMealBUilder
    {
        private Meal _main_course_meal = new Meal();

        public MainCourseBuilder()
        {
            this.Reset();
        }

        public void AddName(string name)
        {
            _main_course_meal.Name = name;
        }

        public Meal Bake()
        {
            _main_course_meal.IsReady = true;
            Console.WriteLine(_main_course_meal);
            return _main_course_meal;
        }
        public void AddMeat()
        {
            _main_course_meal.AddIngredients(new List<string> { " Meat " });
        }
        public void AddBun()
        {
            _main_course_meal.AddIngredients(new List<string> { " Bun " });
        }

        public void Reset()
        {
            _main_course_meal = new Meal();
        }

        public void AddToy()
        {
            _main_course_meal.Surprise = new Toy { Name = "A doll" };
        }
        public void AddGiftCard()
        {
            _main_course_meal.Surprise = new GiftCard { Name = "10 euros gift card" };
        }
    }
}
