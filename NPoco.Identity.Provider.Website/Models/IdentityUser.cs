using Microsoft.AspNet.Identity;
using NPoco.Identity.Provider.Interfaces;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NPoco.Identity.Provider.Website.Models
{
    [TableName("AspNetUsers")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class IdentityUser : IIdentityUser<int>
    {
        public int AccessFailedCount
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public bool EmailConfirmed
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public bool LockoutEnabled
        {
            get; set;
        }

        public DateTime? LockoutEndDateUtc
        {
            get; set;
        }

        public string PasswordHash
        {
            get; set;
        }

        public string PhoneNumber
        {
            get; set;
        }

        public bool PhoneNumberConfirmed
        {
            get; set;
        }

        public string SecurityStamp
        {
            get; set;
        }

        public bool TwoFactorEnabled
        {
            get; set;
        }

        public string UserName
        {
            get; set;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<IdentityUser, int> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            
            return userIdentity;
        }
    }
}
