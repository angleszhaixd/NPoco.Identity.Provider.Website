﻿using NPoco.Identity.Provider.Interfaces;

namespace NPoco.Identity.Provider.Website.Models
{
    [TableName("AspNetUserRoles")]
    [PrimaryKey("RoleId, UserId")]
    public class IdentityRoles : IIdentityRoles<int>
    {
        public int RoleId
        {
            get; set;
        }

        public int UserId
        {
            get; set;
        }
    }
}