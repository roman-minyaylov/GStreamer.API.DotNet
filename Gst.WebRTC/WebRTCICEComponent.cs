﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCICEComponentGType))]
	public enum WebRTCICEComponent {

		Rtp = 0,
		Rtcp = 1,
	}

	internal class WebRTCICEComponentGType {
		[DllImport (DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_ice_component_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_ice_component_get_type ());
			}
		}
	}
#endregion
}
