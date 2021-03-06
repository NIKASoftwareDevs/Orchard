﻿using Orchard.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NGM.CasClient {
    public class Routes : IRouteProvider {
        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes() {
            yield return new RouteDescriptor {
                Priority = 100,
                Route = new Route(
                    "Users/Account/Logon", // this is the name of the page url
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"}, // this is the name of your module
                            {"controller", "CasAccount"},
                            {"action", "LogOn"}
                        },
                    new RouteValueDictionary(),
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"} // this is the name of your module
                        },
                    new MvcRouteHandler())
            };
            yield return new RouteDescriptor
            {
                Priority = 100,
                Route = new Route(
                    "Users/Account/Logoff", // this is the name of the page url
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"}, // this is the name of your module
                            {"controller", "CasAccount"},
                            {"action", "LogOff"}
                        },
                    new RouteValueDictionary(),
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"} // this is the name of your module
                        },
                    new MvcRouteHandler())
            };
            yield return new RouteDescriptor
            {
                Priority = 100,
                Route = new Route(
                    "Federated/CasAuthTicket/{id}", // this is the name of the page url
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"}, // this is the name of your module
                            {"controller", "CasAccount"},
                            {"action", "CasAuthTicket"},
                            {"id", UrlParameter.Optional}
                        },
                    new RouteValueDictionary(),
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"} // this is the name of your module
                        },
                    new MvcRouteHandler())
            };
            yield return new RouteDescriptor
            {
                Priority = 100,
                Route = new Route(
                    "Federated/Logout/{id}", // this is the name of the page url
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"}, // this is the name of your module
                            {"controller", "CasAccount"},
                            {"action", "Logout"},
                            {"id", UrlParameter.Optional}
                        },
                    new RouteValueDictionary(),
                    new RouteValueDictionary {
                            {"area", "NGM.CasClient"} // this is the name of your module
                        },
                    new MvcRouteHandler())
            };
        }

    }
}