﻿using Filters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    [SimpleMessage(Message = "C")]
    public class CustomerController : Controller
    {
        [SimpleMessage(Message = "A", Order = 2)]
        [SimpleMessage(Message = "B",  Order = 1)]
        // GET: Customer
        public string Index()
        {
            return "This is the Customer controller";
        }

        [CustomOverrideActionFilters] // prevent global, class filters
        [SimpleMessage(Message = "D")]
        public string OtherAction()
        {
            return "This is the Other Action in the Customer controller";
        }
    }
}