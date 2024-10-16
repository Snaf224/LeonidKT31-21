using Zotikov_Leonid_KT_31_21.Database.Helpers;
using Zotikov_Leonid_KT_31_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Zotikov_Leonid_KT_31_21.Database.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "cd_subject";

        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            //Задаем первичный ключ
            builder
                .HasKey(p => p.SubjectId)
                .HasName($"pk_{TableName}_subject_id");

            //Для целочисленного первичного ключа задаем автогенерацию (к каждой новой записи будет добавлять +1)
            builder.Property(p => p.SubjectId)
                    .ValueGeneratedOnAdd();

            //Расписываем как будут называться колонки в БД, а так же их обязательность и тд
            builder.Property(p => p.SubjectId)
                .HasColumnName("subject_id")
                .HasComment("Идентификатор предмета");

            //HasComment добавит комментарий, который будет отображаться в СУБД (добавлять по желанию)
            builder.Property(p => p.SubjectName)
                .IsRequired()
                .HasColumnName("c_subject_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название предмета");


            //связь со студентами
            builder.ToTable(TableName)
            .HasOne(p => p.Student)
            .WithMany()
            .HasForeignKey(p => p.StudentId)
            .HasConstraintName("fk_f_student_id")
            .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
                .HasIndex(p => p.StudentId, $"idx_{TableName}_fk_f_group_id");

            //Добавим явную автоподгрузку связанной сущности
            builder.Navigation(p => p.Student)
                .AutoInclude();

            builder.ToTable(TableName);
        }
    }
}
