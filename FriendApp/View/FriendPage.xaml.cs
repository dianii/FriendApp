﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FriendPage : ContentPage
	{
		public FriendPage ()
		{
			InitializeComponent ();
		}
	}
}