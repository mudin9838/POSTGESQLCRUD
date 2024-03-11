using Microsoft.AspNetCore.Identity;

namespace POSTGESQLCRUD.DAL.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int UsernameChangeLimit { get; set; } = 3;
    public byte[]? ProfilePicture { get; set; }



}
