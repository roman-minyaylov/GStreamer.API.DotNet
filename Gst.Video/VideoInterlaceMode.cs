﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Video.VideoInterlaceModeGType))]
	public enum VideoInterlaceMode {

		Progressive = 0,
		Interleaved = 1,
		Mixed = 2,
		Fields = 3,
		Alternate = 4,
	}

	internal class VideoInterlaceModeGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_interlace_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_interlace_mode_get_type ());
			}
		}
	}
#endregion
}