using JobListingsApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace JobListingsApi.Data
{
    public static class SeedData
    {
         public static void SeedDatabase(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                ApiDbContext context = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
                SeedApiData(context);
            }
        }
        private static void SeedApiData(ApiDbContext context)
        {
            context.Database.Migrate();
            if (!context.Jobs.Any())
            {     
                context.Jobs.AddRange(
                     new Job()
                     {
                         Id = 1,
                         Company = "Photosnap",
                         Image = "./images/photosnap.svg",
                         Title = "Senior Frontend Developer",
                         Created_date = DateTime.Now,
                         Description = "Description",
                         Location = "Usa Only",
                         Type = "Full Time",
                         Tags = new List<string>() { "Frontend", "Senior", "HTML", "Javascript" }
                     },
                     new Job()
                     {
                         Id = 2,
                         Company = "Manage",
                         Image = "./images/manage.svg",
                         Title = "Fullstack Developer",
                         Created_date = DateTime.Now,
                         Description = "Description",
                         Location = "Remote",
                         Type = "Part Time",
                         Tags = new List<string>() { "Python", "React", "Midweight" }
                     },
                    new Job
                    {
                        Id = 3,
                        Company = "Account",
                        Image = "./images/account.svg",
                        Title = "Junior Frontend Developer",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "USA Only",
                        Type = "Part Time",
                        Tags = new List<string> { "JavaScript", "React", "Sass", "Junior" }
                    },
                    new Job
                    {
                        Id = 4,
                        Company = "MyHome",
                        Image = "./images/myhome.svg",
                        Title = "Junior Frontend Developer",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "USA Only",
                        Type = "Contract",
                        Tags = new List<string> { "CSS", "JavaScript", "Junior" }
                    },
                    new Job
                    {
                        Id = 5,
                        Company = "Loop Studios",
                        Image = "./images/loop-studios.svg",
                        Title = "Software Engineer",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "Worldwide",
                        Type = "Full Time",
                        Tags = new List<string> { "JavaScript", "Ruby", "Midweight", "Sass" }                     
                    },
                    new Job
                    {
                        Id = 6,
                        Company = "FaceIt",
                        Image = "./images/faceit.svg",
                        Title = "Junior Backend Developer",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "UK Only",
                        Type = "Full Time",
                        Tags = new List<string> { "Ruby", "Junior", "RoR" }
                        
                    },
                    new Job
                    {
                        Id = 7,
                        Company = "Shortly",
                        Image = "./images/shortly.svg",
                        Title = "Junior Developer",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "Worldwide",
                        Type = "Full Time",
                        Tags = new List<string> { "HTML", "JavaScript", "Junior", "Sass" }
                        
                    },
                    new Job
                    {
                        Id = 8,
                        Company = "Insure",
                        Image = "./images/insure.svg",
                        Title = "Junior Frontend Developer",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "USA Only",
                        Type = "Full Time",
                        Tags = new List<string> { "JavaScript", "Vue", "Sass", "Junior" }
                    },
                    new Job
                    {
                        Id = 9,
                        Company = "Eyecam Co.",
                        Image = "./images/eyecam-co.svg",
                        Title = "Full Stack Engineer",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "Worldwide",
                        Type = "Full Time",
                        Tags = new List<string> { "JavaScript", "Python", "Midweight", "Django" },
                        
                    },
                    new Job
                    {
                        Id = 10,
                        Company = "The Air Filter Company",
                        Image = "./images/the-air-filter-company.svg",
                        Title = "Front-end Dev",
                        Created_date = DateTime.Now,
                        Description = "Description",
                        Location = "Worldwide",
                        Type = "Part Time",
                        Tags = new List<string> { "JavaScript", "Junior", "React", "Sass" }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}