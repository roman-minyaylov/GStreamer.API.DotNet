﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.SchedulingFlagsGType))]
	public enum SchedulingFlags {

		Seekable = 1,
		Sequential = 2,
		BandwidthLimited = 4,
	}

	internal class SchedulingFlagsGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_scheduling_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_scheduling_flags_get_type ());
			}
		}
	}
#endregion
}
