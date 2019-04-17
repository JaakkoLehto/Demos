using System.Collections.Generic;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Models
{
    public class ManagerUsersViewModel
    {
        public ApplicationUser[] Administrators { get; set; }
        public ApplicationUser[] Everyone { get; set; }
    }
}