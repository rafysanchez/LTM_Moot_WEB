using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace AngularJSAuthentication.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            //ClaimsPrincipal principal = Request.GetRequestContext().Principal as ClaimsPrincipal;

            //var Name = ClaimsPrincipal.Current.Identity.Name;
            //var Name1 = User.Identity.Name;

            //var userName = principal.Claims.Where(c => c.Type == "sub").Single().Value;

            return Ok(Order.Listar());
        }

    }


    #region Helpers

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }


        public static List<Order> Listar()
        {
            List<Order> OrderList = new List<Order> 
            {
                new Order {OrderID = 001, CustomerName = "Adriana Lima", ShipperCity = "Santos", IsShipped = true },
                new Order {OrderID = 002, CustomerName = "Gisele Bunchen", ShipperCity = "São Paulo", IsShipped = false},
                new Order {OrderID = 003,CustomerName = "Roberto Lima", ShipperCity = "Rio de Janeiro", IsShipped = false },
                new Order {OrderID = 004,CustomerName = "Acacio Mendes", ShipperCity = "Limeira", IsShipped = false},
                new Order {OrderID = 005,CustomerName = "Rogeria Ramula", ShipperCity = "Campinas", IsShipped = true}
            };

            return OrderList;
        }
    }

    #endregion
}
