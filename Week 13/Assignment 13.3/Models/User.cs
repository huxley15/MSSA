using Microsoft.AspNetCore.Identity;

namespace Assignment12._1.Models
{
    //step 3.6
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
