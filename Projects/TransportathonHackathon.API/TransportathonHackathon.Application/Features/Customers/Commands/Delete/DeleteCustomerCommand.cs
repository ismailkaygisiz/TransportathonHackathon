﻿using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Transaction;
using MediatR;
using System.Security.Claims;
using TransportathonHackathon.Application.Constants;

namespace TransportathonHackathon.Application.Features.Customers.Commands.Delete
{
    public class DeleteCustomerCommand : IRequest<DeletedCustomerResponse>, ITransactionalRequest, ISecuredRequest
    {
        public Guid AppUserId { get; set; }

        public string[] Roles => new string[] { };
        public Claim[] Claims => new Claim[] { ProjectClaimConstants.CustomerClaim };
    }
}
