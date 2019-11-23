using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MyProduct.WebApi.Core
{

    [JsonObject(Description="Base Response for All API Response",MemberSerialization = MemberSerialization.OptOut)]
    public class ApiResponse<TData>
    {
        [JsonProperty(PropertyName = "data")]
        public TData Data { get; set; }

         [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

         [JsonProperty(PropertyName = "message")]
         public List<ApiMessage> Messages { get; set; }
    }
}
