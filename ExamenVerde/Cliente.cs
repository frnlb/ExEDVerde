using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenVerde
{
    class Cliente
    {
        public string PositivoNegativo()
        {
            string mensaje;

            if(saldo >= 0)
            {
                mensaje = "Positivo";
                return mensaje;
            }
            else
            {
                mensaje = "Negativo";
                return mensaje;
            }
        }
    }
}
