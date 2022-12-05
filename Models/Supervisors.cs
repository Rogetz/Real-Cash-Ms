using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealCashMs.Models;

public class Supervisor{
    [Key]
    public int supervisorNo{get;set;}
    public bool onDuty{get;set;}
    public int dayOfTheYear{get;set;}
    public MealsADay dayMeals{get;set;} = null!;

    // The one to one relationship employees in the table.
    public string EmployeeNo{get;set;} = null!;

    [ForeignKey("EmployeeNo")]
    public virtual Employee employees{get;set;} = null!;// virtual key is for supporting
    // lazy loading.
    // Its a great feature but its not a must, use it if you feel like you need some lazy loading
    // which is simply getting data on demand(Its not just placed there, it still applies some conepts of the normal virtual property of classes.)
}