namespace RealCashMs.Models;

public interface IDatabaseInterface{
    // Interfaces are not that good with static methods.
    public IQueryable<Customer> cutomers{get;}
    public IQueryable<Meal> mealList{get;}
    public void Add(Meal mealInstance);
    public void AddCustomer(Customer mealInstance);
}