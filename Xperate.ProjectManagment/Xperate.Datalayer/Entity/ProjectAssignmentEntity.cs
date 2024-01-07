using System;

public class ProjectAssignmentEntity
{

	public ProjectAssignmentEntity()
	{ }

	public string ProjectId { get; set; } = "";

	public string EmployeeId { get; set; } = "";


    public ProjectEntity Project { get; set; }= new ProjectEntity();
    public EmployeeEntity Employee { get; set; }=new EmployeeEntity();
  
	
}
