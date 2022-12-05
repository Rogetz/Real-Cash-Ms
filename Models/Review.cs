using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealCashMs.Models;

public class Reviews{
    [Key]
    public int ratedEmployeeIdentifier{get;set;}// same as the employee no.
    // The stars are calculated as the total no of stars given out of the 5
    // The total is then calculated as a percentage of the total then as a fraction of 5.
    //Same as that of google and the rest.

    //one to one relationship with the employee class
    [ForeignKey("EmployeeNo")]
    public virtual Employee employeesClass{get;set;} = null!;

    // many to many relationship between the customer and the review class.
    public virtual ICollection<Customer> CustomerClass{get;set;} = null!;

}