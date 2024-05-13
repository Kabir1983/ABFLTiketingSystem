using System;
using System.Collections.Generic;

namespace EmployeeInfo.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? FathersName { get; set; }

    public string? MothersName { get; set; }

    public string? MobileNo { get; set; }
}
