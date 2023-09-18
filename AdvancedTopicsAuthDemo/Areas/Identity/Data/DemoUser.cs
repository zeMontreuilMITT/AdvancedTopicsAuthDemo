using AdvancedTopicsAuthDemo.Models;
using Microsoft.AspNetCore.Identity;

namespace AdvancedTopicsAuthDemo.Areas.Identity.Data
{
    public class DemoUser: IdentityUser
    {
       
        public HashSet<Blog> Blogs { get; set; } = new HashSet<Blog>();

    }
}
