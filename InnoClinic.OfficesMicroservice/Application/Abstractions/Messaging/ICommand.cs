﻿using Application.Shared;
using MediatR;

namespace Application.Abstractions.Messaging
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
    }

    public interface ICommand : IRequest<Result>
    {
    }
}
