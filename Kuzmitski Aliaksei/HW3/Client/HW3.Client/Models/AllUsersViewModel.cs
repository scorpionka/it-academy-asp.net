using HW3.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace HW3.Client.Models
{
    public class AllUsersViewModel
    {
        public string Name { get; set; }
        public Title Title { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }


        public string Country { get; set; }

        public string City { get; set; }
    }
}