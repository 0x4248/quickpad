/* Quickpad
 * A simple text editor for editing text quickly.
 * Github: https://github.com/0x4248/quickpad
 * Licence: GNU General Public License v3.0
 * By: 0x4248
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