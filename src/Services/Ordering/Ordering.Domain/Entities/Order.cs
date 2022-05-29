﻿using Ordering.Domain.Common;

namespace Ordering.Domain.Entities
{
    public class Order: EntityBase
    {
        public string Username { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }

        //billing address
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string AddressLine { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

        //payment
        public string CardName { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string Expiration { get; set; } = string.Empty;
        public string CVV { get; set; } = string.Empty;
        public int PaymentMethod { get; set; }
    }
}