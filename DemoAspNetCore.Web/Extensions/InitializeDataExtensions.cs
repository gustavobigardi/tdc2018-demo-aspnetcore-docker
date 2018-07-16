using System.Linq;
using DemoAspNetCore.Web.Models;

namespace DemoAspNetCore.Web.Extensions
{
    public static class InitializeDataExtensions
    {
        public static void InitializeContactData(this DemoContext context)
        {
            if (context.Contacts.Count() == 0)
            {
                context.Contacts.Add(new Contact()
                {
                    Name = "Gustavo Bellini Bigardi",
                    Email = "gbbigardi@gmail.com",
                    Phone = "+55 11 7336 9457"
                });

                context.Contacts.Add(new Contact()
                {
                    Name = "Outro contato",
                    Email = "outro@contato.com",
                    Phone = "+55 11 8844 9938"
                });

                context.SaveChanges();
            }
        }
    }
}