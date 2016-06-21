using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace WeirdSampleApp.UITests
{
	//[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void TestDialog()
		{
			//app.Repl();

			// Arranging
			Func<AppQuery, AppQuery> dialogButtonQuery = e => e.Text("Dialog");
			Func<AppQuery, AppQuery> noButtonQuery = e => e.Text("No");

			// Action
			app.WaitForElement(dialogButtonQuery, "Timed out waiting for dialog");
			app.Tap(dialogButtonQuery);

			app.WaitForElement(noButtonQuery);
			var result = app.Query(noButtonQuery).SingleOrDefault();

			// Asserting
			Assert.IsNotNull(result);
		}
	}
}

