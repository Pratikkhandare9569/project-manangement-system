using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

public class ProjectEntity
{
    [Key]
	public string ProjectId { get; set; } = "";


	public string ProjectName { get; set; } = "";

    public DateTime ProjectStartDate { get; set; }= DateTime.MinValue;

    public DateTime ProjectEndDate { get; set; }= DateTime.MinValue;

    public string ProjectDescription { get; set; } = "";
	 public ICollection<ProjectAssignmentEntity> ProjectAssignments { get; set; }= new List<ProjectAssignmentEntity>();



}
