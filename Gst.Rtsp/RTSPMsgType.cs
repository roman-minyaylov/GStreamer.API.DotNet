﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Rtsp.RTSPMsgTypeGType))]
	public enum RTSPMsgType {

		Invalid = 0,
		Request = 1,
		Response = 2,
		HttpRequest = 3,
		HttpResponse = 4,
		Data = 5,
	}

	internal class RTSPMsgTypeGType {
		[DllImport (DLL.GstRtsp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_msg_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtsp_msg_type_get_type ());
			}
		}
	}
#endregion
}
