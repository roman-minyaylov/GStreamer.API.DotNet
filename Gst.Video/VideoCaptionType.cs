﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Video.VideoCaptionTypeGType))]
	public enum VideoCaptionType {

		Unknown = 0,
		Cea608Raw = 1,
		Cea608S3341a = 2,
		Cea708Raw = 3,
		Cea708Cdp = 4,
	}

	internal class VideoCaptionTypeGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_caption_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_caption_type_get_type ());
			}
		}
	}
#endregion
}
