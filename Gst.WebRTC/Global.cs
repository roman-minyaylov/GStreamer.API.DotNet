﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Global {

		[DllImport(DLL.GstWebRTC, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_sdp_type_to_string(int type);

		public static string WebrtcSdpTypeToString(Gst.WebRTC.WebRTCSDPType type) {
			IntPtr raw_ret = gst_webrtc_sdp_type_to_string((int) type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

#endregion
	}
}
