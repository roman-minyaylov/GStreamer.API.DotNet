﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.Audio.AudioBaseSinkSlaveMethodGType))]
	public enum AudioBaseSinkSlaveMethod {

		Resample = 0,
		Skew = 1,
		None = 2,
		Custom = 3,
	}

	internal class AudioBaseSinkSlaveMethodGType {
		[DllImport (DLL.GstAudio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_base_sink_slave_method_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_base_sink_slave_method_get_type ());
			}
		}
	}
#endregion
}
