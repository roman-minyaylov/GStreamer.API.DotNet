﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtp {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Rtp.RTPProfileGType))]
	public enum RTPProfile {

		Unknown = 0,
		Avp = 1,
		Savp = 2,
		Avpf = 3,
		Savpf = 4,
	}

	internal class RTPProfileGType {
		[DllImport (DLL.GstRtp, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtp_profile_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtp_profile_get_type ());
			}
		}
	}
#endregion
}
