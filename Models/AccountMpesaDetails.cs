using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealCashMs.Models;


// I'll work out how to use this data to link it with the payment details.
// I can use a one to one relationship.
public class AccountMpesaDetails{
    [Key]
    public string mpesaConfirmationCode{get;set;} = null!;
    public string FirstName{get;set;} = null!;
    public string secondName{get;set;} = null!;
    public int currentAccountBalance{get;set;}
    public int initialAccountBalance{get;set;}
    // So the amount paid will be calculated from difference between the initialAccountBalance and
    // the currentAccountBalance.
    public int amountPaid{get;set;}

    // foreign key- one to one relationship
    // Here the payment details is what depends on the data from the accountMpesaDetails
    public PaymentDetails? PaymentDetails{get;set;} = null!;
}