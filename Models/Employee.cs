using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RealCashMs.Models;

public class Employee{
    [Key]
    public string EmployeeNo{get;set;} = null!;
    public string FirstName{get;set;} = null!;
    public string SecondName{get;set;} = null!;
    public int NationalID{get;set;}

    // the foreign key for the department table.
    public int departmentCode{get;set;}
    public virtual Department departmentWorking{get;set;} = null!;

    //foreign key called the jobGroup for the salary
    public JobGroup? jobGroup{get;set;}
    public Salary salaryClass{get;set;} = null!;

    // navigation class
    public ICollection<EmployeeAlert> empAlert{get;set;} = null!;


    // relationship between employee table and all types of employees.
    public CasualWorker casualWorker{get;set;} = null!;
    public Cook cookClass{get;set;} = null!;
    /*public Supervisor supervisor{get;set;} = null!;*/

    // one to one relationship with review class.
    public Reviews reviewClass{get;set;} = null!;
}