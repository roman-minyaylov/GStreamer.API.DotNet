﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCSDPTypeGType))]
	public enum WebRTCSDPType {

		Offer = 1,
		Pranswer = 2,
		Answer = 3,
		Rollback = 4,
	}

	internal class WebRTCSDPTypeGType {
		[DllImport (DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_sdp_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_sdp_type_get_type ());
			}
		}
	}
#endregion
}
