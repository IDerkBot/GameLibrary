using System.Collections.Generic;

namespace GameLibrary.Models.Entity;

public class Platform
{
    public int Id { get; set; }
    public string Title { get; set; }

    public List<App> Apps { get; set; }
}