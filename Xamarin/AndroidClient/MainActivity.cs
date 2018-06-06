using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace AndroidApp
{
    [Activity(Label = "Xamarin Android Chat Client", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            MakeProtocol();

            //base.OnCreate(savedInstanceState);

            //// Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);

            ////Setting up references to views
            //var connectButton = FindViewById<Button>(Resource.Id.bConnect);
            //var listView = FindViewById<ListView>(Resource.Id.lvMessages);
            //var sendButton = FindViewById<Button>(Resource.Id.bSend);
            //var messageText = FindViewById<EditText>(Resource.Id.etMessageText);
            //var connected = false;

            //var hubConnection = new HubConnectionBuilder()
            //        .WithUrl("http://localhost:5000/")
            //        .Build();

            ////Setting up window to enter name
            //AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(this);
            //alertDialogBuilder.SetTitle("Enter Your Name");

            //var userName = "";
            //var nameInput = new EditText(this);
            //nameInput.InputType = Android.Text.InputTypes.TextVariationPersonName;
            //alertDialogBuilder.SetView(nameInput);

            //alertDialogBuilder.SetPositiveButton("Ok", (_, __) =>
            //{
            //    userName = nameInput.Text;
            //});

            //alertDialogBuilder.SetNegativeButton("Cancel", (_, __) => { });

            //alertDialogBuilder.Show();

            //var messages = new List<string>();
            //var arrayAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, messages);
            //listView.Adapter = arrayAdapter;

            //connectButton.Click += async (sender, e) =>
            //{
            //    await hubConnection.StartAsync();
            //    connectButton.Enabled = false;
            //    connected = true;
            //    Toast.MakeText(this, "Connected", ToastLength.Short).Show();
            //    await hubConnection.InvokeAsync("Send", userName, "is now connected");
            //};

            //hubConnection.On<string, string>("broadcastMessage", (name, message) =>
            //{
            //    var newMessage = $"{name}: {message}";
            //    RunOnUiThread(() => {
            //        arrayAdapter.Add(newMessage);
            //        arrayAdapter.NotifyDataSetChanged();
            //    });
            //});

            //sendButton.Click += async (sender, e) =>
            //{
            //    if (!connected)
            //    {
            //        Toast.MakeText(this, "Must be Connected to Send!", ToastLength.Short).Show();
            //        return;
            //    }

            //    try
            //    {
            //        await hubConnection.InvokeAsync("Send", userName, messageText.Text);
            //        messageText.Text = "";
            //    }
            //    catch (Exception ex)
            //    {
            //        var exception = ex;
            //    }
            //};
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void MakeProtocol()
        {
            var proto = new JsonHubProtocol();
        }
    }
}

