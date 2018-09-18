using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RapprocheWebApi.BLL.Services
{
    public interface IRapprochementBLL
    {
        List<Rapprochements> GetAllRapprochements();
        List<Rapprochements> GetRapprochementsByDate(DateTime date);
    }
}
