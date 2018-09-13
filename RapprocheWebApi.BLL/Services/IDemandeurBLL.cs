using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RapprocheWebApi.BLL.Services
{
    public interface IDemandeurBLL
    {
        List<Demandeurs> GetAllDemandeurs();
        List<Demandeurs> GetDemandeur(Guid wilayaId);
    }
}
