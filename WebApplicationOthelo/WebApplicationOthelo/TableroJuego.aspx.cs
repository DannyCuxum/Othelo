﻿using System;
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


namespace WebApplicationOthelo
{
    public partial class TableroJuego : System.Web.UI.Page
    {

        public static int JUGADOR = 1;
        public int[,] Ficha = new int[8, 8];
        public Button[,] botones = new Button[8, 8];


        public static bool FichaNegra = false;
        public static bool FichaBlanca = true;
        public static string columna;
        public static string fila;
        public static string color;
        public static string tiro;
        public static int contador = 0;
        public ArrayList ArFila = new ArrayList();
        public ArrayList arrayColumna = new ArrayList();
        public ArrayList arrayColor = new ArrayList();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void obtenerValores(string color, string col, string fil)
        {

            string coordenada = col + "-" + fil;
            //para A
            if (coordenada == "A-1")
            {
                if (color == "blanco")
                {
                    BtnA1.BackColor = Color.White;
                }
                else
                {
                    BtnA1.BackColor = Color.Black;
                }
            }

            if (coordenada == "A-2")
            {
                if (color == "blanco")
                {
                    BtnA2.BackColor = Color.White;
                }
                else
                {
                    BtnA2.BackColor = Color.Black;
                }
            }

            if (coordenada == "A-3")
            {
                if (color == "blanco")
                {
                    BtnA3.BackColor = Color.White;
                }
                else
                {
                    BtnA3.BackColor = Color.Black;
                }
            }
            if (coordenada == "A-4")
            {
                if (color == "blanco")
                {
                    BtnA4.BackColor = Color.White;
                }
                else
                {
                    BtnA4.BackColor = Color.Black;
                }
            }
            if (coordenada == "A-5")
            {
                if (color == "blanco")
                {
                    BtnA5.BackColor = Color.White;
                }
                else
                {
                    BtnA5.BackColor = Color.Black;
                }
            }
            if (coordenada == "A-6")
            {
                if (color == "blanco")
                {
                    BtnA6.BackColor = Color.White;
                }
                else
                {
                    BtnA6.BackColor = Color.Black;
                }
            }
            if (coordenada == "A-7")
            {
                if (color == "blanco")
                {
                    BtnA7.BackColor = Color.White;
                }
                else
                {
                    BtnA7.BackColor = Color.Black;
                }
            }
            if (coordenada == "A-8")
            {
                if (color == "blanco")
                {
                    BtnA8.BackColor = Color.White;
                }
                else
                {
                    BtnA8.BackColor = Color.Black;
                }
            }

            //para B
            if (coordenada == "B-1")
            {
                if (color == "blanco")
                {
                    BtnB1.BackColor = Color.White;
                }
                else
                {
                    BtnB1.BackColor = Color.Black;
                }
            }

            if (coordenada == "B-2")
            {
                if (color == "blanco")
                {
                    BtnB2.BackColor = Color.White;
                }
                else
                {
                    BtnB2.BackColor = Color.Black;
                }
            }

            if (coordenada == "B-3")
            {
                if (color == "blanco")
                {
                    BtnB3.BackColor = Color.White;
                }
                else
                {
                    BtnB3.BackColor = Color.Black;
                }
            }
            if (coordenada == "B-4")
            {
                if (color == "blanco")
                {
                    BtnB4.BackColor = Color.White;
                }
                else
                {
                    BtnB4.BackColor = Color.Black;
                }
            }
            if (coordenada == "B-5")
            {
                if (color == "blanco")
                {
                    BtnB5.BackColor = Color.White;
                }
                else
                {
                    BtnB5.BackColor = Color.Black;
                }
            }
            if (coordenada == "B-6")
            {
                if (color == "blanco")
                {
                    BtnB6.BackColor = Color.White;
                }
                else
                {
                    BtnB6.BackColor = Color.Black;
                }
            }
            if (coordenada == "B-7")
            {
                if (color == "blanco")
                {
                    BtnB7.BackColor = Color.White;
                }
                else
                {
                    BtnB7.BackColor = Color.Black;
                }
            }
            if (coordenada == "B-8")
            {
                if (color == "blanco")
                {
                    BtnB8.BackColor = Color.White;
                }
                else
                {
                    BtnB8.BackColor = Color.Black;
                }
            }

            //para C
            if (coordenada == "C-1")
            {
                if (color == "blanco")
                {
                    BtnC1.BackColor = Color.White;
                }
                else
                {
                    BtnC1.BackColor = Color.Black;
                }
            }

            if (coordenada == "C-2")
            {
                if (color == "blanco")
                {
                    BtnC2.BackColor = Color.White;
                }
                else
                {
                    BtnC2.BackColor = Color.Black;
                }
            }

            if (coordenada == "C-3")
            {
                if (color == "blanco")
                {
                    BtnC3.BackColor = Color.White;
                }
                else
                {
                    BtnC3.BackColor = Color.Black;
                }
            }
            if (coordenada == "C-4")
            {
                if (color == "blanco")
                {
                    BtnC4.BackColor = Color.White;
                }
                else
                {
                    BtnC4.BackColor = Color.Black;
                }
            }
            if (coordenada == "C-5")
            {
                if (color == "blanco")
                {
                    BtnC5.BackColor = Color.White;
                }
                else
                {
                    BtnC5.BackColor = Color.Black;
                }
            }
            if (coordenada == "C-6")
            {
                if (color == "blanco")
                {
                    BtnC6.BackColor = Color.White;
                }
                else
                {
                    BtnC6.BackColor = Color.Black;
                }
            }
            if (coordenada == "C-7")
            {
                if (color == "blanco")
                {
                    BtnC7.BackColor = Color.White;
                }
                else
                {
                    BtnC7.BackColor = Color.Black;
                }
            }
            if (coordenada == "C-8")
            {
                if (color == "blanco")
                {
                    BtnC8.BackColor = Color.White;
                }
                else
                {
                    BtnC8.BackColor = Color.Black;
                }
            }

            //para D
            if (coordenada == "D-1")
            {
                if (color == "blanco")
                {
                    BtnD1.BackColor = Color.White;
                }
                else
                {
                    BtnD1.BackColor = Color.Black;
                }
            }

            if (coordenada == "D-2")
            {
                if (color == "blanco")
                {
                    BtnD2.BackColor = Color.White;
                }
                else
                {
                    BtnD2.BackColor = Color.Black;
                }
            }

            if (coordenada == "D-3")
            {
                if (color == "blanco")
                {
                    BtnD3.BackColor = Color.White;
                }
                else
                {
                    BtnD3.BackColor = Color.Black;
                }
            }
            if (coordenada == "D-4")
            {
                if (color == "blanco")
                {
                    BtnD4.BackColor = Color.White;
                }
                else
                {
                    BtnD4.BackColor = Color.Black;
                }
            }
            if (coordenada == "D-5")
            {
                if (color == "blanco")
                {
                    BtnD5.BackColor = Color.White;
                }
                else
                {
                    BtnD5.BackColor = Color.Black;
                }
            }
            if (coordenada == "D-6")
            {
                if (color == "blanco")
                {
                    BtnD6.BackColor = Color.White;
                }
                else
                {
                    BtnD6.BackColor = Color.Black;
                }
            }
            if (coordenada == "D-7")
            {
                if (color == "blanco")
                {
                    BtnD7.BackColor = Color.White;
                }
                else
                {
                    BtnD7.BackColor = Color.Black;
                }
            }
            if (coordenada == "D-8")
            {
                if (color == "blanco")
                {
                    BtnD8.BackColor = Color.White;
                }
                else
                {
                    BtnD8.BackColor = Color.Black;
                }
            }

            //para E
            if (coordenada == "E-1")
            {
                if (color == "blanco")
                {
                    BtnE1.BackColor = Color.White;
                }
                else
                {
                    BtnE1.BackColor = Color.Black;
                }
            }

            if (coordenada == "E-2")
            {
                if (color == "blanco")
                {
                    BtnE2.BackColor = Color.White;
                }
                else
                {
                    BtnE2.BackColor = Color.Black;
                }
            }

            if (coordenada == "E-3")
            {
                if (color == "blanco")
                {
                    BtnE3.BackColor = Color.White;
                }
                else
                {
                    BtnE3.BackColor = Color.Black;
                }
            }
            if (coordenada == "E-4")
            {
                if (color == "blanco")
                {
                    BtnE4.BackColor = Color.White;
                }
                else
                {
                    BtnE4.BackColor = Color.Black;
                }
            }
            if (coordenada == "E-5")
            {
                if (color == "blanco")
                {
                    BtnE5.BackColor = Color.White;
                }
                else
                {
                    BtnE5.BackColor = Color.Black;
                }
            }
            if (coordenada == "E-6")
            {
                if (color == "blanco")
                {
                    BtnE6.BackColor = Color.White;
                }
                else
                {
                    BtnE6.BackColor = Color.Black;
                }
            }
            if (coordenada == "E-7")
            {
                if (color == "blanco")
                {
                    BtnE7.BackColor = Color.White;
                }
                else
                {
                    BtnE7.BackColor = Color.Black;
                }
            }
            if (coordenada == "E-8")
            {
                if (color == "blanco")
                {
                    BtnE8.BackColor = Color.White;
                }
                else
                {
                    BtnE8.BackColor = Color.Black;
                }
            }

            //para F
            if (coordenada == "F-1")
            {
                if (color == "blanco")
                {
                    BtnF1.BackColor = Color.White;
                }
                else
                {
                    BtnF1.BackColor = Color.Black;
                }
            }

            if (coordenada == "F-2")
            {
                if (color == "blanco")
                {
                    BtnF2.BackColor = Color.White;
                }
                else
                {
                    BtnF2.BackColor = Color.Black;
                }
            }

            if (coordenada == "F-3")
            {
                if (color == "blanco")
                {
                    BtnF3.BackColor = Color.White;
                }
                else
                {
                    BtnF3.BackColor = Color.Black;
                }
            }
            if (coordenada == "F-4")
            {
                if (color == "blanco")
                {
                    BtnF4.BackColor = Color.White;
                }
                else
                {
                    BtnF4.BackColor = Color.Black;
                }
            }
            if (coordenada == "F-5")
            {
                if (color == "blanco")
                {
                    BtnF5.BackColor = Color.White;
                }
                else
                {
                    BtnF5.BackColor = Color.Black;
                }
            }
            if (coordenada == "F-6")
            {
                if (color == "blanco")
                {
                    BtnF6.BackColor = Color.White;
                }
                else
                {
                    BtnF6.BackColor = Color.Black;
                }
            }
            if (coordenada == "F-7")
            {
                if (color == "blanco")
                {
                    BtnF7.BackColor = Color.White;
                }
                else
                {
                    BtnF7.BackColor = Color.Black;
                }
            }
            if (coordenada == "F-8")
            {
                if (color == "blanco")
                {
                    BtnF8.BackColor = Color.White;
                }
                else
                {
                    BtnF8.BackColor = Color.Black;

                }
            }

            //para G
            if (coordenada == "G-1")
            {
                if (color == "blanco")
                {
                    BtnG1.BackColor = Color.White;
                }
                else
                {
                    BtnG1.BackColor = Color.Black;
                }
            }

            if (coordenada == "G-2")
            {
                if (color == "blanco")
                {
                    BtnG2.BackColor = Color.White;
                }
                else
                {
                    BtnG2.BackColor = Color.Black;
                }
            }

            if (coordenada == "G-3")
            {
                if (color == "blanco")
                {
                    BtnG3.BackColor = Color.White;
                }
                else
                {
                    BtnG3.BackColor = Color.Black;
                }
            }
            if (coordenada == "G-4")
            {
                if (color == "blanco")
                {
                    BtnG4.BackColor = Color.White;
                }
                else
                {
                    BtnG4.BackColor = Color.Black;
                }
            }
            if (coordenada == "G-5")
            {
                if (color == "blanco")
                {
                    BtnG5.BackColor = Color.White;
                }
                else
                {
                    BtnG5.BackColor = Color.Black;
                }
            }
            if (coordenada == "G-6")
            {
                if (color == "blanco")
                {
                    BtnG6.BackColor = Color.White;
                }
                else
                {
                    BtnG6.BackColor = Color.Black;
                }
            }
            if (coordenada == "G-7")
            {
                if (color == "blanco")
                {
                    BtnG7.BackColor = Color.White;
                }
                else
                {
                    BtnG7.BackColor = Color.Black;
                }
            }
            if (coordenada == "G-8")
            {
                if (color == "blanco")
                {
                    BtnG8.BackColor = Color.White;
                }
                else
                {
                    BtnG8.BackColor = Color.Black;

                }
            }
            //para H
            if (coordenada == "H-1")
            {
                if (color == "blanco")
                {
                    BtnH1.BackColor = Color.White;
                }
                else
                {
                    BtnH1.BackColor = Color.Black;
                }
            }

            if (coordenada == "H-2")
            {
                if (color == "blanco")
                {
                    BtnH2.BackColor = Color.White;
                }
                else
                {
                    BtnH2.BackColor = Color.Black;
                }
            }

            if (coordenada == "H-3")
            {
                if (color == "blanco")
                {
                    BtnH3.BackColor = Color.White;
                }
                else
                {
                    BtnH3.BackColor = Color.Black;
                }
            }
            if (coordenada == "H-4")
            {
                if (color == "blanco")
                {
                    BtnH4.BackColor = Color.White;
                }
                else
                {
                    BtnH4.BackColor = Color.Black;
                }
            }
            if (coordenada == "H-5")
            {
                if (color == "blanco")
                {
                    BtnH5.BackColor = Color.White;
                }
                else
                {
                    BtnH5.BackColor = Color.Black;
                }
            }
            if (coordenada == "H-6")
            {
                if (color == "blanco")
                {
                    BtnH6.BackColor = Color.White;
                }
                else
                {
                    BtnH6.BackColor = Color.Black;
                }
            }
            if (coordenada == "H-7")
            {
                if (color == "blanco")
                {
                    BtnH7.BackColor = Color.White;
                }
                else
                {
                    BtnH7.BackColor = Color.Black;
                }
            }
            if (coordenada == "H-8")
            {
                if (color == "blanco")
                {
                    BtnH8.BackColor = Color.White;
                }
                else
                {
                    BtnH8.BackColor = Color.Black;

                }
            }

        }


