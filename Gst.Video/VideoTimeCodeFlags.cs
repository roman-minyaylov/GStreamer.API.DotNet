﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Video.VideoTimeCodeFlagsGType))]
	public enum VideoTimeCodeFlags {

		None = 0,
		DropFrame = 1,
		Interlaced = 2,
	}

	internal class VideoTimeCodeFlagsGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_time_code_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_time_code_flags_get_type ());
			}
		}
	}
#endregion
}
