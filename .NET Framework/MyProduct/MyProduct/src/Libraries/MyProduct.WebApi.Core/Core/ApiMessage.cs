using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProduct.WebApi.Core
{

    public enum MessageType
    {
        None =0,
        Success=1,
        Error = 2,
    }


    [JsonObject(Description = "Base Response for All API Response", MemberSerialization = MemberSerialization.OptOut)]   
    public class ApiMessage
    {
        [JsonProperty(PropertyName="Message Type")]
        public MessageType MessageType { get; set; }

        [JsonProperty(PropertyName="Message Text")]
        public string MessageText { get; set; }
    }
}
