using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EasyAppointment.Services.Database
{
    public partial class _170148Context : DbContext
    {
        public _170148Context()
        {
        }

        public _170148Context(DbContextOptions<_170148Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<BussinesType> BussinesTypes { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<RateUser> RateUsers { get; set; } = null!;
        public virtual DbSet<ReportedUser> ReportedUsers { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<Sex> Sexes { get; set; } = null!;
        public virtual DbSet<Subscription> Subscriptions { get; set; } = null!;
        public virtual DbSet<UserMessage> UserMessages { get; set; } = null!;
        public virtual DbSet<UserRoleId> UserRoleIds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost, 1434;Initial Catalog=170148; user=sa; Password=QWEasd123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("AppUser");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_Id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BussinesTypeId).HasColumnName("Bussines_Type_Id");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordSalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.RateId).HasColumnName("Rate_Id");

                entity.Property(e => e.SexId).HasColumnName("Sex_Id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRole_Id");

                entity.HasOne(d => d.BussinesType)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.BussinesTypeId)
                    .HasConstraintName("FK_BussinesType_AppUser");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_City_AppUser");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Country_AppUser");

                entity.HasOne(d => d.Rate)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.RateId)
                    .HasConstraintName("FK_Rate_AppUser");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_Sex_AppUser");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.AppointmentId).HasColumnName("Appointment_Id");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_Id");

                entity.Property(e => e.DateTimeOfAppointmentCreation).HasColumnType("datetime");

                entity.Property(e => e.DateTimeOfAppointmnet).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("Service_Id");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_AppUser_Appointment");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_Service_Appointment");
            });

            modelBuilder.Entity<BussinesType>(entity =>
            {
                entity.ToTable("BussinesType");

                entity.Property(e => e.BussinesTypeId).HasColumnName("Bussines_Type_Id");

                entity.Property(e => e.BussinesTypeName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Bussines_Type_Name");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId)
                    .ValueGeneratedNever()
                    .HasColumnName("City_Id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("City_Name");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Country_Id");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Country_Name");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageId)
                    .ValueGeneratedNever()
                    .HasColumnName("Message_Id");

                entity.Property(e => e.MessageContent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Message_Content");
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("Rate");

                entity.Property(e => e.RateId)
                    .ValueGeneratedNever()
                    .HasColumnName("Rate_Id");

                entity.Property(e => e.RateName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Rate_Name");
            });

            modelBuilder.Entity<RateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RateUser");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_Id");

                entity.Property(e => e.RateId).HasColumnName("Rate_Id");
            });

            modelBuilder.Entity<ReportedUser>(entity =>
            {
                entity.ToTable("ReportedUser");

                entity.Property(e => e.ReportedUserId).HasColumnName("Reported_User_Id");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_id");

                entity.Property(e => e.ReportedUserReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Reported_User_Reason");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.ReportedUsers)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_AppUser_ReportedUser");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Role_Id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("Sale");

                entity.Property(e => e.SaleId).HasColumnName("Sale_Id");

                entity.Property(e => e.SaleType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sale_type");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Service_Id");

                entity.Property(e => e.Price)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Service_Name");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.ToTable("Sex");

                entity.Property(e => e.SexId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sex_Id");

                entity.Property(e => e.SexName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sex_Name");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("Subscription");

                entity.Property(e => e.SubscriptionId).HasColumnName("Subscription_Id");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_Id");

                entity.Property(e => e.DateOfSubscription).HasColumnType("datetime");

                entity.Property(e => e.SaleId).HasColumnName("Sale_Id");

                entity.Property(e => e.SubscriptionType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Subscription_Type");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_AppUser_Subscription");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_Sale_Subscription");
            });

            modelBuilder.Entity<UserMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserMessage");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_Id");

                entity.Property(e => e.MessageId).HasColumnName("Message_Id");
            });

            modelBuilder.Entity<UserRoleId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserRole_Id");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_Id");

                entity.Property(e => e.UserRoleId1).HasColumnName("UserRole_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
