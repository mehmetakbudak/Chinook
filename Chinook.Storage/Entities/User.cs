﻿using Chinook.Storage.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chinook.Storage.Entities
{
    public class User : BaseModel
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int? TitleId { get; set; }

        public Title Title { get; set; }

        public int? CityId { get; set; }

        public City City { get; set; }

        public User ReportedUser { get; set; }

        public int? ReportedUserId { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserType UserType { get; set; }

        public string Token { get; set; }

        public DateTime? TokenExpireDate { get; set; }

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }
    }
}