        protected void ButtonCargar_Click(object sender, EventArgs e)
        {
            string ruta = TextBoxCarga.Text;

            XmlReader lector = XmlReader.Create(ruta);
            while (lector.Read())
            {
                if (lector.IsStartElement())
                {
                    contador += 1;
                    switch (lector.Name.ToString())
                    {


                        case "color":
                            color = lector.ReadString();
                            if (color == "blanco")
                            {

                                FichaBlanca = false;
                                FichaNegra = true;
                            }
                            else if (color == "negro")
                            {

                                FichaNegra = false;
                                FichaBlanca = true;
                            }
                            break;
                        case "columna":
                            columna = lector.ReadString();

                            break;
                        case "fila":
                            fila = lector.ReadString();

                            break;

                    }
                    if (contador == 3)
                    {
                        obtenerValores(color, columna, fila);
                        contador = 0;
                    }

                }
            }


        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            recorrerCuadros();


            XmlDocument doc = new XmlDocument();
            XmlElement raiz = doc.CreateElement("tablero");
            doc.AppendChild(raiz);
            for (int i = 0; i < arrayColor.Count; i++)
            {


                XmlElement ficha = doc.CreateElement("ficha");
                raiz.AppendChild(ficha);

                XmlElement color = doc.CreateElement("color");
                color.AppendChild(doc.CreateTextNode(arrayColor[i].ToString()));
                ficha.AppendChild(color);

                XmlElement columna = doc.CreateElement("columna");
                columna.AppendChild(doc.CreateTextNode(arrayColumna[i].ToString()));
                ficha.AppendChild(columna);

                XmlElement fila = doc.CreateElement("fila");
                fila.AppendChild(doc.CreateTextNode(ArFila[i].ToString()));
                ficha.AppendChild(fila);
            }
            doc.Save("D:\\documentos\\documentos\\segundo semestre\\Programacion\\fase II\\ArchivosXml\\PartidaGuardad.xml");
        }

