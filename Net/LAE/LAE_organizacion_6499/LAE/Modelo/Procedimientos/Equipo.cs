﻿using LAE.Comun.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAE.Modelo
{
    public class FactoriaEquipos
    {
        public static Equipo[] GetEquipoByTipo(String tipo)
        {
            int idTipo = PersistenceManager.SelectByProperty<TipoEquipo>("Nombre", tipo, null, "Id").FirstOrDefault()?.Id ?? 0;
            return PersistenceManager.SelectByProperty<Equipo>("IdTipo", idTipo).ToArray();
        }
    }

    [TableProperties("equipos")]
    public class Equipo : PersistenceData
    {
        [ColumnProperties("id_equipo", IsId = true, IsAutonumeric = true)]
        public int Id { get; set; }

        [ColumnProperties("nombre_equipo")]
        public String Nombre { get; set; }

        [ColumnProperties("idtipo_equipo")]
        public int IdTipo { get; set; }

        public bool Predefinido { get; set; }
    }
}