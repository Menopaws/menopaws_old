using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Menopaws.UITests
{
	[TestFixture(Platform.Android)]
	//[TestFixture(Platform.iOS)]
	public class MainPageTests
	{
		IApp app;
		Platform platform;

		public MainPageTests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
		    string apkpath = "C:\\Users\\Luce\\Desktop\\Development\\menopaws\\UITests\\co.uk.menopaws.Menopaws.apk";
		    app = ConfigureApp.Android.Debug().ApkFile(apkpath).StartApp();
        }

		[Test]
		public void AddHotFlushButtonExists()
		{
			AppResult[] results = app.WaitForElement(c =>  c.Button("ADD HOT FLUSH"));
			app.Screenshot("Hot Flush Button.");

			Assert.IsTrue(results.Any());
		}
	}
}
