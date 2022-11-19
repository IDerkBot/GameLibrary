namespace GameLibrary.Models.Entity;

public class Profile
{
    public int UserId { get; set; }
    public string Nickname { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public byte[] Image { get; set; }
}