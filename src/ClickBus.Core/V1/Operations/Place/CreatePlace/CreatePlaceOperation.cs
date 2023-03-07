using ClickBus.DataContracts.V1.Operations.Place.CreatePlace.Request;
using ClickBus.DataContracts.V1.Operations.Place.CreatePlace.Response;
using ClickBus.DataContracts.V1.Response;
using Microsoft.Extensions.Logging;

namespace ClickBus.Core.V1.Operations.Place.CreatePlace
{
    public class CreatePlaceOperation
    {
        private readonly ILogger Logger;

        public CreatePlaceOperation(
            ILogger<CreatePlaceOperation> logger)
        {
            this.Logger = logger;
        }

        public CreatePlaceResponse ProcessOperation(
            CreatePlaceRequest request)
        {
            this.Logger.LogDebug($"Going to execute {nameof(ProcessOperation)} of the {nameof(CreatePlaceRequest)}.");
            // TODO: Mapear requisição para a entidade no banco.

            // TODO: Retornar a entidade que foi criada no banco.

            this.Logger.LogDebug($"Going to return {nameof(CreatePlaceResponse)}.");
            return new CreatePlaceResponse
            {

            };
        }

        public BaseResponse ValidateRequest(
            CreatePlaceRequest request)
        {
            this.Logger.LogDebug($"Going to validate all informations from {nameof(CreatePlaceRequest)}.");
            // TODO: Validar cada parâmetro da requisição.

            return new BaseResponse
            {

            };
        }
    }
}
