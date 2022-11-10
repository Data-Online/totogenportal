using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Totogen.Models.TotogenDb
{
  [Table("Orders", Schema = "dbo")]
  public partial class Order
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId
    {
      get;
      set;
    }
    public string OrderNumber
    {
      get;
      set;
    }
    public int? SamplesExpected
    {
      get;
      set;
    }
    public bool? TermsSent
    {
      get;
      set;
    }
    public bool? InstructionsSent
    {
      get;
      set;
    }
    public int? FeeArrangement
    {
      get;
      set;
    }
    public FeeArrangement FeeArrangement1 { get; set; }
    public int CustomerId
    {
      get;
      set;
    }
    public Customer Customer { get; set; }
    public int? FeeStatus
    {
      get;
      set;
    }
    public FeeStatus FeeStatus1 { get; set; }
    public DateTime? SampleExpectedDate
    {
      get;
      set;
    }
  }
}
