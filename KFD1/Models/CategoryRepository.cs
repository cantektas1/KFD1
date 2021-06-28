using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFD1.Models
{
    public class CategoryRepository
    {
        private static List<Category> categories = null;
        static CategoryRepository()
        {
            categories = new List<Category>()
            {
              new Category(){ Id=1,Name="Dram"},
              new Category(){ Id=2,Name="Aksiyon"},
              new Category(){ Id=3,Name="Macera"},
              new Category(){ Id=4,Name="Bilim Kurgu"},
              new Category(){ Id=5,Name="Suç"},
              
            };
        }

        public static List<Category> Categories
        {
            get { return categories; }
        }
        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }
        public static Category GetById(int id)
        {
            return categories.FirstOrDefault(i => i.Id == id);
        }
    }
}
