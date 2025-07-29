using DevBoard.Domain.Boards.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevBoard.Infrastructure.Data.Configurations
{
    public class BoardConfiguration : IEntityTypeConfiguration<BoardEnt>
    {
        public void Configure(EntityTypeBuilder<BoardEnt> builder)
        {
            builder.ToTable("Board");
            builder.HasKey(t => t.Id);

            builder
                .HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserId);
        }
    }
}
