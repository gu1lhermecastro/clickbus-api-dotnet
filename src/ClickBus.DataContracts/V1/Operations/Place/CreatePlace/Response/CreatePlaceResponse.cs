using System;
using ClickBus.DataContracts.V1.Response;

namespace ClickBus.DataContracts.V1.Operations.Place.CreatePlace.Response
{
    /// <summary>
    /// TODO: Doc.
    /// </summary>
    public class CreatePlaceResponse : BaseResponse
    {
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
