using ScotWaterV1.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class BusinessBills
{
    [Key]
    public int BusinessBillID { get; set; }

    [Required]
    public DateTime BillDate { get; set; }

    [Required]
    public decimal TotalCharges { get; set; }

    [Required]
    public decimal TotalDiscount { get; set; }

    [Required]
    public decimal SubTotal { get; set; }

    [Required]
    public decimal VAT { get; set; }

    [Required]
    public decimal BusinessFinalCost { get; set; }

    [Required]
    public decimal DiscountRate { get; set; }   // ← ADD THIS BACK

    [Required]
    public int BusinessID { get; set; }

    public BusinessUser BusinessUser { get; set; }
}
