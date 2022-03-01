using AppWhatsApp.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppWhatsApp
{
    public partial class MainPage : TabbedPage
    {
        public List<Contactos> ListaChats { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Contactos p1 = new Contactos
            {
                Nombre = "Cristian Marquez",
                Chat = "Hola, hace hambre!!!",
                Img = "foto.png",
                Horachat = "01:52 p. m.",
                Horallamada = "Ayer 5:18 p. m.",
                EstadoContacto = "Hoy 11:55 a.m",
                Call = "videocall.png"
            };

            Contactos p2 = new Contactos
            {
                Nombre = "Nataly Betancur",
                Chat = "Hola, ¿cómo estás?",
                Img = "girl.jpg",
                Horachat = "11:19 a. m.",
                Horallamada = "Ayer 9:23 a. m.",
                EstadoContacto = "Hoy 12:55 a. m.",
                Call = "voicecall.png"
            };



            ListaChats = new List<Contactos>();
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2); 
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2); 
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2);
            ListaChats.Add(p1);
            ListaChats.Add(p2);


            this.BindingContext = this;


        }
    }
}
