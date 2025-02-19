using System.Diagnostics;
using SkiaSharp.Extended.UI.Controls;

namespace SkiaSharp_TrimWarnings_3._116._0;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
		BindingContext = this;
	}

	private void OnAnimationFailed(object sender, SKLottieAnimationFailedEventArgs e)
	{
		Debug.WriteLine($"Failed to load Lottie animation: {e.Exception}");
	}
	
	private void OnAnimationLoaded(object sender, SKLottieAnimationLoadedEventArgs e)
	{
		Debug.WriteLine($"Lottie animation loaded: {e.Size}; {e.Duration}; {e.Fps}");
	}
	
	private void OnAnimationCompleted(object sender, EventArgs e)
	{
		Debug.WriteLine("Lottie animation finished playing.");
	}
}

