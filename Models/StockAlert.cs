using System.ComponentModel.DataAnnotations;

namespace RealCashMs.Models;

// I've added this later so dont delete it.
// this is the page whereby the admin/manager can navigate to get the stock alert
// for the lower quantity of food.
// this page communicates with the stock page in order to determine when the food stock
// is low or high or medium, since it uses the values stored in the stock model.
public enum StockLevel{
    low,medium,high
}
public class StockAlert{
    [Key]
    public StockCodes stockAlertCode{get;set;}
    public StockLevel stockLevel{get;set;}
    
    // you need to create a one to one relationship between the stock class and the stock alert class
}