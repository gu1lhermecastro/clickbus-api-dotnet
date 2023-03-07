using System;
using System.Collections.Generic;
using System.Text;

namespace ClickBus.Entities.V1
{
    /// <summary>
    /// TODO: Doc
    /// </summary>
    public class BaseDocument
    {
        public int Version => 1;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
