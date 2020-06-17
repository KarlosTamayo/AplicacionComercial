using Login.DS.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Login.DS.DSAplicacionComercial;

namespace Login.DS
{
    public class CADCliente
    {
        private static ClienteTableAdapter adapter = new ClienteTableAdapter();

        public static ClienteDataTable GetData()
        {
            return adapter.GetData();

        }

        public static void i(int IDTipoDocumento, string Documento, string NombreComercial, string 
            NombresContacto, string ApellidosContacto, string Direccion, string 
            Telefono1, string Telefono2, string Correo, string Notas, DateTime Aniversario)
        { 
         adapter.InsertClientes(IDTipoDocumento, Documento, NombreComercial, NombresContacto,
                ApellidosContacto, Direccion, Telefono1, Telefono2, Correo, Notas, Aniversario);
        }

    }




}
 
    


