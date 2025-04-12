using Models;

namespace E_commerce_ITI___UI.ViewModels
{
    public class CategoryDetails
    {
        public string CategoryName { get; set; }
        public string CategoryDescripition { get; set; }
        public string CategoryThumbnail { get; set; }
        public List<Product>  Products { get; set; }


    }
}
