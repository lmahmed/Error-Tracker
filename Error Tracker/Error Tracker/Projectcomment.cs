using System;
using System.Collections.Generic;

namespace Error_Tracker;

public partial class Projectcomment
{
    public int ProjectCommentId { get; set; }

    public int ProjectId { get; set; }

    public int AccountId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
