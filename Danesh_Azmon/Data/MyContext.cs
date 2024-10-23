using Danesh_Azmon.Models;
using Microsoft.EntityFrameworkCore;

namespace Danesh_Azmon.Data
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<tbl_class> tbl_class { get; set; }
        public DbSet<tbl_exam> tbl_exam { get; set; }
        public DbSet<tbl_examClass> tbl_ExamClasses { get; set; }
        public DbSet<tbl_question> tbl_question { get; set; }
        public DbSet<tbl_studentClass> tbl_StudentClasses { get; set; }
        public DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تنظیم ارتباط چند-به-چند بین Students و Classes
            modelBuilder.Entity<tbl_studentClass>()
                .HasKey(sc => new { sc.StudentId, sc.ClassId });

            modelBuilder.Entity<tbl_studentClass>()
                .HasOne(sc => sc.Student)
                .WithMany(u => u.StudentClasses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<tbl_studentClass>()
                .HasOne(sc => sc.Class)
                .WithMany(c => c.StudentClasses)
                .HasForeignKey(sc => sc.ClassId);

            // تنظیم ارتباط چند-به-چند بین Exams و Classes
            modelBuilder.Entity<tbl_examClass>()
                .HasKey(ec => new { ec.ExamId, ec.ClassId });

            modelBuilder.Entity<tbl_examClass>()
                .HasOne(ec => ec.Exam)
                .WithMany(e => e.ExamClasses)
                .HasForeignKey(ec => ec.ExamId);

            modelBuilder.Entity<tbl_examClass>()
                .HasOne(ec => ec.Class)
                .WithMany(c => c.ExamClasses)
                .HasForeignKey(ec => ec.ClassId);

            // تنظیم ارتباط یک‌-به-چند بین Exam و Question
            modelBuilder.Entity<tbl_examClass>()
                .HasOne(q => q.Exam)
                .WithMany(e => e.ExamClasses)
                .HasForeignKey(q => q.ExamId);
        }
    }
}
