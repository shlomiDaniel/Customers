﻿using System.ComponentModel.DataAnnotations;

namespace CustomerManagementProject.Models
{
    public class Customer
    {
        public int Id { get; set; }      
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? ZipCode { get; set; }
        public List<Contract>? Contracts { get; set; }
    }
}
