using System;
using System.Collections.Generic;

namespace Error_Tracker;

public partial class Error
{
    public int ErrorId { get; set; }

    public int ProjectId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Type { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Status { get; set; }

    public int? Priority { get; set; }

    public int? Severity { get; set; }

    public virtual ICollection<Errorcomment> Errorcomments { get; set; } = new List<Errorcomment>();

    public virtual Project Project { get; set; } = null!;
}
