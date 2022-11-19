namespace GameLibrary.Models.Entity;

public class App
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Platform[] Platforms { get; set; }
    public string Link { get; set; }
    public byte[] Image { get; set; }
}