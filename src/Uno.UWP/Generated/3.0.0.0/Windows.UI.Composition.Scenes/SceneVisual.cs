#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneVisual : global::Windows.UI.Composition.ContainerVisual
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.Scenes.SceneNode Root
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneNode SceneVisual.Root is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Scenes.SceneVisual", "SceneNode SceneVisual.Root");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneVisual.Root.get
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneVisual.Root.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Composition.Scenes.SceneVisual Create( global::Windows.UI.Composition.Compositor compositor)
		{
			throw new global::System.NotImplementedException("The member SceneVisual SceneVisual.Create(Compositor compositor) is not implemented in Uno.");
		}
		#endif
	}
}
