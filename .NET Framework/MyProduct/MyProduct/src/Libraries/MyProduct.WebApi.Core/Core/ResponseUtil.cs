using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MyProduct.WebApi.Core
{
    public class ResponseUtil
    {
        HttpContext context;

        public ResponseUtil()
        {
            context = HttpContext.Current;
        }

        public ApiResponse<TData>  ComposeResponse<TData>(Func<TData> func)
        {
            try
            {                
                return  new ApiResponse<TData>()
                {
                    Data = func(),
                    Success = true,
                    Messages = null
                };            
            }
             catch (Exception ex)
            {
                return GetException<TData>(ex);
            }
            
        }

        private ApiResponse<TData> GetException<TData>(Exception ex)
        {

            string data = string.Empty;
            if(ex !=null && ex.Data != null && ex.Data.Count > 0 && ex.Data["Data"] != null)
                data = ex.Data["Data"].ToString();


            return new ApiResponse<TData>()
            {
                Success = false,
                Messages = new List<ApiMessage>()
                {
                    new ApiMessage()
                    {
                        MessageType = MessageType.Error,
                        MessageText = (!string.IsNullOrWhiteSpace(data)) ? ex.Message + data : ex.Message
                    }
                }

            };
        }
    }
}
