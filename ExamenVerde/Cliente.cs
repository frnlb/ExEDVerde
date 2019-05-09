using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenVerde
{
    class Cliente
    {




        /// <summary>
        /// Atributos de la clase Cliente
        /// </summary>
        private string nombre;
        private string dni;
        private double saldo = 100;




        public Cliente(string nombre,string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            saldo = 100;
        }
        public Cliente()
        {

        }

        public void RestaSaldo(double saldoNuevo)
        {
            saldo -= saldoNuevo;
        }


        
        public static void SumaSaldo(double saldonuevo)
        {
            saldo += saldonuevo;
        }
        

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
