// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

#region Autogenerated code
	public partial interface IExtractable : GLib.IWrapper {

		GES.Asset Asset { 
			get;
		}
		string Id { 
			get;
		}
		bool SetAsset(GES.Asset asset);
	}

	[GLib.GInterface (typeof (ExtractableAdapter))]
	public partial interface IExtractableImplementor : GLib.IWrapper {

		GES.Asset Asset { set; }
		string Id { get; }
	}
#endregion
}
