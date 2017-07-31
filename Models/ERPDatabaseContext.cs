using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERPNetCore.Models
{
    public partial class ERPDatabaseContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<BusinessEntityPhone> BusinessEntityPhone { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual DbSet<EntityPhone> EntityPhone { get; set; }
        public virtual DbSet<GlobalCountry> GlobalCountry { get; set; }
        public virtual DbSet<GlobalValue> GlobalValue { get; set; }
        public virtual DbSet<GrantPermission> GrantPermission { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<JobCandidate> JobCandidate { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<TimerType> TimerType { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }

       
        // Unable to generate entity type for table 'FireSystem.BusinessEntityTimer'. Please see the warning messages.
        // Unable to generate entity type for table 'FireSystem.FireInfomation'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=ERPDatabase; User Id=sa;Password=DungMy@#96;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "Person");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.Property(e => e.WardId).HasColumnName("WardID");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("AddressType", "Person");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.ToTable("Business", "Admin");

                entity.Property(e => e.BusinessId).HasMaxLength(64);

                entity.Property(e => e.BusinessName).HasMaxLength(256);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BusinessEntity>(entity =>
            {
                entity.ToTable("BusinessEntity", "Person");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<BusinessEntityAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.AddressId, e.AddressTypeId })
                    .HasName("PK_BusinessEntityAddress_BusinessEntityID_AddressID_AddressTypeID");

                entity.ToTable("BusinessEntityAddress", "Person");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityAddress_Address");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityAddress_AddressType");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityAddress_BusinessEntity1");
            });

            modelBuilder.Entity<BusinessEntityContact>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PersonId, e.ContactTypeId })
                    .HasName("PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID");

                entity.ToTable("BusinessEntityContact", "Person");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityContact_BusinessEntity");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityContact_ContactType");
            });

            modelBuilder.Entity<BusinessEntityPhone>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PhoneId, e.PhoneNumberTypeId })
                    .HasName("PK_BusinessEntityPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID");

                entity.ToTable("BusinessEntityPhone", "Person");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityPhone)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityPhone_BusinessEntity1");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.BusinessEntityPhone)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityPhone_EntityPhone");

                entity.HasOne(d => d.PhoneNumberType)
                    .WithMany(p => p.BusinessEntityPhone)
                    .HasForeignKey(d => d.PhoneNumberTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BusinessEntityPhone_PhoneNumberType");
            });

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.ToTable("Catalog", "Multimedia");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CatalogName).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "Multimedia");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryName).HasMaxLength(150);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("FK__Category__Catalo__5DEAEAF5");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("ContactType", "Person");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department", "HumanResources");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District", "Location");

                entity.Property(e => e.DistrictId)
                    .HasColumnName("DistrictID")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Level).HasMaxLength(50);

                entity.Property(e => e.ProvinceId)
                    .IsRequired()
                    .HasColumnName("ProvinceID")
                    .HasMaxLength(10);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_District_Province");
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.EmailAddressId })
                    .HasName("PK_EmailAddress_BusinessEntityID_EmailAddressID");

                entity.ToTable("EmailAddress", "Person");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.EmailAddressId)
                    .HasColumnName("EmailAddressID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress1).HasColumnName("EmailAddress");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmailAddress)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Employee");

                entity.ToTable("Employee", "HumanResources");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeaveDate).HasColumnType("date");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.NationalIdnumber)
                    .IsRequired()
                    .HasColumnName("NationalIDNumber")
                    .HasMaxLength(15);

                entity.Property(e => e.OrganizationLevel)
                    .HasComputedColumnSql("[OrganizationNode].[GetLevel]()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Person");
            });

            modelBuilder.Entity<EmployeeDepartmentHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.DepartmentId, e.ShiftId })
                    .HasName("PK_EmployeeDepartmentHistory_BusinessEntityID_StartDate_DepartmentID");

                entity.ToTable("EmployeeDepartmentHistory", "HumanResources");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeDepartmentHistory_Employee");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeDepartmentHistory_Shift");
            });

            modelBuilder.Entity<EntityPhone>(entity =>
            {
                entity.HasKey(e => e.PhoneId)
                    .HasName("PK_PersonPhone_BusinessEntityID_EntityPhone_PhoneNumberTypeID");

                entity.ToTable("EntityPhone", "Person");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<GlobalCountry>(entity =>
            {
                entity.HasKey(e => e.GlobalId)
                    .HasName("PK_GlobalCountry");

                entity.ToTable("GlobalCountry", "Culture");

                entity.Property(e => e.GlobalId)
                    .HasColumnName("GlobalID")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.GlobalName).HasMaxLength(50);

                entity.Property(e => e.Image).HasMaxLength(50);
            });

            modelBuilder.Entity<GlobalValue>(entity =>
            {
                entity.HasKey(e => e.ControlId)
                    .HasName("PK_GlobalValue");

                entity.ToTable("GlobalValue", "Culture");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.ControlName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Eng).HasMaxLength(150);

                entity.Property(e => e.Vn).HasMaxLength(150);
            });

            modelBuilder.Entity<GrantPermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.BusinessEntityId })
                    .HasName("PK_GrantPermission");

                entity.ToTable("GrantPermission", "Admin");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.GrantPermission)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrantPermission_Employee");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.GrantPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrantPermission_Permission");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item", "Multimedia");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostedBy).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Item__CategoryID__789EE131");
            });

            modelBuilder.Entity<JobCandidate>(entity =>
            {
                entity.ToTable("JobCandidate", "HumanResources");

                entity.Property(e => e.JobCandidateId).HasColumnName("JobCandidateID");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.JobCandidate)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .HasConstraintName("FK_JobCandidate_Employee");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Password_BusinessEntityID");

                entity.ToTable("Password", "Person");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Password)
                    .HasForeignKey<Password>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Password_Person");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission", "Admin");

                entity.Property(e => e.BusinessId).HasMaxLength(64);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.PermissionName).HasMaxLength(256);

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_Permission_Business");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Person_BusinessEntityID");

                entity.ToTable("Person", "Person");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PersonType)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("newid()");

                entity.Property(e => e.Title).HasMaxLength(8);

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Person)
                    .HasForeignKey<Person>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_BusinessEntity");
            });

            modelBuilder.Entity<PhoneNumberType>(entity =>
            {
                entity.ToTable("PhoneNumberType", "Person");

                entity.Property(e => e.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(70);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province", "Location");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("ProvinceID")
                    .HasMaxLength(10);

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Level).HasMaxLength(50);

                entity.Property(e => e.ProvinceName).HasMaxLength(50);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift", "HumanResources");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimerType>(entity =>
            {
                entity.ToTable("TimerType", "FireSystem");

                entity.Property(e => e.TimerTypeId).HasColumnName("TimerTypeID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name).HasMaxLength(60);
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.ToTable("Ward", "Location");

                entity.Property(e => e.WardId)
                    .HasColumnName("WardID")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictId)
                    .IsRequired()
                    .HasColumnName("DistrictID")
                    .HasMaxLength(10);

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Level).HasMaxLength(50);

                entity.Property(e => e.WardName).HasMaxLength(50);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Ward)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ward_District");
            });
        }
    }
}