﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Video.VideoOverlayFormatFlagsGType))]
	public enum VideoOverlayFormatFlags {

		None = 0,
		PremultipliedAlpha = 1,
		GlobalAlpha = 2,
	}

	internal class VideoOverlayFormatFlagsGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_format_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_overlay_format_flags_get_type ());
			}
		}
	}
#endregion
}
