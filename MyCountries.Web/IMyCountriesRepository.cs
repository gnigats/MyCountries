﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCountries.Web.Data
{
  public interface IMyCountriesRepository
  {
    Task<IEnumerable<Visit>> GetLatestVisits(int number);
    Task<IEnumerable<Visit>> GetVisitsByUserNameAsync(string username);
  }
}