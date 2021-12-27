﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Video.VideoColorPrimariesGType))]
	public enum VideoColorPrimaries {

		Unknown = 0,
		Bt709 = 1,
		Bt470m = 2,
		Bt470bg = 3,
		Smpte170m = 4,
		Smpte240m = 5,
		Film = 6,
		Bt2020 = 7,
		Adobergb = 8,
		Smptest428 = 9,
		Smpterp431 = 10,
		Smpteeg432 = 11,
		Ebu3213 = 12,
	}

	internal class VideoColorPrimariesGType {
		[DllImport (DLL.GstVideo, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_color_primaries_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_color_primaries_get_type ());
			}
		}
	}
#endregion
}
