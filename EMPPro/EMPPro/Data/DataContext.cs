using System;
using System.Collections.Generic;
using Bogus;
using EMPPro;
using EMPPro.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMPPro.Data;

public partial class DataContext : IdentityDbContext
{

    public DbSet<Employee> Employees { get; set; }
    public DataContext(DbContextOptions options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Employee>().HasData(GetEmployees());
    }

    private List<Employee> GetEmployees()
    {
        var employees = new List<Employee>();
        var faker = new Faker("en");

        for (int i = 0; i <= 50; i++)
        {
            var employee = new Employee
            {
                Id = i,
                ImgUrl = faker.Internet.Avatar(),
                Name = faker.Name.FullName(),
                Salary = GetRandomSalary(),
                EmployeeType = GetRandomEmployeeType(),
                Position = GetRandomPosition()
            };

            employees.Add(employee);
        }
        return employees;
    }

    private Position GetRandomPosition()
    {
        var random = new Random();
        var positions = Enum.GetValues(typeof(Position));
        return (Position)positions.GetValue(random.Next(positions.Length));
    }

    private EmployeeType GetRandomEmployeeType()
    {
        var random = new Random();
        var types = Enum.GetValues(typeof(EmployeeType));
        return (EmployeeType)types.GetValue(random.Next(types.Length));
    }

    private decimal GetRandomSalary()
    {
        var random = new Random();
        decimal salary = random.Next(30000, 100000);
        return salary;
    }
}
