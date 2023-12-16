using System;
using System.Collections.Generic;

namespace Error_Tracker;

public partial class Project
{
    public int ProjectId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Change> Changes { get; set; } = new List<Change>();

    public virtual ICollection<Error> Errors { get; set; } = new List<Error>();

    public virtual ICollection<Projectcomment> Projectcomments { get; set; } = new List<Projectcomment>();

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
