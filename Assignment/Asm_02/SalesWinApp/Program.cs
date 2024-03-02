namespace SalesWinApp
{
     // dotnet-ef dbcontext scaffold "Server=DESKTOP-ACECPNJ;uid=sa;pwd=sa;database=PRN211_ASM_02;trustservercertificate=true" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}