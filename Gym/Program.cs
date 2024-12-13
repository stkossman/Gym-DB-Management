using Gym.Core.Context;
using Microsoft.EntityFrameworkCore;

namespace Gym
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
            using (var context = new GymDbContext(new DbContextOptionsBuilder<GymDbContext>()
    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GymDB;Trusted_Connection=True;").Options))
                Application.Run(new LoginForm(context));
        }
    }
}