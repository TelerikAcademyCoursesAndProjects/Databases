namespace StudentSystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<StudentDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(StudentDbContext context)
        {
            context.Students
                 .AddOrUpdate(
                s => s.Name,
                new Student
                {
                    Name = "First seeded student",
                    Number = 113131
                });
        }
    }
}
