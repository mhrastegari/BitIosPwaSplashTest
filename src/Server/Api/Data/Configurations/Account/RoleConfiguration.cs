using BitIosPwaSplashTest.Server.Api.Models.Account;

namespace BitIosPwaSplashTest.Server.Api.Data.Configurations.Account;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(role => role.Name).HasMaxLength(50);
    }
}

