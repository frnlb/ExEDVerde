using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenVerde
{
    public class Cliente
    {




        /// <summary>
        /// Atributos de la clase Cliente
        /// </summary>
        private string nombre;
        private string dni;
        private double saldo;

        public double Saldo { get => saldo; set => saldo = value; }

        public Cliente(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            saldo = 100;
        }

        public Cliente()
        {
            saldo = 100;
        }

        public void RestaSaldo(double saldoNuevo)
        {
            saldo -= saldoNuevo;
        }


        /// <summary>
        /// Método para sumar saldo. No devuelve nada
        /// </summary>
        /// <param name="saldonuevo"></param>
        public void SumaSaldo(double saldonuevo)
        {
            saldo += saldonuevo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Devuelve un string con un mensaje de si el saldo es poditivo o negativo</returns>
        public string PositivoNegativo()
        {
            string mensaje;

            if (saldo >= 0)
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

