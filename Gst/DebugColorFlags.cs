﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.DebugColorFlagsGType))]
	public enum DebugColorFlags {

		FgBlack = 0,
		BgBlack = 0,
		FgRed = 1,
		FgGreen = 2,
		FgYellow = 3,
		FgBlue = 4,
		FgMagenta = 5,
		FgCyan = 6,
		FgWhite = 7,
		BgRed = 16,
		BgGreen = 32,
		BgYellow = 48,
		BgBlue = 64,
		BgMagenta = 80,
		BgCyan = 96,
		BgWhite = 112,
		Bold = 256,
		Underline = 512,
	}

	internal class DebugColorFlagsGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_debug_color_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_debug_color_flags_get_type ());
			}
		}
	}
#endregion
}
