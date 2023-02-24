﻿using Teladoc.Domain.Entities;

namespace TeladocAPI.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static User operator +(User left, UserModel right)
        {
            left.FirstName = right.FirstName;
            left.LastName = right.LastName;
            left.Email = right.Email;
            left.DateOfBirth = right.DateOfBirth;

            return left;
        }
    }
}
