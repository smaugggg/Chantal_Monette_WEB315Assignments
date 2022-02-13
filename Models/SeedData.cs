using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DreamcatcherMembers.Models
{
    public static class SeedData_Dreamcatcher
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DreamcatcherMembersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DreamcatcherMembersContext>>()))
            {
                if (context.Member.Any())
                {
                    return;   
                }
                
                context.Member.AddRange(
                new Member
                {
                    stageName = "Jiu",
                    fullName = "Kim Min Ji",
                    englishName = "Lily",
                    birthday = DateTime.Parse("1994-05-17"),
                    role = "Leader",
                    homeTown = "Daejeon, SK"
                },

                new Member
                {
                    stageName = "Sua",
                    fullName = "Kim Bo Ra",
                    englishName = "Alice",
                    birthday = DateTime.Parse("1994-08-10"),
                    role = "Main Dancer",
                    homeTown = "Changwon, SK"
                },

                new Member
                {
                    stageName = "Siyeon",
                    fullName = "Lee Si Yeon",
                    englishName = "Monica",
                    birthday = DateTime.Parse("1995-10-01"),
                    role = "Main Vocalist",
                    homeTown = "Daegu, SK"
                },

                new Member
                {
                    stageName = "Handong",
                    fullName = "Han Dong",
                    englishName = "Della",
                    birthday = DateTime.Parse("1996-03-26"),
                    role = "Sub Vocalist",
                    homeTown = "Wuhan, China"
                },

                new Member
                {
                    stageName = "Yoohyeon",
                    fullName = "Kim Yoo Hyeon",
                    englishName = "Rachel",
                    birthday = DateTime.Parse("1997-01-07"),
                    role = "Lead Vocalist",
                    homeTown = "Incheon, SK"
                },

                new Member
                {
                    stageName = "Dami",
                    fullName = "Lee Yu Bin",
                    englishName = "Emma",
                    birthday = DateTime.Parse("1997-03-07"),
                    role = "Main Rapper",
                    homeTown = "Seoul, SK"
                },

                new Member
                {
                    stageName = "Gahyeon",
                    fullName = "Lee Ga Hyeon",
                    englishName = "Lucy",
                    birthday = DateTime.Parse("1999-02-03"),
                    role = "Maknae",
                    homeTown = "Seongnam, SK"
                }
                );
                
                context.SaveChanges();
            }
        }
    }
}