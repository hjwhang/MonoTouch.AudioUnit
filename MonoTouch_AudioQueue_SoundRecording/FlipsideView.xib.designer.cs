// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monotouch_SoundRecording {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("FlipsideViewController")]
	public partial class FlipsideViewController {
		
		private FlipsideView __mt_view;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Export("done")]
		partial void done (MonoTouch.UIKit.UIBarButtonItem sender);

		[MonoTouch.Foundation.Connect("view")]
		private FlipsideView view {
			get {
				this.__mt_view = ((FlipsideView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIView or subclass
	[MonoTouch.Foundation.Register("FlipsideView")]
	public partial class FlipsideView {
	}
}