using System.Collections.Generic;

namespace GameLibrary.Models.Entity;

public class App
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public byte[] Image { get; set; }

    public int TypeId { get; set; }
    public TypeApp Type { get; set; }
    public List<Platform> Platforms { get; set; }
}