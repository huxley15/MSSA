//step 7.6
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assignment12._1.Models
{
    //step 5.6
    public class UserContext : IdentityDbContext<User> //step 7.6 cont
    {
        //step 8.6
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
    }
}
