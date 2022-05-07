namespace EntityFramework.Entities
{
    public class Book
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int BookKey { get; set; }

        public string Name { get; set; }
    }
}
