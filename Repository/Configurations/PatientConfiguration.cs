using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using patient.Entities;

namespace patient.Repository.Configurations {
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("patient");

            builder.Property(e => e.Nom).HasColumnName("nom").IsRequired();
            builder.Property(e => e.Prenom).HasColumnName("prenom").IsRequired();
            builder.Property(e => e.DateNaissance).HasColumnName("date_naissance").IsRequired();
        }
    }
}
