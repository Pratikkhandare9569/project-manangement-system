using Microsoft.EntityFrameworkCore;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
    {
    }

    public DbSet<ProjectEntity> Projects { get; set; }
    public DbSet<EmployeeEntity> Employees { get; set; }
    public DbSet<ProjectAssignmentEntity> ProjectAssignments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Your entity configurations go here
        modelBuilder.Entity<EmployeeEntity>().HasKey(e => e.EmployeeId);
        modelBuilder.Entity<ProjectAssignmentEntity>().HasKey(e => e.ProjectId);
        modelBuilder.Entity<ProjectAssignmentEntity>()
            .HasKey(pa => new { pa.ProjectId, pa.EmployeeId });

        modelBuilder.Entity<ProjectAssignmentEntity>()
            .HasOne(pa => pa.Project)
            .WithMany(p => p.ProjectAssignments)
            .HasForeignKey(pa => pa.ProjectId);

        modelBuilder.Entity<ProjectAssignmentEntity>()
            .HasOne(pa => pa.Employee)
            .WithMany(e => e.ProjectAssignments)
            .HasForeignKey(pa => pa.EmployeeId);

        // Call the base class implementation
        base.OnModelCreating(modelBuilder);
    }
}
