using RealCashMs.Data;

namespace RealCashMs.Models;

public class DatabaseImplementation : IDatabaseInterface{
    CashMsDbContext CMSDbContext;
    public IQueryable<Meal> mealList{get;}
    public IQueryable<Customer> cutomers{get;}
    public DatabaseImplementation(CashMsDbContext dbinstance){
        CMSDbContext = dbinstance;
        mealList = dbinstance.meals;
        cutomers = dbinstance.customers;
    }
    
    public void Add(Meal mealInstance){
        CMSDbContext.meals.Add(mealInstance);
        // for reflecting the changes into the database.
        // without these no changes are reflected.
        CMSDbContext.SaveChanges();
    }
    public void AddCustomer(Customer cutomerInstance){
        CMSDbContext.customers.Add(cutomerInstance);
        // for reflecting the changes into the database.
        // without these no changes are reflected.
        CMSDbContext.SaveChanges();
    }

}