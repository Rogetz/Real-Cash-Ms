using System.ComponentModel.DataAnnotations;

namespace RealCashMs.Models;

public class MealsADay{
    [Key]
    public int dayOfTheYear{get;set;}
    public string nameOfTheDay{get;set;} = null!;
    // seems like a table should at least contain more than just a key for ef core 
    // to recognize it appropriately, otherwise ef core creates a conflic between 
    // this primary key and the foreign key in the other table.

    // note the use of the virtual keyword.
    // deleted the mealsOfffered section for a bit since it was causing some errors
    // later on returned it, after verifying that it was no longer causing errors.
    public virtual ICollection<Meal> mealsOffered{get;set;} = null!;

    // navigation class for all workers of the day.
    public virtual ICollection<CasualWorker> casualWorker{get;set;} = null!;
    public virtual ICollection<Cook> cooksForTheDay{get;set;} = null!;

    public virtual ICollection<Supervisor> supervisorsOfTheDay{get;set;} = null!;
}