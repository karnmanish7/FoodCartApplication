using FoodCart.Service.Exceptions;
using FoodCart.Service.Models;
using FoodCart.Service.Repositories;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    [TestFixture]
    public class FoodRepositoryTest
    {
        readonly List<FoodCategory> categories;
        readonly List<FoodItem> foodItems;

        readonly FoodCartRepository repository;

        public FoodRepositoryTest()
        {
            repository = new FoodCartRepository();

            categories = new List<FoodCategory>
            {
                new FoodCategory
                {
                    CategoryId = 1001,
                    Category = "Vegetarian",
                    SubCategory = "Starters",
                    Cuisine = "Indian"
                },
                new FoodCategory
                {
                    CategoryId = 1002,
                    Category = "Vegetarian",
                    SubCategory = "Soups",
                    Cuisine = "Indian"
                },
                new FoodCategory
                {
                    CategoryId = 1003,
                    Category = "Vegetarian",
                    SubCategory = "Main Course",
                    Cuisine = "Indian"

                }
            };

            foodItems = new List<FoodItem>
            {
                new FoodItem
                {
                    CategoryId = 1001,
                    ItemName = "Grilled Paneer",
                    Price = 150
                },
                new FoodItem
                {
                    CategoryId = 1002,
                    ItemName = "Cream of Tomato",
                    Price = 250
                },
                new FoodItem
                {
                    CategoryId = 1003,
                    ItemName = "Paneer Kadhai",
                    Price = 350
                },
                new FoodItem
                {
                    CategoryId = 1001,
                    ItemName = "Aloo Chaat",
                    Price = 120
                },
                new FoodItem
                {
                    CategoryId = 1002,
                    ItemName = "Veg Clear",
                    Price = 220
                },
                new FoodItem
                {
                    CategoryId = 1003,
                    ItemName = "Kaju Paneer",
                    Price = 450
                }
            };
        }

        [TestCase(1003)]
        public void ShouldGetCategoriesByCategoryId(int categoryId)
        {
            //var query = from category in categories where category.CategoryId == 1003 select category;
            var categoryResultSet = repository.GetCategoriesById(categories, categoryId);

            Assert.That(categoryResultSet.Count, Is.EqualTo(1));
            Assert.That(categoryResultSet[0].Category, Is.EqualTo("Vegetarian"));
            Assert.That(categoryResultSet[0].SubCategory, Is.EqualTo("Main Course"));
            Assert.That(categoryResultSet[0].Cuisine, Is.EqualTo("Indian"));
        }

        [TestCase("Indian")]
        public void ShouldGetCategoriesByCuisine(string cuisine)
        {
            //var query = from category in categories where category.Cuisine.Equals(cuisine) select category;
            var categoryResultSet = repository.GetCategoriesByCuisine(categories, cuisine);

            Assert.That(categoryResultSet.Count, Is.EqualTo(3));
            Assert.That(categoryResultSet[1].Category, Is.EqualTo("Vegetarian"));
            Assert.That(categoryResultSet[1].SubCategory, Is.EqualTo("Soups"));
            Assert.That(categoryResultSet[1].Cuisine, Is.EqualTo("Indian"));

        }

        [TestCase(1002)]
        public void ShouldGetFoodItemsByCategory(int categoryId)
        {
            //var query = from foodItem in foodItems where foodItem.CategoryId == categoryId select foodItem;
            var foodItemResultSet = repository.GetFoodItemsByCategory(foodItems, categoryId);

            Assert.That(foodItemResultSet.Count, Is.EqualTo(2));
            Assert.That(foodItemResultSet[1].ItemName, Is.EqualTo("Veg Clear"));
            Assert.That(foodItemResultSet[1].Price, Is.EqualTo(220));
        }

        [TestCase(1002)]
        public void ShouldGetFoodItemsByCategoryOrderedByPrice(int categoryId)
        {
            //var query = from foodDish in foodItems where foodDish.CategoryId == 1002 orderby foodDish.Price select foodDish;
            var foodItemResultSet = repository.GetFoodItemsByCategoryOrderedByPrice(foodItems, categoryId);

            Assert.That(foodItemResultSet.Count, Is.EqualTo(2));
            Assert.That(foodItemResultSet[1].ItemName, Is.EqualTo("Cream of Tomato"));
            Assert.That(foodItemResultSet[1].Price, Is.EqualTo(250));
        }

        [Test]
        public void ShouldGetFoodItemsGroupedByCategory()
        {
            //var query = from FoodItem item in foodItems group item by item.CategoryId into itemList select itemList;
            var groupResultSet = repository.GetFoodItemsGroupedByCategory(foodItems);

            Assert.That(groupResultSet.Keys.Count, Is.EqualTo(3));

            groupResultSet.TryGetValue(groupResultSet.Keys.ElementAt(0), out List<FoodItem> items);
            Assert.That(items[1].ItemName, Is.EqualTo("Aloo Chaat"));
            Assert.That(items[1].Price, Is.EqualTo(120));
        }

        [TestCase("Paneer")]
        public void ShouldGetPaneerItemsGroupedByCategory(string choice)
        {
            //var query = from FoodItem item in foodItems where item.ItemName.Contains("Paneer") group item by item.CategoryId into itemList select itemList;
            var groupResultSet = repository.GetSpecifiedItemsGroupedByCategory(foodItems, choice);

            Assert.That(groupResultSet.Keys.Count, Is.EqualTo(2));

            groupResultSet.TryGetValue(groupResultSet.Keys.ElementAt(1), out List<FoodItem> items);
            Assert.That(items[1].ItemName, Is.EqualTo("Kaju Paneer"));
            Assert.That(items[1].Price, Is.EqualTo(450));
        }

        [TestCase(1005)]
        public void ShouldGetCategoriesByCategoryIdThrowExceptions(int categoryId)
        {
            Assert.That(() => repository.GetCategoriesById(categories, categoryId),
                Throws.TypeOf<CategoryNotFoundException>()
                .And
                .Message.Contains("No Category Found with this Category Id !!!"));

        }

        [TestCase("Italian")]
        public void ShouldGetCategoriesByCuisineThrowException(string cuisine)
        {
            Assert.That(() => repository.GetCategoriesByCuisine(categories, cuisine),
                Throws.TypeOf<CategoryNotFoundException>()
                .And
                .Message.Contains("No Category Found in this Cuisine !!!"));
        }

        [TestCase(1004)]
        public void ShouldGetFoodItemsByCategoryThrowException(int categoryId)
        {
            Assert.That(() => repository.GetFoodItemsByCategory(foodItems, categoryId),
                Throws.TypeOf<FoodItemsNotFoundException>()
                .And
                .Message.Contains("No FoodItem Found in this Category !!!"));

        }

    }
}
