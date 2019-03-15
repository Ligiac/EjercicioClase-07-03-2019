using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase
{
   public  class eje1
   {
       public String Estados(String opcion)
       {
           if (opcion == "VERDE")
               return "ADELANTE";
           else if (opcion == "AMARILLO")
               return "PRECAUCION";
           else if (opcion == "ROJO")
               return "ALTO";
           else return "INGRESE UNA OPCION VALIDA";


       }
   }


}
    

