using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibro.Capitulo_9
{
    class Nodo
    {
            public string Nombre_Departamento { get; set; }
            public string Nombre_Piso { get; set; }
            public Nodo sigte;
            public Nodo(string Nombre_Piso, string NNombre_Departamento)
            {
                this.Nombre_Departamento = Nombre_Departamento;
                this.Nombre_Piso = Nombre_Piso;
                this.sigte = null;

            }
    }
}
