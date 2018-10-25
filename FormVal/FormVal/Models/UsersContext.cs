using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace FormVal.Models
{
    public class UsersContext :DbContext
    {
        public UsersContext()
            : base("UsersConnection")
        {

        }
        public DbSet<Register> RegisterTable { get; set; }
    }
}