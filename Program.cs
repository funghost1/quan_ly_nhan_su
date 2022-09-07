namespace quanly
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new luong());
            
        }
    }
}
//Scaffold-DbContext "Data Source = DESKTOP-DOAE4G1\DANG;Initial Catalog=quanlyquan;User ID=sa;Password=Dangnguyen1" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models