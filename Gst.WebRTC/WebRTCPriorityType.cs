﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCPriorityTypeGType))]
	public enum WebRTCPriorityType {

		VeryLow = 1,
		Low = 2,
		Medium = 3,
		High = 4,
	}

	internal class WebRTCPriorityTypeGType {
		[DllImport (DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_priority_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_priority_type_get_type ());
			}
		}
	}
#endregion
}
