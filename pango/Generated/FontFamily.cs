// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontFamily : GLib.Object {

		public FontFamily (IntPtr raw) : base(raw) {}

		protected FontFamily() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_font_family_get_name(IntPtr raw);
		static d_pango_font_family_get_name pango_font_family_get_name = FuncLoader.LoadFunction<d_pango_font_family_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_family_get_name"));

		public string Name { 
			get {
				IntPtr raw_ret = pango_font_family_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_font_family_get_type();
		static d_pango_font_family_get_type pango_font_family_get_type = FuncLoader.LoadFunction<d_pango_font_family_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_family_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_font_family_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_pango_font_family_is_monospace(IntPtr raw);
		static d_pango_font_family_is_monospace pango_font_family_is_monospace = FuncLoader.LoadFunction<d_pango_font_family_is_monospace>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_family_is_monospace"));

		public bool IsMonospace { 
			get {
				bool raw_ret = pango_font_family_is_monospace(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}
