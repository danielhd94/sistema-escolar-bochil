﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocios
{
    public class NGrupo
    {
        public static DataTable Mostrar()
        {
            return new DGrupo().Mostrar();
        }
    }
}
