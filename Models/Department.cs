using System.ComponentModel.DataAnnotations;


namespace RealCashMs.Models;

// Backend model. I'll test how the efcore stores a list
public class Department{
    [Key]
    public int departmentCode{get;set;}
    public string DepartmentName{get;set;} = null!;
    // related to the EmployeeNos in the Employee class.
    public virtual ICollection<Employee> Employees{get;set;} = null!;
    // list of jobgroupcodes, uses the jobgroupcodes enum in the jobgroup class.
    // can work well with the job group class using the jobgroupcode
}