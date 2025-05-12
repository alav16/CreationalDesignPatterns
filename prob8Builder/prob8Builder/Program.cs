/*
Develop a meal ordering system where a Meal consists of several optional parts:
drink, main course, dessert, and side dish.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob8Builder
{
    public class Meal
    {
        public string Drink { get; set; }

        public string MainCourse { get; set; }
        public string Dessert { get; set; }
        public string SideDish { get; set; }

        public void Show()
        {
            if (Drink != null) Console.WriteLine(Drink);
            if (MainCourse != null) Console.WriteLine(MainCourse);
            if (Dessert != null) Console.WriteLine(Dessert);
            if (SideDish != null) Console.WriteLine(SideDish);
        }
    }

    public class MealBuilder
    {
        private Meal _meal = new Meal();

        public MealBuilder AddDrink(string drink)
        {
            _meal.Drink = drink;
            return this;
        }

        public MealBuilder AddMainCourse(string mainCourse)
        {
            _meal.MainCourse = mainCourse;
            return this;
        }

        public MealBuilder AddDessert(string dessert)
        {
            _meal.Dessert = dessert;
            return this;
        }

        public MealBuilder AddSideDish(string sideDish)
        {
            _meal.SideDish = sideDish;
            return this;
        }

        public Meal Build()
        {
            return _meal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var meal = new MealBuilder()
                       .AddDrink("Cola")
                       .AddDessert("cake")
                       .AddSideDish("free")
                       .AddMainCourse("Fish")
                       .Build();

            meal.Show();

            var coffee = new MealBuilder()
                .AddDrink("Coffee")
                .AddDessert("shock")
                .Build();

            coffee.Show();
        }
    }
}
