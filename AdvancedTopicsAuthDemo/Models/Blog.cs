using AdvancedTopicsAuthDemo.Areas.Identity.Data;

namespace AdvancedTopicsAuthDemo.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DemoUser User { get; set; }
        public HashSet<Journal> Journals { get; set; } = new HashSet<Journal>();
    }
}
