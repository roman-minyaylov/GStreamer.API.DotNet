﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Video.VideoMultiviewFlagsGType))]
	public enum VideoMultiviewFlags {

		None = 0,
		RightViewFirst = 1,
		LeftFlipped = 2,
		LeftFlopped = 4,
		RightFlipped = 8,
		RightFlopped = 16,
		HalfAspect = 16384,
		MixedMono = 32768,
	}

	internal class VideoMultiviewFlagsGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_multiview_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_multiview_flags_get_type ());
			}
		}
	}
#endregion
}
