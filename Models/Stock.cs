using System.ComponentModel.DataAnnotations;

namespace RealCashMs.Models;

// The stock codes for the stock must be set, so that the stock can be stored.
// for a stock to be recognized it must be in the stockCode
public enum StockCodes{
    tomatoes,onions,wheatflour,maizeflour,oil,salt,sugar,milk
}

public class Stock{

    [Key]
    // includes the spices such as the tomatoes, e.t. , different from the meal identifier
    public StockCodes stocksIdentifier{get;set;}
    // The QuantityRemaining deducts the QuantityRemainingKg in the StockRecordPerDay.
    // The QuantityRemaining also is added directly by the admin each time new stocks are added.
    public int QuantityRemainingKg{get;set;}
    // The QuantitySackKg In StockRecord deducts from the StockRecordPerDay
    // The QuantitySack is added by the administrator each time new records have added.
    public int QuantitySack{get;set;}

    // if the alert is something like 30% alert the admmin.
    public int stockAlertPercentage{get;set;}
    public int rateOfConsumptionPercentage{get;set;}


    // the one to many relationship betwen the supplier and  the stock because a meal can have different various suppliers.
    public ICollection<Suppliers> supplierClass{get;set;} = null!;
}