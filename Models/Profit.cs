using System.ComponentModel.DataAnnotations;

namespace RealCashMs.Models;

public class Profit{
    [Key]
    // counts from number one to 365
    public int profitDayOfTheYear{get;set;}
    public int Capital{get;set;}
    public int returnsMade{get;set;}
    public int profitMade{get;set;} // Can be a negative or a positive number.
    public bool profit{get;set;} = false;
    public bool loss{get;set;} = false;


    // used for navigating through the AccountMpesaDetails to get all the amounts and calculate the various profits.
    public ICollection<AccountMpesaDetails> mpesaDetailsCollection{get;set;} = null!;
}