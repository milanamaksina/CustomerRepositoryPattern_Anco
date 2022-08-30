﻿namespace CustomerRepositoryPattern.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string AddressLine { get; set; }
        public string AddressLine2 { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
