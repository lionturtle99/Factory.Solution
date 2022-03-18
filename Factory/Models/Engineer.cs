using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public string Name { get; set; }
    public DateTime DateEmployed { get; set; }
    public int EngineerId { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}