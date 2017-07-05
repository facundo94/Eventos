using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoSueldo();
    public delegate void DelSueldoMejorado(object o, EventArgs e);

    public class Empleado
    {
        public string nombre;
        public string apellido;
        public int legajo;
        private double _sueldo;
        public event DelegadoSueldo SueldoEvent;
        public event DelSueldoMejorado SueldoMejorado;

        public double Sueldo
        {
            get { return this._sueldo; }
            set 
            {
                if (value < 0)
                    throw new Exception("El sueldo no puedo ser un valor negativo.");
                else if (value > 20000)
                    this.SueldoMejorado(this, new EventArgs());//(el objeto donde se produce el evento, informacion del evento)
                else if (value > 9500)
                    this.SueldoEvent();
                

                this._sueldo = value;
            }
        }

        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo.ToString());
            sb.AppendLine("Sueldo: " + this._sueldo.ToString());

            return sb.ToString();
        }

    }
}
