using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase
{
    public class eje3 {
    
  public String Estados(String opcion, String nombre)
        {
            if (opcion == "VERDE")
                return "ADELANTE" + " " + nombre;
            else if (opcion == "AMARILLO")
                return "PRECAUCION" + " " + nombre;
            else if (opcion == "ROJO")
                return "ALTO" + " " + nombre;
            else return "INGRESE UNA OPCION VALIDA";


        }

    }
}

