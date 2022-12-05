using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace RealCashMs.Models;

// connect it to the accountMpesaDetails using a one to one relationship.
public class PaymentDetails{
    [Key]
    public string receiptNo{get;set;} = null!;
    public DateTime timeOfTheDay{get;set;}// TO record the time of the day that the transactio has happened.
    
    // I'd have used the mpesa code as the primary key,  but then I use the receipt no
    // since with the receipt no, I can use my own algorithm to generate the receipt no's
    // The receipt no generation will be dynamic.
    // As for the mpesa code, anyone knows the format and can therefor forge an mpesa payment.
    
    // I've commented it first for a moment to check on the one to one relationship.

    // the many to one relationship to the customer.
    // foreign key.
    public string EmailAddress{get;set;} = null!;
    public Customer customerDetails{get;set;} = null!;

    // note that I used the virtual property, I'm testing to see if It can actually hide the class in the table.
    // a one to one relationship with the account details, and I'm seeing its dependent on the
    // data from the accountmpesadetails.
    [ForeignKey("mpesaConfirmationCode")]    
    public AccountMpesaDetails accountDetails{get;set;} = null!;
}