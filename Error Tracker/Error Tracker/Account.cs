using System;
using System.Collections.Generic;

namespace Error_Tracker;

public partial class Account
{
    public int AccountId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Errorcomment> Errorcomments { get; set; } = new List<Errorcomment>();

    public virtual ICollection<Projectcomment> Projectcomments { get; set; } = new List<Projectcomment>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();


    public string FullDescription => Username + " : " + Name;
}
