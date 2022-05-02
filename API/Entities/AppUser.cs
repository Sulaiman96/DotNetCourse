namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }

    //The N being capital in the name below is for something we will use later that uses that naming convention
    public string UserName { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }
}