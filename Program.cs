using System;
using System.Collections.Generic;
using System.Linq;
using TiagoPortal.ContentContext;
using TiagoPortal.ContentContext.Enums;
using TiagoPortal.SubscriptionContext;

namespace TiagoPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre CSharp", "csharp"));
            articles.Add(new Article("Artigo sobre DotNet", "dotnet"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine($"Id: {article.Id}");
            //     Console.WriteLine($"Title: {article.Title}");
            //     Console.WriteLine($"Uri: {article.Uri}");
            // }

            var courses = new List<Course>();
            courses.Add(new Course("Fundamentos OOP", "fundamentos-oop", EContentLevel.Fundamental));
            courses.Add(new Course("Fundamentos CSharp", "fundamentos-csharp", EContentLevel.Beginner));
            courses.Add(new Course("Fundamentos ASP.NET", "fundamentos-aspnet", EContentLevel.Intermediary));

            // var career = new Career("Especialista .Net", "especialista-dotnet");
            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .Net", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courses.Find(course => course.Uri == "fundamentos-csharp"));
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courses.Find(course => course.Uri == "fundamentos-aspnet"));
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x =>x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"Title: {item.Course?.Title}");
                    Console.WriteLine($"Level: {item.Course?.Level}");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var paypalSubscription = new PayPalSubscription();
            var student = new Student();
            
            student.CreateSubscription(paypalSubscription);
        }
    }
}
