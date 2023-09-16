﻿using Core.API.Controllers;
using Core.Persistence.Pagination;
using Microsoft.AspNetCore.Mvc;
using TransportathonHackathon.Application.Features.Cars.Commands.Create;
using TransportathonHackathon.Application.Features.Cars.Commands.Delete;
using TransportathonHackathon.Application.Features.Cars.Commands.Update;
using TransportathonHackathon.Application.Features.Cars.Queries.GetById;
using TransportathonHackathon.Application.Features.Cars.Queries.GetList;

namespace TransportathonHackathon.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCarCommand command) 
        {
            CreatedCarResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteCarCommand command)
        {
            DeletedCarResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCarCommand command)
        {
            UpdatedCarResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{VehicleId}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCarQuery command)
        {
            GetByIdCarResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListCarQuery command)
        {
            IPaginate<GetListCarResponse> response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
