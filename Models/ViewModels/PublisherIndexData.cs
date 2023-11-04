using Coblis_TudorCristian_Lab2.Models;

namespace Coblis_TudorCristian_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
