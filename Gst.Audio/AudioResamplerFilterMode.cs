﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Audio.AudioResamplerFilterModeGType))]
	public enum AudioResamplerFilterMode {

		Interpolated = 0,
		Full = 1,
		Auto = 2,
	}

	internal class AudioResamplerFilterModeGType {
		[DllImport (DLL.GstAudio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_resampler_filter_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_resampler_filter_mode_get_type ());
			}
		}
	}
#endregion
}
