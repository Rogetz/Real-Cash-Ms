using System.ComponentModel.DataAnnotations;


namespace RealCashMs.Models;

// enum for the job groups.
public enum JobGroup{
    A,B,C,D,E,F
    }

public class Salary{
    [Key]
    public JobGroup jobGroup{get;set;}
    public int salary{get;set;}

    public virtual ICollection<Employee> employeesInJobGroup{get;set;} = null!;
}