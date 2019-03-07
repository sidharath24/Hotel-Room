using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using static Android.Resource;

namespace Hotel_room
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText etTotalcash, etnight;
        RadioButton rdbsui, rdbdou, rdbsin;
        CheckBox cbtran, cbsp, cbtg;
        double total = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            etTotalcash = (EditText)FindViewById(Resource.Id.etTotal);
            etnight = (EditText)FindViewById(Resource.Id.etNights);
            rdbsui = (RadioButton)FindViewById(Resource.Id.rdbSuite);
            rdbdou = (RadioButton)FindViewById(Resource.Id.rdbDouble);
            rdbsin = (RadioButton)FindViewById(Resource.Id.rdbSingle);
            cbtran = (CheckBox)FindViewById(Resource.Id.cbTransp);
            cbsp = (CheckBox)FindViewById(Resource.Id.cbSpa);
            cbtg = (CheckBox)FindViewById(Resource.Id.cbTouristGuide);

         //   if(rdbsui.Checked)
         //   {
         //       total = 1400 * etnight.ToString();

         //   }

            if (cbtran.Checked)
                total = 1000;
            if (cbsp.Checked)
                total = 700;
            if (cbtg.Checked)
                total = 2000;

            etTotalcash.Text = total.ToString();

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

