class Program
{
    private static void Main(string[] args)
    {
        try
        {
            DirectoryInfo necessaryDelete = new DirectoryInfo("C:\\Users\\user\\Desktop\\FoldersForDelete");
            string folder = "C:\\Users\\user\\Desktop\\FoldersForDelete";

            Console.WriteLine(TimeSpan.FromMinutes(30));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}