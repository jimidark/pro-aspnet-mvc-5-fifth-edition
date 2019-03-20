﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class CustomOverrideActionFiltersAttribute : FilterAttribute, IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get { return typeof(IActionFilter); }
        }
    }
}