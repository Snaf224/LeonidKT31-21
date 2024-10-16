using Zotikov_Leonid_KT_31_21.Database.Configurations;
using Zotikov_Leonid_KT_31_21.Models;
using Microsoft.EntityFrameworkCore;
using IvanIvanovKt_31_20.Database.Configurations;


namespace Zotikov_Leonid_KT_31_21.Database
{
    public class StudentDbContext : DbContext
    {
        //Добавляем таблицы
        DbSet<Student> Students { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<Zachet> Zachets { get; set; }
        DbSet<Grade> Grades { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new ZachetConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
           
        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
    }
}
