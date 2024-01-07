using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class EmployeeEntity
{

    [Key]
    public string EmployeeId { get; set; } = "";
    public string EmployeeName { get; set; } = "";
    public string Designation { get; set; } = "";

    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";
    public ICollection<ProjectAssignmentEntity> ProjectAssignments { get; set; }= new List<ProjectAssignmentEntity>();
}
