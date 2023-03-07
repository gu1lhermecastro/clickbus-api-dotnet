using System;

namespace ClickBus.DataContracts.V1.Response.Place
{
    /// <summary>
    /// TODO: Doc.
    /// </summary>
    public class PlaceResponse : BaseResponse
    {
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
