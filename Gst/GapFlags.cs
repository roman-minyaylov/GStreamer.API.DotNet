﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.GapFlagsGType))]
	public enum GapFlags {

		Data = 1,
	}

	internal class GapFlagsGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gap_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_gap_flags_get_type ());
			}
		}
	}
#endregion
}
