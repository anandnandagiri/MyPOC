using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using MyProduct.WebApi.Core;

namespace MyProduct.MicroService.WebAPI.SelfHost
{
    public class BaseController : ApiController
    {
        public ResponseUtil Composer 
        { 
            get 
            {
                return new ResponseUtil();
            } 
        }

        protected ApiResponse<TEntity> ComposeResponse<TEntity>(Func<TEntity> action)
        {
            return Composer.ComposeResponse<TEntity>(action);
        }

        protected ApiResponse<object> ComposeResponse(Action action)
        {
            return ComposeResponse<object>(() =>
                {
                    action();
                    return null;
                });
        }


    }
}
