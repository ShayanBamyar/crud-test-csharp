using Mc2.CrudTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mc2.CrudTest.Persistence.EntityTypeConfiguration
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.ToTable("Customer").HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasColumnType("nvarchar(150)").IsRequired();
            builder.Property(x => x.LastName).HasColumnType("nvarchar(150)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.DateOfBirth).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnType("varchar(13)").IsRequired();
            builder.Property(x => x.BankAccountNumber).HasColumnType("varchar(16)").IsRequired();
            builder.HasIndex(p => new { p.FirstName, p.LastName,p.DateOfBirth }).IsUnique();


        }
    }
}