﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Video.VideoFlagsGType))]
	public enum VideoFlags {

		None = 0,
		VariableFps = 1,
		PremultipliedAlpha = 2,
	}

	internal class VideoFlagsGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_flags_get_type ());
			}
		}
	}
#endregion
}
