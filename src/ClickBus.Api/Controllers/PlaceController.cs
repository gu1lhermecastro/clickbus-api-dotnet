using ClickBus.DataContracts.V1.Response.Place;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ClickBus.Api.Controllers
{
    /// <summary>
    /// TODO: Doc
    /// </summary>
    [ApiController]
    [Route("place")]
    public class PlaceController : ControllerBase
    {
        private readonly ILogger<PlaceController> _logger;

        public PlaceController(ILogger<PlaceController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public PlaceResponse CreatePlace()
        {
            return null;
        }

        [HttpPatch]
        [Route("{id}")]
        public PlaceResponse UpdatePlace()
        {
            return null;
        }

        [HttpGet]
        [Route("{id}")]
        public PlaceResponse GetPlaceById()
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<PlaceResponse> GetPlaceListByFilters()
        {
            return null;
        }
    }
}
