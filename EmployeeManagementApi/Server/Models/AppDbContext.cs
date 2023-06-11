using Microsoft.EntityFrameworkCore;
using EmployeeManagementApi.Shared;

namespace EmployeeManagementApi.Server.Models

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Department
            modelBuilder.Entity<Department>().HasData(
                new Department {
                    DepartmentId = 1,
                    DepartmentName = "IT"
                });

            modelBuilder.Entity<Department>().HasData(
                new Department {
                    DepartmentId = 2,
                    DepartmentName = "HR"
                });

            modelBuilder.Entity<Department>().HasData(
                new Department {
                    DepartmentId = 3,
                    DepartmentName = "Accounts" 
                });

            modelBuilder.Entity<Department>().HasData(
                new Department {
                    DepartmentId = 4,
                    DepartmentName = "Payroll"
                });

            modelBuilder.Entity<Department>().HasData(
                new Department {
                    DepartmentId = 5,
                    DepartmentName = "Admin"
                });

            //Employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Jan",
                    LastName = "Mazur",
                    Email = "jan.mazur@email.com",
                    DateOfBirth = new DateTime(1980, 12, 1),
                    Gender = Gender.Male,
                    DepartmentId = 1
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Monika",
                    LastName = "Medyna",
                    Email = "monika.medyna@email.com",
                    DateOfBirth = new DateTime(1992, 10, 5),
                    Gender = Gender.Female,
                    DepartmentId = 2
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Mariusz",
                    LastName = "Kokos",
                    Email = "mariusz.kokos@email.com",
                    DateOfBirth = new DateTime(1990, 6, 15),
                    Gender = Gender.Male,
                    DepartmentId = 5
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Sebastian",
                    LastName = "Sebczyk",
                    Email = "sebastian.sebczyk@email.com",
                    DateOfBirth = new DateTime(1988, 1, 24),
                    Gender = Gender.Male,
                    DepartmentId = 3
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 5,
                    FirstName = "Michal",
                    LastName = "Marczyk",
                    Email = "michal.marczyk@email.com",
                    DateOfBirth = new DateTime(1998, 5, 11),
                    Gender = Gender.Male,
                    DepartmentId = 4
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 6,
                    FirstName = "Maria",
                    LastName = "Zogan",
                    Email = "maria.zogan@email.com",
                    DateOfBirth = new DateTime(1999, 8, 10),
                    Gender = Gender.Female,
                    DepartmentId = 4
                });
        }
    }
}
