﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Rtsp.RTSPEventGType))]
	public enum RTSPEvent {

		Read = 1,
		Write = 2,
	}

	internal class RTSPEventGType {
		[DllImport (DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_event_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtsp_event_get_type ());
			}
		}
	}
#endregion
}
