﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.DebugGraphDetailsGType))]
	public enum DebugGraphDetails {

		MediaType = 1,
		CapsDetails = 2,
		NonDefaultParams = 4,
		States = 8,
		All = 15,
		FullParams = 16,
		Verbose = -1,
	}

	internal class DebugGraphDetailsGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_debug_graph_details_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_debug_graph_details_get_type ());
			}
		}
	}
#endregion
}
