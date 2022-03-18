namespace Factory
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MachineId { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}