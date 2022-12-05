using System.ComponentModel.DataAnnotations;

namespace RealCashMs.Models;

// so I guess I'll create a mechanism whereby you can create new enums each time another
// company is added to the list of supplier class.
public enum companyCodes{
    ChapaNdashi,RiceAndRise,InstantVeges,FreshTomatoCap
}

// Before a Supplier is needed the stockIdentifiier that it offers must be in the store.
// The stockIdentifier must be in the Store for it to be used in the Supplier class. 
public class Suppliers{
    [Key]
    public companyCodes companyCode{get;set;}
    public string CompanyName{get;set;} = null!;
    public int Pricing{get;set;}

    // the many to one realtionship with the stock class.
    public StockCodes stocksIdentifier{get;set;}
    public Stock stockClass{get;set;} = null!;
}