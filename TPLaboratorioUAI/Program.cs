namespace TPLaboratorioUAI
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
//<<<<<<< HEAD
            Application.Run(new frmPrincipal()); 
//=======
  //          Application.Run(new FormMDI()); //HOLA
//>>>>>>> 5b6f8e6ed8d7c65a5d8c4b35471829b06baf7729
        }
    }
}