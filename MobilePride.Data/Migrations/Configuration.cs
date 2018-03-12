using MobilePride.Entity;
using System;
using System.Data.Entity.Migrations;

namespace MobilePride.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MobilePrideContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MobilePrideContext context)
        {
            //// create users
            //context.UserSet.AddOrUpdate(GenerateUsers());
            // create roles
            context.RoleSet.AddOrUpdate(r => r.Name, GenerateRoles());
          

        }
        private Role[] GenerateRoles()
        {
            var roles = new[]{
                new Role()
                {
                    Name="Staff",
                    IsDeleted=false
                },
                 new Role()
                {
                    Name="Validator",
                    IsDeleted=false
                },
                 new Role()
                {
                    Name="Admin",
                    IsDeleted=false
                }
            };

            return roles;
        }
       
        private NotificationType[] GenerateNotificationType()
        {
            var notifyType = new[]{
                new NotificationType()
                {
                    NotificationTypeName="Email",
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                },

                new NotificationType()
                {
                    NotificationTypeName="Push",
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                },
                new NotificationType()
                {
                    NotificationTypeName="SMS",
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                }
            };
            return notifyType;
        }

        private GlobalVariable[] GenerateGlobalVariable()
        {
            var globalVariable = new[]{
                new GlobalVariable()
                {
                    Name="WebSite",
                    Value="http://localhost:1487/",
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                }
            };
            return globalVariable;
        }


        #region Generate Admin
        private User[] GenerateAdminUser()
        {
            var users = new[]{
                new User()
                {
                    Username="hlavergne@verdicos.com",
                    Email="hlavergne@verdicos.com",
                    HashedPassword="",
                    Salt="",                    
                    IsDeleted=false,
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsLocked=false                    
                }
            };

            return users;
        }
        private UserRole[] GenerateAdminRole()
        {
            var dc = new MobilePrideContext();
            var userId = dc.UserSet.Find();
            var userRole = new UserRole[]{
                new UserRole()
                {
                    UserId=new Guid(userId.ToString()),
                    RoleId= new Guid("74728d55-faf5-e611-9bcb-7427ea476715"),                                      
                    IsDeleted=false,
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow                                        
                }                 
            };

            return userRole;
        }

        #endregion
        #region State
        private State[] GenerateState()
        {
            var state = new[]{
                new State()
                {
                    StateName="Texas",
                    ////CountryId=1,
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                },

                new State()
                {
                    StateName="New Mexico",
                    //CountryId=23,
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                }
            };
            return state;
        }
        #endregion

        #region County
        private County[] GenerateCounty()
        {
            var county = new[]{
                new County()
                {
                    CountyName="Pecos",
                    ////CountryId=1,
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                },

                new County()
                {
                    CountyName="Reeves",
                    //CountryId=23,
                    CreatedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow,
                    IsDeleted=false
                }
            };
            return county;
        }
        #endregion
    }
}

