﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Rtsp.RTSPTimeTypeGType))]
	public enum RTSPTimeType {

		Seconds = 0,
		Now = 1,
		End = 2,
		Frames = 3,
		Utc = 4,
	}

	internal class RTSPTimeTypeGType {
		[DllImport (DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_time_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtsp_time_type_get_type ());
			}
		}
	}
#endregion
}
