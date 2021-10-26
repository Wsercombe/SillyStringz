using System.Collections.Generic;
using System.ComponentModel;

// course = engineer
namespace SillyStringz.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }

    [DisplayName("Engineer Name")]
    public string EngineerName { get; set; }
    [DisplayName("Engineer Details")]
    public string EngineerDetails { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}