using NPoco.Identity.Provider.Interfaces;

namespace NPoco.Identity.Provider.Website.Models
{
    [TableName("AspNetUserLogins")]
    public class IdentityLogin : IIdentityLogin<int>
    {
        public string LoginProvider
        {
            get; set;
        }

        public string ProviderKey
        {
            get; set;
        }

        public int UserId
        {
            get; set;
        }
    }
}
