using System.ComponentModel.DataAnnotations;

namespace RealCashMs.Models;

// Backend model
public enum AlertType{
    FoodIssues,EmployeeeIssues
}
public enum FoodQuantityState{
    Low,medium,perfect,overboard
}
public class CustomerAlert{
    [Key]
    public string AlertEmailAddres{get;set;} = null!;
    public AlertType alertType{get;} = AlertType.FoodIssues;
    // The food state is raised by the system itself.Neeeds no employee, thats why I've set the employee as nullable.
    public FoodQuantityState quantityState {get;set;} = FoodQuantityState.perfect;

    // foreign key
    public string EmailAddress{get;set;} = null!;
    public virtual Customer customerDetails{get;set;}  = null!;
}