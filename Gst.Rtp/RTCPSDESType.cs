﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtp {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Rtp.RTCPSDESTypeGType))]
	public enum RTCPSDESType {

		Invalid = -1,
		End = 0,
		Cname = 1,
		Name = 2,
		Email = 3,
		Phone = 4,
		Loc = 5,
		Tool = 6,
		Note = 7,
		Priv = 8,
	}

	internal class RTCPSDESTypeGType {
		[DllImport (DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtcpsdes_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtcpsdes_type_get_type ());
			}
		}
	}
#endregion
}
