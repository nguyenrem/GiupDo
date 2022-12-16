using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace remproject.IdentitySettings
{
    public class IdentitySettingConfiguration : IEntityTypeConfiguration<IdentitySetting>
    {
        public void Configure(EntityTypeBuilder<IdentitySetting> builder)
        {
            builder.ToTable(remprojectConsts.DbTablePrefix + "IdentitySettings",
                    remprojectConsts.DbSchema);
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Name).IsRequired().HasMaxLength(200);

        }
    }
}
