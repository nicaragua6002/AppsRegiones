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
    [Activity(Label = "ActivityDetalleRegion")]
    public class ActivityDetalleRegion : Activity
    {
        Region region;
        TextView txtnombre, txtdescripcion;
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.detalleregion);
            int id = Intent.GetIntExtra("id", 0);
            //Recuperamos la region
            region = Global.Regiones.Where(x => x.Id == id).FirstOrDefault();

            txtnombre = FindViewById<TextView>(Resource.Id.textView1);

            txtdescripcion = FindViewById<TextView>(Resource.Id.textView2);
            vlista = FindViewById<ListView>(Resource.Id.listView1);


            txtnombre.Text = region.Nombre;
            txtdescripcion.Text = region.Descripcion;

            vlista.Adapter = new AdapterDepartamentos(this, Global.Departamentos.Where(x => x.IdRegion == region.Id).ToList());
        }
    }
}