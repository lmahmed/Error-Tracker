using System;
using System.Collections.Generic;

namespace Error_Tracker;

public partial class Change
{
    public int ChangeId { get; set; }

    public int ProjectId { get; set; }

    public string Change1 { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public virtual Project Project { get; set; } = null!;
}