        protected void ButtonSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("OpcionesTipoPartida.aspx");
        }
        public void recorrerCuadros()
        {
            int opcion;

            for (opcion = 1; opcion <= 64; opcion++)
            {

                switch (opcion)
                {
                    case 1:
                        if (BtnA1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("1");

                        }
                        else if (BtnA1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("1");
                        }
                        break;

                    case 2:
                        if (BtnA2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("2");

                        }
                        else if (BtnA2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("2");
                        }
                        break;
                    case 3:
                        if (BtnA3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("3");

                        }
                        else if (BtnA3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("3");
                        }
                        break;
                    case 4:
                        if (BtnA4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("4");

                        }
                        else if (BtnA4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("4");
                        }

                        break;
                    case 5:
                        if (BtnA5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("5");

                        }
                        else if (BtnA5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("5");
                        }

                        break;
                    case 6:
                        if (BtnA6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("6");

                        }
                        else if (BtnA6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("6");
                        }

                        break;
                    case 7:
                        if (BtnA7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("7");

                        }
                        else if (BtnA7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("7");
                        }
                        break;
                    case 8:
                        if (BtnA8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("A");
                            ArFila.Add("8");

                        }
                        else if (BtnA8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("A");
                            ArFila.Add("8");
                        }

                        break;
                    case 9:
                        if (BtnB1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("1");

                        }
                        else if (BtnB1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("1");
                        }
                        break;
                    case 10:
                        if (BtnB2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("2");

                        }
                        else if (BtnB2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("2");
                        }
                        break;
                    case 11:
                        if (BtnB3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("3");

                        }
                        else if (BtnB3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("3");
                        }

                        break;
                    case 12:
                        if (BtnB4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("4");

                        }
                        else if (BtnB4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("4");
                        }
                        break;
                    case 13:
                        if (BtnB5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("5");

                        }
                        else if (BtnB5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("5");
                        }
                        break;
                    case 14:
                        if (BtnB6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("6");

                        }
                        else if (BtnB6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("6");
                        }
                        break;

                    case 15:
                        if (BtnB7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("7");

                        }
                        else if (BtnB7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("7");
                        }
                        break;
                    case 16:
                        if (BtnB8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("B");
                            ArFila.Add("8");

                        }
                        else if (BtnB8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("B");
                            ArFila.Add("8");
                        }

                        break;
                    case 17:
                        if (BtnC1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("1");

                        }
                        else if (BtnC1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("1");
                        }

                        break;
                    case 18:
                        if (BtnC2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("2");

                        }
                        else if (BtnC2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("2");
                        }
                        break;
                    case 19:
                        if (BtnC3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("3");

                        }
                        else if (BtnC3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("3");
                        }
                        break;
                    case 20:
                        if (BtnC4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("4");

                        }
                        else if (BtnC4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("4");
                        }
                        break;
                    case 21:
                        if (BtnC5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("5");

                        }
                        else if (BtnC5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("5");
                        }
                        break;

                    case 22:
                        if (BtnC6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("6");

                        }
                        else if (BtnC6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("6");
                        }
                        break;
                    case 23:
                        if (BtnC7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("7");

                        }
                        else if (BtnC7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("7");
                        }
                        break;
                    case 24:
                        if (BtnC8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("C");
                            ArFila.Add("8");

                        }
                        else if (BtnC8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("C");
                            ArFila.Add("8");
                        }

                        break;
                    case 25:
                        if (BtnD1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("1");

                        }
                        else if (BtnD1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("1");
                        }
                        break;
                    case 26:
                        if (BtnD2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("2");

                        }
                        else if (BtnD2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("2");
                        }
                        break;
                    case 27:
                        if (BtnD3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("3");

                        }
                        else if (BtnD3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("3");
                        }
                        break;
                    case 28:
                        if (BtnD4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("4");

                        }
                        else if (BtnD4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("4");
                        }
                        break;
                    case 29:
                        if (BtnD5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("5");

                        }
                        else if (BtnD5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("5");
                        }
                        break;
                    case 30:
                        if (BtnD6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("6");

                        }
                        else if (BtnD6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("6");
                        }
                        break;
                    case 31:
                        if (BtnD7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("7");

                        }
                        else if (BtnD7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("7");
                        }
                        break;

                    case 32:
                        if (BtnD8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("D");
                            ArFila.Add("8");

                        }
                        else if (BtnD8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("D");
                            ArFila.Add("8");
                        }
                        break;
                    case 33:
                        if (BtnE1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("1");

                        }
                        else if (BtnE1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("1");
                        }
                        break;
                    case 34:
                        if (BtnE2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("2");

                        }
                        else if (BtnE2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("2");
                        }
                        break;
                    case 35:
                        if (BtnE3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("3");

                        }
                        else if (BtnE3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("3");
                        }

                        break;
                    case 36:
                        if (BtnE4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("4");

                        }
                        else if (BtnE4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("4");
                        }
                        break;
                    case 37:
                        if (BtnE5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("5");

                        }
                        else if (BtnE5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("5");
                        }
                        break;
                    case 38:
                        if (BtnE6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("6");

                        }
                        else if (BtnE6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("6");
                        }

                        break;
                    case 39:
                        if (BtnE7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("7");

                        }
                        else if (BtnE7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("7");
                        }
                        break;
                    case 40:
                        if (BtnE8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("E");
                            ArFila.Add("8");

                        }
                        else if (BtnE8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("E");
                            ArFila.Add("8");
                        }
                        break;
                    case 41:
                        if (BtnF1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("1");

                        }
                        else if (BtnF1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("1");
                        }
                        break;

                    case 42:
                        if (BtnF2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("2");

                        }
                        else if (BtnF2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("2");
                        }
                        break;
                    case 43:
                        if (BtnF3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("3");

                        }
                        else if (BtnF3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("3");
                        }
                        break;
                    case 44:
                        if (BtnF4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("4");

                        }
                        else if (BtnF4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("4");
                        }

                        break;
                    case 45:
                        if (BtnF5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("5");

                        }
                        else if (BtnF5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("5");
                        }

                        break;
                    case 46:
                        if (BtnF6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("6");

                        }
                        else if (BtnF6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("6");
                        }
                        break;
                    case 47:
                        if (BtnF7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("7");

                        }
                        else if (BtnF7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("7");
                        }
                        break;
                    case 48:
                        if (BtnF8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("F");
                            ArFila.Add("8");

                        }
                        else if (BtnF8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("F");
                            ArFila.Add("8");
                        }
                        break;
                    case 49:
                        if (BtnG1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("1");

                        }
                        else if (BtnG1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("1");
                        }

                        break;
                    case 50:
                        if (BtnG2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("2");

                        }
                        else if (BtnG2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("2");
                        }
                        break;
                    case 51:
                        if (BtnG3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("3");

                        }
                        else if (BtnG3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("3");
                        }

                        break;

                    case 52:
                        if (BtnG4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("4");

                        }
                        else if (BtnG4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("4");
                        }
                        break;
                    case 53:
                        if (BtnG5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("5");

                        }
                        else if (BtnG5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("5");
                        }

                        break;
                    case 54:
                        if (BtnG6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("6");

                        }
                        else if (BtnG6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("6");
                        }

                        break;
                    case 55:
                        if (BtnG7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("7");

                        }
                        else if (BtnG7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("7");
                        }
                        break;
                    case 56:
                        if (BtnG8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("G");
                            ArFila.Add("8");

                        }
                        else if (BtnG8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("G");
                            ArFila.Add("8");
                        }
                        break;
                    case 57:
                        if (BtnH1.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("1");

                        }
                        else if (BtnH1.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("1");
                        }
                        break;
                    case 58:
                        if (BtnH2.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("2");

                        }
                        else if (BtnH2.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("2");
                        }
                        break;
                    case 59:
                        if (BtnH3.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("3");

                        }
                        else if (BtnH3.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("3");
                        }

                        break;
                    case 60:
                        if (BtnH4.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("4");

                        }
                        else if (BtnH4.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("4");
                        }
                        break;
                    case 61:
                        if (BtnH5.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("5");

                        }
                        else if (BtnH5.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("5");
                        }

                        break;

                    case 62:
                        if (BtnH6.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("6");

                        }
                        else if (BtnH6.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("6");
                        }
                        break;
                    case 63:
                        if (BtnH7.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("7");

                        }
                        else if (BtnH7.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("7");
                        }
                        break;
                    case 64:
                        if (BtnH8.BackColor == Color.White)
                        {
                            arrayColor.Add("blanco");
                            arrayColumna.Add("H");
                            ArFila.Add("8");

                        }
                        else if (BtnH8.BackColor == Color.Black)
                        {
                            arrayColor.Add("negro");
                            arrayColumna.Add("H");
                            ArFila.Add("8");
                        }
                        break;



                }
            }
        }

