// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.GravityGType))]
	public enum Gravity {

		South,
		East,
		North,
		West,
		Auto,
	}

	internal class GravityGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_gravity_get_type();
		static d_pango_gravity_get_type pango_gravity_get_type = FuncLoader.LoadFunction<d_pango_gravity_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_gravity_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_gravity_get_type ());
			}
		}
	}
#endregion
}
