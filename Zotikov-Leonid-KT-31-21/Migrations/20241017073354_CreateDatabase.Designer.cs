﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Zotikov_Leonid_KT_31_21.Database;

#nullable disable

namespace Zotikov_Leonid_KT_31_21.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20241017073354_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("grade_id")
                        .HasComment("индентификатор записи оценок");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GradeId"));

                    b.Property<int>("Score")
                        .HasMaxLength(100)
                        .HasColumnType("int4")
                        .HasColumnName("c_grade_score")
                        .HasComment("Баллы");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_grade_subject")
                        .HasComment("Название предмета");

                    b.HasKey("GradeId")
                        .HasName("pk_cd_grade_grade_id");

                    b.HasIndex(new[] { "StudentId" }, "idx_cd_grade_fk_f_group_id");

                    b.ToTable("cd_grade", (string)null);
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("group_id")
                        .HasComment("Идентификатор записи группы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GroupId"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_group_name")
                        .HasComment("Название группы");

                    b.HasKey("GroupId")
                        .HasName("pk_cd_group_group_id");

                    b.ToTable("cd_group", (string)null);
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("student_id")
                        .HasComment("Идентификатор записи студента");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_firstname")
                        .HasComment("Имя студента");

                    b.Property<int>("GroupId")
                        .HasColumnType("int4")
                        .HasColumnName("f_group_id")
                        .HasComment("Идентификатор группы");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_lastname")
                        .HasComment("Фамилия студента");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_middlename")
                        .HasComment("Отчество студента");

                    b.HasKey("StudentId")
                        .HasName("pk_cd_student_student_id");

                    b.HasIndex(new[] { "GroupId" }, "idx_cd_student_fk_f_group_id");

                    b.ToTable("cd_student", (string)null);
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("subject_id")
                        .HasComment("Идентификатор предмета");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SubjectId"));

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_subject_name")
                        .HasComment("Название предмета");

                    b.HasKey("SubjectId")
                        .HasName("pk_cd_subject_subject_id");

                    b.HasIndex(new[] { "StudentId" }, "idx_cd_subject_fk_f_group_id");

                    b.ToTable("cd_subject", (string)null);
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Zachet", b =>
                {
                    b.Property<int>("ZachetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("zachet_id")
                        .HasComment("Идентификатор зачета");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ZachetId"));

                    b.Property<string>("NameTeacher")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_name_teacher")
                        .HasComment("Имя преподавателя");

                    b.Property<string>("StudentCard")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_card")
                        .HasComment("Зачетная книжка");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_zachet_subject")
                        .HasComment("Зачетная книжка");

                    b.HasKey("ZachetId")
                        .HasName("pk_cd_zachet_zachet_id");

                    b.HasIndex("StudentId");

                    b.ToTable("cd_zachet", (string)null);
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Grade", b =>
                {
                    b.HasOne("Zotikov_Leonid_KT_31_21.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_student_id");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Student", b =>
                {
                    b.HasOne("Zotikov_Leonid_KT_31_21.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_group_id");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Subject", b =>
                {
                    b.HasOne("Zotikov_Leonid_KT_31_21.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_student_id");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Zotikov_Leonid_KT_31_21.Models.Zachet", b =>
                {
                    b.HasOne("Zotikov_Leonid_KT_31_21.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");
                });
#pragma warning restore 612, 618
        }
    }
}
