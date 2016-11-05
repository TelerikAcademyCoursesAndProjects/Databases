namespace StudentSystem.Data.Migrations
{
    using System;
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
            // ТОВА СЕ РАЗКОМЕНТИРА И ИЗПОЛЗВА ЗА ТЕСТОВИ ЦЕЛИ,ТО НИ ВЪВЕЖДА ДЕФОУТНА СТОЙНОСТ ПРИ ВСЯКО ЪПДЕЙТВАНЕ БАЗАТА(КАТО ЦЯЛО ТОЗИ SEED МЕТОД)
            // СЛЕД КАТО СМЕ СИГУРНИ, ЧЕ СИ БАЧКА НЕ НИ ТРЯБВА ДА НИ ПЪЛНИ НИЩО ТОЙ И ЗАТОВА СИ ЗАКОМЕНТИРАМЕ ТОВА, КОЕТО ИЗПЪЛНЯВА!!!!!)
            // КАТО ЦЯЛО СЕ ПОЛЗВА САМО ЗА ТЕСТОВИ ЦЕЛИ ТОЗИ СИИД МЕТОД !!!!

            //context.Students
            //     .AddOrUpdate(
            //    s => s.Name,
            //    new Student
            //    {
            //        Name = "First seeded student",
            //        Number = 13131,
            //        Information = new StudentAdditionalInfo
            //        {
            //            Age = new Random().Next(18, 120),
            //            Country = "Bulgaria"
            //        }
            //    });
        }
    }
}
