using System;
using System.Collections.Generic;

namespace InventoryProject.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public int GenderId { get; set; }
    }
}
