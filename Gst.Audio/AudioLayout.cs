﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Audio.AudioLayoutGType))]
	public enum AudioLayout {

		Interleaved = 0,
		NonInterleaved = 1,
	}

	internal class AudioLayoutGType {
		[DllImport (DLL.GstAudio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_layout_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_layout_get_type ());
			}
		}
	}
#endregion
}
