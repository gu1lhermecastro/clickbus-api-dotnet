namespace ClickBus.Entities.V1.Place
{
    /// <summary>
    /// TODO: Doc.
    /// </summary>
    public class PlaceEntity : BaseDocument
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
