using System;
using System.Collections.Generic;

namespace EFCoreDB.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public int? OrganizationId { get; set; }
}
