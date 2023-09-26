using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Persistence.Configurations;

public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
{
    public void Configure(EntityTypeBuilder<LeaveType> builder)
    {
        builder.HasData(
            new LeaveType
            {
                Id = 1,
                Name = "Test",
                DefaultDays = 10,
                DateCreated = DateTime.Now,
            }
        );

        builder.Property(q => q.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}