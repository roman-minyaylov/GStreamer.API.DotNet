﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Audio.AudioBaseSinkDiscontReasonGType))]
	public enum AudioBaseSinkDiscontReason {

		NoDiscont = 0,
		NewCaps = 1,
		Flush = 2,
		SyncLatency = 3,
		Alignment = 4,
		DeviceFailure = 5,
	}

	internal class AudioBaseSinkDiscontReasonGType {
		[DllImport (DLL.GstAudio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_base_sink_discont_reason_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_base_sink_discont_reason_get_type ());
			}
		}
	}
#endregion
}
