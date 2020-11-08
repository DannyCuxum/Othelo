using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Drawing;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace WebApplicationOthelo
{
    public partial class FormularioFinal : System.Web.UI.Page
    {

        // se mejora la captura de movimientos en xtreme
        //para monstrar los movimiento se usar bool
        public static bool usuarioBlanco = false;
        // se logra visualizar los colores recorridos





            /*
             * 
             * 
             * 
             * 
             * 
             * **/

        public static bool usuarioNegro = false;
        //posiciones
        public static int posicionNegra = 1;
        public static int posicionBlanca = 1;

        //movimientos
        public static int movimientoGeneral = 0;
        public static int movimientoB = 0;
        public static int movimientoN = 0;
        public static string estadoPartida = "";
        public static int bloquesN = 0;
        public static int bloquesB = 0;

        public static bool sigo = true;
        public static int contadorEspacio = 0;
        public static bool activacionMaqina = false;
        public static bool banderaNegra = false; // false para el negro, al inicio no se ha seleccionado nada xd
        public static bool banderaBlanca = false; // false para el blanco
        public static bool banderaFicha = false;
        public static bool banderaTiro = false;
        public static bool banderaGeneral = true;

        public static string columna;
        public static string fila;
        public static string color;
        public static string colorTiro;
        public static int contador = 0;
        public ArrayList arrayFila = new ArrayList();
        public ArrayList arrayColumna = new ArrayList();
        public ArrayList arrayColor = new ArrayList();
        public static string[,] tablero = new string[8, 8];
        public static Button[,] tableroColor = new Button[8, 8];
        protected void Page_Load(object sender, EventArgs e)
        {
            //SE GENERA LA BASE DE DATO CORREGIDA

            /// se genera cambios a los form para ajustarse a la calificacion
            /// no  se establece xml
            /// se establece todo los modos del xtream
            /// Se logra establces conexion con base de datos
        }
    }
}