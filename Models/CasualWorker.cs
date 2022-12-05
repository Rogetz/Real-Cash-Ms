using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;// for the ef attributes.

namespace RealCashMs.Models;

// Backend model
// link it to the mealsADay table so that, you can check the casual worker for the day.
// the MealADay.
public class CasualWorker{
    [Key]
    // test it tommorrow, cause it worked for the accountmpesa details dotnt know why it aint working here.
    public string CasualWorkerNo{get;set;} = null!;
    public bool OnDuty{get;set;} = false;

    // the one to many relationship to EmployeesTable.
    // Ensure the  primary key names are not the same however.
    // also note that a one to one relationship means that the data in both tables would have been combined in one table
    // but because of simplicity they have been kept in separate tables.
    public string? EmployeeNo{get;set;} // note how I have used both the foreign key field , as well as the 
// foreign key attribute in the Employees navigation class.

    [ForeignKey("EmployeeNo")]
    public virtual Employee employees{get;set;} = null!;

    // the foreign key for the MealsADay.
    public string dayOfTheYear{get;set;} = null!;
    // the navigation property for the MealsADay
    public MealsADay mealsOfTheDay{get;set;} = null!;
}