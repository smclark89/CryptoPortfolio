﻿using CryptoPortfolio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoPortfolio.Core.Interfaces
{
     public interface IExchangeRepository : IReadonlyRepository<IExchange>
    {
        IExchange Find(string exchangeName);
        IExchange Find<TExchangeType>(TExchangeType exchangeType);
    }
}
