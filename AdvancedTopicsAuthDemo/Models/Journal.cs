namespace AdvancedTopicsAuthDemo.Models
{
    public class Journal
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public int BlogId { get; set; } 
        public Blog Blog { get; set; }
    }
}
