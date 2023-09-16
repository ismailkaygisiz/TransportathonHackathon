﻿using FluentValidation;

namespace TransportathonHackathon.Application.Features.PickupTrucks.Commands.Create
{
    public class CreatePickupTruckCommandValidator : AbstractValidator<CreatePickupTruckCommand>
    {
        public CreatePickupTruckCommandValidator()
        {
            RuleFor(e => e.CompanyId).NotNull().NotEmpty();
            RuleFor(e => e.DriverId).NotNull().NotEmpty();
            RuleFor(e => e.Brand).NotNull().NotEmpty();
            RuleFor(e => e.Model).NotNull().NotEmpty();
            RuleFor(e => e.ModelYear).NotNull().NotEmpty().GreaterThan(1900);
            RuleFor(e => e.Size).NotNull().NotEmpty();
        }
    }
}
