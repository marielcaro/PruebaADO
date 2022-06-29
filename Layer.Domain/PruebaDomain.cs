using Layer.Entity;
using Layer.AccessData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layer.Domain
{
    public class PruebaDomain
    {
        public List<PruebaEntity> Listar()
        {
            return PruebaAccessData.Listar();
        }

    }
}