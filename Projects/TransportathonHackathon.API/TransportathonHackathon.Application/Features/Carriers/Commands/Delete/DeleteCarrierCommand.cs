﻿using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Transaction;
using MediatR;
using System.Security.Claims;

namespace TransportathonHackathon.Application.Features.Carriers.Commands.Delete
{
    public class DeleteCarrierCommand : IRequest<DeletedCarrierResponse>, ITransactionalRequest, ISecuredRequest
    {
        public Guid EmployeeId { get; set; }

        public string[] Roles => new string[] { };
        public Claim[] Claims => new Claim[] { new Claim("UserType", "Company") };
    }
}
