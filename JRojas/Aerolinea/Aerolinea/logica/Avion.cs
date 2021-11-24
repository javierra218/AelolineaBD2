using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.datos;

namespace Aerolinea.logica
{
    class Avion
    {
        Datos dt = new Datos();
        //recibe el codigo que se envio desde la interfaz
        public DataSet CONSULTARAVIONES(int nitEmpresa)
        {

            DataSet conjuntoAviones = new DataSet();
            conjuntoAviones = dt.CONSULTARAVIONES(nitEmpresa);
            return conjuntoAviones;
        }

        public bool insertarAvion(int nitEmpresa, string serial, string marca, string tipo, float longitud, string pais, string fecha)
        {
            bool respuesta = false;
            respuesta = dt.insertarAvion(nitEmpresa, serial, marca, tipo, longitud, pais, fecha);
            return respuesta;
        }
        public bool eliminarAvion(string serial)
        {
            bool respuesta = false;
            respuesta = dt.eliminarAvion(serial);
            return respuesta;
        }





    }
}

