using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// machine = student
namespace Factory.Models

{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    [DisplayName("Machine Name")]
    [Required(ErrorMessage = "Machine name is required")]
    public string MachineName { get; set; }
    [DisplayName("Machine Details")]
    [Required(ErrorMessage = "Machine Details are required")]
    public string MachineDetails {get; set;}

    public virtual ICollection<EngineerMachine> JoinEntities { get;}
  }
}