﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCICEConnectionStateGType))]
	public enum WebRTCICEConnectionState {

		New = 0,
		Checking = 1,
		Connected = 2,
		Completed = 3,
		Failed = 4,
		Disconnected = 5,
		Closed = 6,
	}

	internal class WebRTCICEConnectionStateGType {
		[DllImport (DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_ice_connection_state_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_ice_connection_state_get_type ());
			}
		}
	}
#endregion
}
