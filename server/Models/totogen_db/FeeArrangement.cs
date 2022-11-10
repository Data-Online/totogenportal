using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Totogen.Models.TotogenDb
{
  [Table("FeeArrangements", Schema = "dbo")]
  public partial class FeeArrangement
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FeeArrangementId
    {
      get;
      set;
    }

    public ICollection<Order> Orders { get; set; }

    [Column("FeeArrangement")]
    public string FeeArrangement1
    {
      get;
      set;
    }
  }
}
