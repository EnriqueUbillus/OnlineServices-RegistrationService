﻿using OnlineServices.Shared.DataAccessHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using UserServices.Shared;

namespace UserServices.DataLayer.Entities
{
    [Table("User")]
    public class UserEF: IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public Role Role { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public ICollection<UserSessionEF> UserSessions;
        public bool IsActivated { get; set; }
    }
}
