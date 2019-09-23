using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace tibber.robo.sanitycoveragelogger.DTO
{
    public class ExectuionsMap
    {
        public ExectuionsMap(EntityTypeBuilder<Executions> entityBuilder)
        {
            entityBuilder.HasKey(x => x.id);
            entityBuilder.ToTable("executions");

            entityBuilder.Property(x => x.id).HasColumnName("id");
            entityBuilder.Property(x => x.timestamp).HasColumnName("timestamp");
            entityBuilder.Property(x => x.commmands).HasColumnName("commmands");
            entityBuilder.Property(x => x.result).HasColumnName("result");
            entityBuilder.Property(x => x.duration).HasColumnName("duration");

        }
    }
}
