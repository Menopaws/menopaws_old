using System;
using MvvmHelpers;
using Xamarin.Forms;
namespace Menopaws
{
	public class HomePageViewModel : BaseViewModel
	{
		public HomePageViewModel()
		{
		}


		public Command CrisisButtonClicked
		{
			get
			{
				return new Command(() =>
				{
					throw new NotImplementedException();
				}

				);
			}
		}
	}
}
