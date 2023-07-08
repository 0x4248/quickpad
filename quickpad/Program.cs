/* Quickpad
 * A simple text editor for editing text quickly.
 * Github: https://github.com/lewisevans2007/quickpad
 * Licence: GNU General Public License v3.0
 * By: Lewis Evans
 */

namespace quickpad
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
            Application.Run(new main());
        }
    }
}