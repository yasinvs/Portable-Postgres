namespace Portable_Postgres.Entities
{
    public class ProcessStart
    {
        public bool HideWindow { get; set; }
        public bool WaitProcess { get; set; }
        public string FileName { get; set; }
        public string FileParameters { get; set; }
    }
}