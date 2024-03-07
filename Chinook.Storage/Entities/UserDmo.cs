﻿using Chinook.Storage.Enums;
using System;

namespace Chinook.Storage.Entities
{
    public class UserDmo : BaseInfoModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int? TitleId { get; set; }

        public TitleDmo Title { get; set; }

        public int? CityId { get; set; }

        public CityDmo City { get; set; }

        public UserDmo ReportedUser { get; set; }

        public int? ReportedUserId { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserType UserType { get; set; }       

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }
    }
}
