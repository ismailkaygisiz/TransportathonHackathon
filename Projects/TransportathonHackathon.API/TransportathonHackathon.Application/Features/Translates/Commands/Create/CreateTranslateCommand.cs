﻿using Core.Application.Pipelines.Transaction;
using MediatR;

namespace TransportathonHackathon.Application.Features.Translates.Commands.Create
{
    public class CreateTranslateCommand : IRequest<CreatedTranslateResponse>, ITransactionalRequest
    {
        public Guid LanguageId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
