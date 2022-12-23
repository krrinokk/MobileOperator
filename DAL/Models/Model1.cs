using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Dogovor> Dogovor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Тариф> Тариф { get; set; }
        public virtual DbSet<Тип_звонка> Тип_звонка { get; set; }
        public virtual DbSet<Тип_тарифа> Тип_тарифа { get; set; }
        public virtual DbSet<Call> Call { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dogovor>()
              .HasMany(e => e.Call)
                .WithRequired(e => e.Dogovor)
                .HasForeignKey(e => e.Номер_договора_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Клиент>()
                .Property(e => e.ФИО)
                .IsUnicode(false);

            modelBuilder.Entity<Клиент>()
                .Property(e => e.Баланс)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Клиент>()
               .HasMany(e => e.Dogovor)
                .WithRequired(e => e.Клиент)
                .HasForeignKey(e => e.Номер_клиента_FK)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Тариф>()
                .Property(e => e.Минута_межгород_стоимость)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Тариф>()
                .Property(e => e.Минута_международная_стоимость)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Тариф>()
                .Property(e => e.Название_тарифа)
                .IsUnicode(false);

            modelBuilder.Entity<Тариф>()
                .Property(e => e.Стоимость_перехода)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Тариф>()
               .HasMany(e => e.Dogovor)
                .WithRequired(e => e.Тариф)
              .HasForeignKey(e => e.Код_тарифа_FK)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Тип_звонка>()
                .Property(e => e.Название_типа_звонка)
                .IsUnicode(false);

            modelBuilder.Entity<Тип_звонка>()
                .HasMany(e => e.Call)
                .WithRequired(e => e.Тип_звонка)
                .HasForeignKey(e => e.Код_типа_звонка_FK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Тип_тарифа>()
                .Property(e => e.Название_типа_тарифа)
                .IsUnicode(false);

    modelBuilder.Entity<Тип_тарифа>()
             .HasMany(e => e.Тариф)
               .WithRequired(e => e.Тип_тарифа)
                .HasForeignKey(e => e.Код_типа_тарифа_FK)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Call>()
                .Property(e => e.Стоимость)
                .HasPrecision(19, 4);
        }
    }
}
