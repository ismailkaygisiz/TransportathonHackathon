﻿namespace TransportathonHackathon.WebAPI.Dtos.Carrier
{
    public class CreateCarrierDto
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Guid CompanyId { get; set; }
    }
}
