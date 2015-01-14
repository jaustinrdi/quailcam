using System.Data.Entity;
using QuailCam.Models;

namespace QuailCam.DAL
{
    public class QuailCamDbContext : DbContext
    {
        public DbSet<Reading> Readings { get; set; }
    }
}