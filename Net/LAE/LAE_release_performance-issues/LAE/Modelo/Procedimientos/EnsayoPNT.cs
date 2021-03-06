﻿using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAE.Modelo
{
    public class FactoriaEnsayoPNT
    {
        // TODO Rellenar esto con Selects necesarias.
    }

    [TableProperties("ensayo_pnt")]
    public class EnsayoPNT : PersistenceData
    {
        [ColumnProperties("id_ensayopnt", IsId = true, IsAutonumeric = true)]
        public int Id { get; set; }

        [ColumnProperties("fechainicio_ensayopnt")]
        public DateTime FechaInicio { get; set; }

        [ColumnProperties("fechafin_ensayopnt")]
        public DateTime FechaFin { get; set; }
    }
}
