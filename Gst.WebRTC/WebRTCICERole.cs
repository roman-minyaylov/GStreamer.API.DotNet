﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCICERoleGType))]
	public enum WebRTCICERole {

		Controlled = 0,
		Controlling = 1,
	}

	internal class WebRTCICERoleGType {
		[DllImport (DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_ice_role_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_ice_role_get_type ());
			}
		}
	}
#endregion
}
