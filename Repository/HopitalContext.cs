using Microsoft.EntityFrameworkCore;
using patient.Entities;
using patient.Repository.Configurations;

namespace patient.Repository {
    public class HopitalContext(DbContextOptions<HopitalContext> options) : DbContext(options) {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PatientConfiguration());
        }
    }
}
