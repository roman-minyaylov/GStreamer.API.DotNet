﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Audio.AudioCdSrcModeGType))]
	public enum AudioCdSrcMode {

		Normal = 0,
		Continuous = 1,
	}

	internal class AudioCdSrcModeGType {
		[DllImport (DLL.GstAudio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_cd_src_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_cd_src_mode_get_type ());
			}
		}
	}
#endregion
}