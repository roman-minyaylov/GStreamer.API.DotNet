﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.ElementFlagsGType))]
	public enum ElementFlags {

		LockedState = 16,
		Sink = 32,
		Source = 64,
		ProvideClock = 128,
		RequireClock = 256,
		Indexable = 512,
		Last = 16384,
	}

	internal class ElementFlagsGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_element_flags_get_type ());
			}
		}
	}
#endregion
}
