// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.BidiTypeGType))]
	public enum BidiType {

		L,
		Lre,
		Lro,
		R,
		Al,
		Rle,
		Rlo,
		Pdf,
		En,
		Es,
		Et,
		An,
		Cs,
		Nsm,
		Bn,
		B,
		S,
		Ws,
		On,
	}

	internal class BidiTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_bidi_type_get_type();
		static d_pango_bidi_type_get_type pango_bidi_type_get_type = FuncLoader.LoadFunction<d_pango_bidi_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_bidi_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_bidi_type_get_type ());
			}
		}
	}
#endregion
}