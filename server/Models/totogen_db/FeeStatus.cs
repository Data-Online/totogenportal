using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Totogen.Models.TotogenDb
{
  [Table("FeeStatus", Schema = "dbo")]
  public partial class FeeStatus
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FeeStatusId
    {
      get;
      set;
    }

    public ICollection<Order> Orders { get; set; }

    [Column("FeeStatus")]
    public string FeeStatus1
    {
      get;
      set;
    }
  }
}
