﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class AccountParameters : QueryStringParameters
    {
        public AccountParameters()
        {
            OrderBy = "DateCreated";
        }

    }
}
