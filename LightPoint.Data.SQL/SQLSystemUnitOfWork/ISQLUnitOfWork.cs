﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LightPoint.Data.SQL.SQLSystemUnitOfWork
{
    public interface ISQLUnitOfWork
    {
        DbContext MYDbContext { get; }
    }
}
