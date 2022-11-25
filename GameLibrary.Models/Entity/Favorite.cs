﻿namespace GameLibrary.Models.Entity;

public class Favorite
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int AppId { get; set; }

    public User User { get; set; }
    public App App { get; set; }
}