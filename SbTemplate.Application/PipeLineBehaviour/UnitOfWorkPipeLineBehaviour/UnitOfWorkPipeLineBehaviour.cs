using MediatR;
using Microsoft.Extensions.Logging;
using SbTemplate.SharedLayer.Interfaces;
namespace Catalog.Application.Behaviours.UnitOfWorkPipeLineBehaviour
{
    public sealed class UnitOfWorkPipeLineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        readonly IUnitOfWork _unitOfWork;
        readonly ILogger<UnitOfWorkPipeLineBehaviour<TRequest, TResponse>> _logger;
        public UnitOfWorkPipeLineBehaviour(IUnitOfWork unitOfWork, ILogger<UnitOfWorkPipeLineBehaviour<TRequest, TResponse>> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!typeof(TRequest).Name.Contains("Command", StringComparison.OrdinalIgnoreCase))
                return await next();
            var startedHere = false;
            if (!_unitOfWork.HasActiveTransaction)
            {
                await _unitOfWork.BeginTransactionAsync();
                startedHere = true;
            }
            try
            {
                _logger.LogInformation($"Starting transaction for {typeof(TRequest).Name}");
                var response = await next();
                if (startedHere)
                    await _unitOfWork.CommitAsync();
                _logger.LogInformation($"Transaction committed for {typeof(TRequest).Name}");
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(
              $"Error while handling {typeof(TRequest).Name} : {ex.Message} . Rolling back transaction."
              );

                if (startedHere)
                    await _unitOfWork.RollbackAsync();
                throw ex;
            }
        }
    }
}
