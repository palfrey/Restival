﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Restival.Api.WebApi {
    public class WebApiApplication : HttpApplication {
        protected void Application_Start() {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}