using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListViewTutorial
{
	[Activity(Label = "ListViewTutorial", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private List<string> mItems;
		private ListView mListView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			mListView = FindViewById<ListView>(Resource.Id.myListView);

			mItems = new List<string>();
			mItems.Add("Bob");
			mItems.Add("Toni");
			mItems.Add("Jim");
			mItems.Add("Ka-oi");

			ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
			mListView.Adapter = adapter;

		}
	}
}
