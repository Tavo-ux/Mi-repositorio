using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cliente
    {
        private string _strNombreCliente;
        public string NombreCliente
        {
            get { return _strNombreCliente; }
            set { _strNombreCliente = value; }
        }
        private string _strNumeroTel;
        public string NumeroTel
        {
            get { return _strNumeroTel; }
            set { _strNumeroTel = value;}
        }
        private string _strCorreoElectronico;
        public string CorreoElectronico
        {
            get { return _strCorreoElectronico; }
            set { _strCorreoElectronico = value;}
        }

    }
}
