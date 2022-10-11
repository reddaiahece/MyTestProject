using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public int SchoolId { get; set; }

    public virtual School School { get; set; } = null!;
}
