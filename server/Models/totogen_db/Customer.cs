using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Totogen.Models.TotogenDb
{
  [Table("Customers", Schema = "dbo")]
  public partial class Customer
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustomerId
    {
      get;
      set;
    }

    public ICollection<Order> Orders { get; set; }
    public string CustomerName
    {
      get;
      set;
    }
    public string Address1
    {
      get;
      set;
    }
    public string Address2
    {
      get;
      set;
    }
    public string Address3
    {
      get;
      set;
    }
    public string Pcode
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? TotalOrders
    {
      get;
      set;
    }
  }
}
