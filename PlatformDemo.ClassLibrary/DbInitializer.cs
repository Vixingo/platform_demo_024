using System;



using System;
using System.Linq;

namespace PlatformDemo.ClassLibrary
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.ServicePlans.Any())
            {
                return;   
            }

            var servicePlans = new ServicePlan[]
            {
            new ServicePlan{ServicePlanId=1,DateOfPurchase=DateTime.Now},
          new ServicePlan{ServicePlanId=2,DateOfPurchase=DateTime.Now},
         new ServicePlan{ServicePlanId=3,DateOfPurchase=DateTime.Now},
         
           
            };


       foreach(var ServicePlan in servicePlans)
       context.ServicePlans.Add(ServicePlan);
    
    context.SaveChanges();

          
         
        }
    }
}