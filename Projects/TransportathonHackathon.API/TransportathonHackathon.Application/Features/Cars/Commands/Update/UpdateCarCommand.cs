﻿using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Transaction;
using MediatR;
using System.Security.Claims;
using TransportathonHackathon.Application.Constants;

namespace TransportathonHackathon.Application.Features.Cars.Commands.Update
{
    public class UpdateCarCommand : IRequest<UpdatedCarResponse>, ITransactionalRequest, ISecuredRequest
    {
        public Guid VehicleId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid DriverId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }

        public string[] Roles => new string[] { };
        public Claim[] Claims => new Claim[] { ProjectClaimConstants.CompanyClaim };
    }
}
