using System;
using System.Collections.Generic;

namespace EFCoreDB.Models;

public partial class OrganizationMain
{
    public int OrganizationId { get; set; }

    public string OrganizationName { get; set; } = null!;
}
