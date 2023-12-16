using System;
using System.Collections.Generic;

namespace Error_Tracker;

public partial class Errorcomment
{
    public int CommentId { get; set; }

    public int ErrorId { get; set; }

    public int AccountId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Error Error { get; set; } = null!;
}
