namespace RealCashMs.Models;


// This is a frontend model. Only to be used Per Day.
public enum MealTime{
    Breakfast,Lunch,Supper,LateNight
}
public class WorkShift{
    public MealTime mealType{get;set;}
    public List<Employee> employeesInShift{get;set;} = null!;
}