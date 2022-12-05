using System.ComponentModel.DataAnnotations;

namespace RealCashMs.Models;

// Before you run this class confirm if a class can be a primary key.

// This class works with the Receipt class to get details of the receipt.
// We actually don't need a customers details.
// For the sake of dropping down comments, a customer can choose to drop a comment via his or her name.
public class Customer{
    // receipt issued after the mpesa code has been confirmed.
    // This receipt is basically the identifier that this particular customers mpesa code is validated successfully.
    [Key] // confirm whether a class can be a key in a specific class.I've not confirmed thatso for the moment am assuming it cant and so am not using it as the primary key.
    public string EmailAddress{get;set;} = null!;

    // a customer can have multiple payment details, but a payment details can not have more than one.
   
    // OrderNo issued before confirmation. In the case of a queue i.e in a mess, can be used to determine who comes first before the other person.
    // Its not a must for a Customer to have it. But incase of a mess system, then a customer must have it.
    // THE First name can be accessed via the account details
    public string comments{get;set;} = null!;
    public int starsReviews{get;set;}

    public ICollection<OrderIssue> orderClass{get;set;} = null!;

    public ICollection<Meal> mealsOrdered{get;set;} = null!;

    // a one to many relationship.
    public ICollection<PaymentDetails> paymentDetails{get;set;} = null!;

    // many to many relationship 
    public ICollection<Reviews> reviewsClass{get;set;} = null!;

}