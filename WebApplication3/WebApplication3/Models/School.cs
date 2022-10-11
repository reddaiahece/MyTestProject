using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class School
{
    public int Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
