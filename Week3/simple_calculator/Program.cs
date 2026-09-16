using System.Globalization;

namespace CalculatorApp;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Set InvariantCulture to ensure decimal dot (.) parsing behaves consistently across locales
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}
