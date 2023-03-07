using System;
using System.Collections.Generic;
using System.Text;

namespace ClickBus.DataContracts.V1.Response
{
    /// <summary>
    /// TODO: Doc.
    /// </summary>
    public class BaseResponse
    {
        public bool Success { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
