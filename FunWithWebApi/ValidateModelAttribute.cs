using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;

namespace FunWithWebApi
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        #region Public Methods

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext.Request.CreateResponse(
                    HttpStatusCode.BadRequest, actionContext.ModelState);
            }
        }

        #endregion Public Methods

        #region Private Methods

        #endregion Private Methods
    }
}