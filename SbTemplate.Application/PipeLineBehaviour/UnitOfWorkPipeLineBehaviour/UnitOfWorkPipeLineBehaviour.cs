﻿using MediatR;
using SbTemplate.SharedLayer.Interfaces;
namespace Catalog.Application.Behaviours.UnitOfWorkPipeLineBehaviour
{
    public sealed class UnitOfWorkPipeLineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        IUnitOfWork _unitOfWork;
        public UnitOfWorkPipeLineBehaviour(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!typeof(TRequest).Name.Contains("Command", StringComparison.OrdinalIgnoreCase))
            {
                return await next();
            }
            await _unitOfWork.BeginTransactionAsync();
            var response = await next();
            await _unitOfWork.CommitAsync();
            return response;
        }
    }
}
