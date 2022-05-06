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
    [Activity(Label = "ActivityListaRegiones", MainLauncher = true)]
    public class ActivityListaRegiones : Activity
    {
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListaRegiones);

            vlista = FindViewById<ListView>(Resource.Id.listView1);

            //Vinculamosla fuente de los datos con el listview mediante el AdapterRegiones
            vlista.Adapter = new AdapterRegiones(this, Global.Regiones);

            vlista.ItemClick += Vlista_ItemClick;
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityDetalleRegion));

            //Obtener el id de la region seleccionada
            Region region = Global.Regiones[e.Position];

            i.PutExtra("id", region.Id);
            StartActivity(i);
        }
    }
}