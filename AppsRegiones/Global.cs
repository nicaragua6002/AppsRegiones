using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppsRegiones
{
    class Global
    {
        //defir las listas con sus valores
        public static List<Region> Regiones = new List<Region>()
        {
            new Region(1,"Pacífico","Esta zona está formada por una planicie ancha y llena de volcanes, y se caracteriza por un clima caluroso.E")
            , new Region(2,"Norte y centro"," Esta región se caracteriza por tener unas altas montañas y frondosos valles.")
            , new Region(3,"La región del Caribe","Esta es la zona menos poblada de Nicaragua y todavía es difícil acceder a ella, a pesar de que ocupa más de la mitad del territorio del país.")
        };

        public static List<Departamento> Departamentos = new List<Departamento>()
        {
           
           new Departamento(1,"Boaco","NI-BO","Boaco",174682,4177,decimal.Parse("41.8"),1)
            ,new Departamento(2,"Chinandega","NI-CI","Chinandega",432062,4822,decimal.Parse("87.7"),1)
            ,new Departamento(3,"Estelí","NI-ES","Estelí",201548,2230,90,2)
            ,new Departamento(4,"Granada","NI-GR","Granada",168186,1040,162,1)
            ,new Departamento(5,"Jinotega","NI-JI","Jinotega",331335,9222,36,2)
            ,new Departamento(6,"Carazo","NI-CA","Jinotepe",186898,1081,decimal.Parse("172.8"),1)
            ,new Departamento(7,"Chontales","NI-CO","Juigalpa",153932,6481,24,2)
            ,new Departamento(8,"León","NI-LE","León",355779,5138,69,1)
            ,new Departamento(9,"Madriz","NI-MD","Somoto",132459,1708,78,2)
            ,new Departamento(10,"Managua","NI-MN","Managua",2132421,3465,365,1)
            ,new Departamento(11,"Masaya","NI-MS","Masaya",289988,611,475,1)
            ,new Departamento(12,"Matagalpa","NI-MT","Matagalpa",469172,6804,69,2)
            ,new Departamento(13,"Nueva Segovia","NI-NS","Ocotal",208523,3491,60,2)
            ,new Departamento(14,"Costa Caribe Sur","NI-CS","Bluefields",306510,27260,11,3)
            ,new Departamento(15,"Costa Caribe Norte","NI-CN","Puerto Cabezas",31430,33106,10,3)
            ,new Departamento(16,"Rivas","NI-RI","Rivas",15683,2162,72,1)
            ,new Departamento(17,"Río San Juan","NI-SJ","San Carlos",95596,7541,13,2)


    };


          	 			
  


    }

    //Definir las estructuras, clases

    public class Region
    {
        //campos
        int id;
        string nombre;
        string descripcion;

        //constructor
        public Region(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        //propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }

    public class Departamento
    {
        int id;
        string nombre;
        string iso;
        string cabecera;
        decimal poblacion;
        decimal area;
        decimal densidad;
        int idRegion;

        public Departamento(int id, string nombre, string iso, string cabecera, decimal poblacion, decimal area, decimal densidad, int idRegion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Iso = iso;
            this.Cabecera = cabecera;
            this.Poblacion = poblacion;
            this.Area = area;
            this.Densidad = densidad;
            this.IdRegion = idRegion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Iso { get => iso; set => iso = value; }
        public string Cabecera { get => cabecera; set => cabecera = value; }
        public decimal Poblacion { get => poblacion; set => poblacion = value; }
        public decimal Area { get => area; set => area = value; }
        public decimal Densidad { get => densidad; set => densidad = value; }
        public int IdRegion { get => idRegion; set => idRegion = value; }
    }

}