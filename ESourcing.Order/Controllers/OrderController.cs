using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Order.Controllers
{
    [Route("api/v1/[controller]")] // metodlara nasıl erişeceğimiz attribute u route
    [ApiController]
    public class OrderController : ControllerBase // Api controller olacak o yüzden controllerbase den inherit atmalı
    {
     
    }
}
