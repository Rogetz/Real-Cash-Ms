using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealCashMs.Models;

// retrieves data from the paymentDetails table in order to issue an order number to the customer.
public class OrderIssue{
    // this is the key of the order Issue
    [Key]
    public int orderNo{get;set;}

    // here I've seen that the order depends on the receipt no from the payment details
    // I am afterwards trying to establish the one to one relationship.
    // I'll look all one to one relationships in  this angle.
    public string receiptNo{get;set;} = null!;
    public PaymentDetails paymentDetails{get;set;} = null!;

    // the many to one relationship with the customer
    public string? EmailAddress{get;set;}// can be nullable, an order issue needs not have an email address.
    public virtual Customer customerDetails{get;set;} = null!;// I need it to support some lazy loading.
}