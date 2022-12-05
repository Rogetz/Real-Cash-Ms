using System.ComponentModel.DataAnnotations;


namespace RealCashMs.Models;


public class EmployeeAlert{
    [Key]
    public string EmployeeAlertNo{get;set;} = null!;
    public AlertType employeeAlertType{get;set;} = AlertType.EmployeeeIssues;

    public string complaint{get;set;} = null!;  

    // foreign keys
    public string EmployeeNo{get;set;} = null!;
    public virtual Employee employeeInAlert{get;set;} = null!;
}