        protected void BtnA1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnA2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnA3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }

        }

        protected void BtnA4_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA4.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA4.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnA5_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA5.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA5.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnA6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnA7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnA8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnA8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnA8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB4_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB4.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB4.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB5_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB5.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB5.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnB8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnB8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnB8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC4_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC4.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC4.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC5_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC5.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC5.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnC8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnC8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnC8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnD1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnD1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnD1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnD2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnD2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnD2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnD3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnD3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnD3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnD6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnD6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnD6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnD7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnD7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnD7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnD8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnD8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnD8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnE1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnE1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnE1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnE2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnE2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnE2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnE3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnE3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnE3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnE6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnE6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnE6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnE7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnE7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnE7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnE8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnE8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnE8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF4_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF4.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF4.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF5_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF5.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF5.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnF8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnF8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnF8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG4_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG4.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG4.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG5_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG5.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG5.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnG8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnG8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnG8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH1_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH1.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH1.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH2_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH2.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH2.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH3_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH3.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH3.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH4_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH4.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH4.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH5_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH5.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH5.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH6_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH6.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH6.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH7_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH7.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH7.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }

        protected void BtnH8_Click(object sender, EventArgs e)
        {
            if (FichaBlanca == true)
            {
                BtnH8.BackColor = Color.White;


                FichaBlanca = false;
                FichaNegra = true;
            }
            else if (FichaNegra == true)
            {
                BtnH8.BackColor = Color.Black;

                FichaNegra = false;
                FichaBlanca = true;
            }
        }
    }
}