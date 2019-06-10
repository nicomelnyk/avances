using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.LoginYSeguridad
{
    class EntidadUsuario
    {   
        public String USERNAME {get ; set;}
	    public String PASSWORD {get ; set;}
	    public int INTENTOS_FALLIDOS {get ; set;}
	    public String NOMBRE_ROL {get ; set;}
	    public char ESTADO_ADMIN {get ; set;}
    }
}
