﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.DebugLevelGType))]
	public enum DebugLevel {

		None = 0,
		Error = 1,
		Warning = 2,
		Fixme = 3,
		Info = 4,
		Debug = 5,
		Log = 6,
		Trace = 7,
		Memdump = 9,
		Count = 10,
	}

	internal class DebugLevelGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_debug_level_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_debug_level_get_type ());
			}
		}
	}
#endregion
}
