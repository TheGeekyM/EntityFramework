// See https://aka.ms/new-console-template for more information
using EntityFramework;

Console.WriteLine("Hello, World!");

var context = new ApplicationDbContext();

var user = new EntityFramework.Entities.User()
{
    FirstName = "user",
    LastName = "user "
};

context.Users.Add(user);
context.SaveChanges();
