﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Video.VideoAlphaModeGType))]
	public enum VideoAlphaMode {

		Copy = 0,
		Set = 1,
		Mult = 2,
	}

	internal class VideoAlphaModeGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_alpha_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_alpha_mode_get_type ());
			}
		}
	}
#endregion
}
