﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Parameters
{
    public class GetAllClientesParameters : RequestParameter
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
