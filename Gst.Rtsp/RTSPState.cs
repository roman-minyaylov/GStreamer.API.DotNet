﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Rtsp.RTSPStateGType))]
	public enum RTSPState {

		Invalid = 0,
		Init = 1,
		Ready = 2,
		Seeking = 3,
		Playing = 4,
		Recording = 5,
	}

	internal class RTSPStateGType {
		[DllImport (DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_state_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtsp_state_get_type ());
			}
		}
	}
#endregion
}