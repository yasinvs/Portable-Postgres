namespace Portable_Postgres.Entities;
public class Root
{
    public string[] DownloadLinks { get; set; }
    public DbSettings DbSettings { get; set; }
    public ApplicationSettings ApplicationSettings { get; set; }
}
