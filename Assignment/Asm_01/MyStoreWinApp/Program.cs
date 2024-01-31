namespace MyStoreWinApp
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}