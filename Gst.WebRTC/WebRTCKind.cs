﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCKindGType))]
	public enum WebRTCKind {

		Unknown = 0,
		Audio = 1,
		Video = 2,
	}

	internal class WebRTCKindGType {
		[DllImport (DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_kind_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_kind_get_type ());
			}
		}
	}
#endregion
}