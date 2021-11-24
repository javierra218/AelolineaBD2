using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.datos;

namespace Aerolinea.logica
{
    class Empresa
    {

        Datos dt = new Datos();

        public bool insertarEmpresa(int nitEmpresa, string nombre, string fechaCreacion)
        {
            bool respuesta = false;
            respuesta = dt.insertarEmpresa(nitEmpresa, nombre, fechaCreacion);
            return respuesta;
        }

        
    }
}