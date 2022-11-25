using GameLibrary.DataAccessLayer;

namespace GameLibrary;

public static class Global
{
    public static ApplicationDbContext? Database { get; set; }
    public static int Access { get; set; }
}