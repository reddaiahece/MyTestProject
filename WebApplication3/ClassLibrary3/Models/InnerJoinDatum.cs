using System;
using System.Collections.Generic;

namespace EFCoreDB.Models;

public partial class InnerJoinDatum
{
    public int OrganizationId { get; set; }

    public string OrganizationName { get; set; } = null!;

    public string BranchName { get; set; } = null!;
}
