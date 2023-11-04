using Coblis_TudorCristian_Lab2.Models;

namespace Coblis_TudorCristian_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
